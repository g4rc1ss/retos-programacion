using System.Text;

namespace _07_Bridge_repair;

public class Operation
{
    private bool HasMoreResults { get; set; }

    private readonly long _result = 0;
    private readonly string _concatOperation = "";
    private (Operation? add, Operation? mul) Next { get; set; }

    public Operation(long op1)
    {
        _result = op1;
    }

    public void Do(long op)
    {
        var (add, mul) = Next;
        if (add != null)
        {
            add?.Do(op);
            mul?.Do(op);
        }
        else
        {
            Next = (new Operation(_result + op), new Operation(_result * op));
        }

        HasMoreResults = true;
    }

    public bool FindResult(long expected)
    {
        if (!HasMoreResults) return _result == expected;

        var isFindAdd = Next.add?.FindResult(expected);
        var isFindMul = Next.mul?.FindResult(expected);
        return isFindAdd == true || isFindMul == true;
    }
}