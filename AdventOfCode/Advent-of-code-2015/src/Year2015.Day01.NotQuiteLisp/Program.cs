var puzzle = await File.ReadAllTextAsync("puzzle.txt");

# region Parte 1
Console.WriteLine("------------ Parte 1 ------------");

var piso = 0;
foreach (var item in puzzle)
{
    if (item.Equals('('))
    {
        piso++;
    }
    else if (item.Equals(')'))
    {
        piso--;
    }
}

Console.WriteLine(piso);
#endregion

#region Parte 2
Console.WriteLine("------------ Parte 2 ------------");

piso = 0;
for (var i = 0; i < puzzle.Length; i++)
{
    var item = puzzle[i];
    if (item.Equals('('))
    {
        piso++;
    }
    else if (item.Equals(')'))
    {
        piso--;
    }

    if (piso == -1)
    {
        Console.WriteLine($"Ha entrado al sotano en la posicion {i + 1}");
        break;
    }
}

#endregion

Console.ReadKey();
