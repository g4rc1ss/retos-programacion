

var list = Enumerable.Range(1, 100)
    .Select(x =>
        x % 15 == 0 ? "FizzBuzz"
        : x % 5 == 0 ? "buzz"
        : x % 3 == 0 ? "fizz"
        : $"Numero no multiplo {x} || {x % 3} || {x % 5}");

foreach (var item in list)
{
    Console.WriteLine(item);
}