var puzzle = File.ReadAllText("puzzle.txt");

#region Parte 1
var xCasa = 0;
var yCasa = 0;
var casasRepartidas = new Dictionary<string, int>
{
    {$"{yCasa}_{xCasa}", 1 }
};

foreach (var item in puzzle)
{
    Repartir(item, ref yCasa, ref xCasa, ref casasRepartidas);
    casasRepartidas.TryAdd($"{yCasa}_{xCasa}", 1);
}

Console.WriteLine($"El numero de casas repartidas es: {casasRepartidas.Count}");
#endregion

#region Parte 2
var xSanta = 0;
var ySanta = 0;
var casasSanta = new Dictionary<string, int>();
casasSanta.Add($"{0}_{0}", 1);

var xRoboSanta = 0;
var yRoboSanta = 0;

var esSanta = true;
foreach (var item in puzzle)
{
    if (esSanta)
    {
        Repartir(item, ref ySanta, ref xSanta, ref casasSanta);
        esSanta = false;
    }
    else
    {
        Repartir(item, ref yRoboSanta, ref xRoboSanta, ref casasSanta);
        esSanta = true;
    }
}

Console.WriteLine($"El numero de casas repartidas es: {casasSanta.Count}");
#endregion

static void Repartir(char item, ref int y, ref int x, ref Dictionary<string, int> casasVisitadas)
{
    switch (item)
    {
        case '^':
            y--;
            break;
        case '<':
            x--;
            break;
        case '>':
            x++;
            break;
        case 'v':
            y++;
            break;
        default:
            break;
    }
    casasVisitadas.TryAdd($"{y}_{x}", 1);
}

Console.ReadKey();
