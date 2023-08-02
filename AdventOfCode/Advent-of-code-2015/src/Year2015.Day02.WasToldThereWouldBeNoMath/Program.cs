var puzzle = File.ReadAllLines("puzzle.txt");

#region Parte 1
var totalPedir = 0;
foreach (var item in puzzle)
{
    var numeros = item.Split('x').Select(x => int.Parse(x)).ToArray();
    var areas = new List<int>();
    areas.Add(numeros[0] * numeros[1]);
    areas.Add(numeros[1] * numeros[2]);
    areas.Add(numeros[2] * numeros[0]);
    totalPedir += (2 * (areas[0] + areas[1] + areas[2])) + areas.Min();
}
Console.WriteLine($"Total papel a pedir = {totalPedir} pies");
#endregion

#region Parte 2
totalPedir = 0;
foreach (var item in puzzle)
{
    var numeros = item.Split('x').Select(x => int.Parse(x)).OrderBy(x => x).ToArray();
    totalPedir += (2 * (numeros[0] + numeros[1])) + (numeros[0] * numeros[1] * numeros[2]);
}
Console.WriteLine($"Total de cinta a pedir = {totalPedir} pies");
#endregion

Console.ReadKey();
