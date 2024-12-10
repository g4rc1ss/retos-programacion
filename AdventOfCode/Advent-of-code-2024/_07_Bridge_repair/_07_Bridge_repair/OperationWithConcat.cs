namespace _07_Bridge_repair;

public class OperationWithConcat
{
    private bool HasMoreResults { get; set; }

    private readonly long _result = 0;
    private (OperationWithConcat? add, OperationWithConcat? mul, OperationWithConcat? concat) Next { get; set; }

    public OperationWithConcat(long op1)
    {
        _result = op1;
    }

    public void Do(long op)
    {
        var (add, mul, concat) = Next;
        if (add != null)
        {
            add?.Do(op);
            mul?.Do(op);
            concat?.Do(op);
        }
        else
        {
            Next = (
                new OperationWithConcat(_result + op),
                new OperationWithConcat(_result * op),
                new OperationWithConcat(long.Parse($"{_result}{op}"))
            );
        }

        HasMoreResults = true;
    }

    public bool FindResult(long expected)
    {
        if (!HasMoreResults) return _result == expected;

        var isFindAdd = Next.add?.FindResult(expected);
        var isFindMul = Next.mul?.FindResult(expected);
        var isFindConcat = Next.concat?.FindResult(expected);
        return isFindAdd == true || isFindMul == true || isFindConcat == true;
    }
}