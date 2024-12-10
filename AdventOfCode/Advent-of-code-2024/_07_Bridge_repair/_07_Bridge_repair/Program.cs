using System.Diagnostics;
using _07_Bridge_repair;


var text = await File.ReadAllLinesAsync("./input.txt");
var textMock =
    "190: 10 19\n3267: 81 40 27\n83: 17 5\n156: 15 6\n7290: 6 8 6 15\n161011: 16 10 13\n192: 17 8 14\n21037: 9 7 18 13\n292: 11 6 16 20"
        .Split(Environment.NewLine);

var exercise = new Exercise();

var stopwatch = Stopwatch.StartNew();
var part1 = exercise.Part1(text);
var part2 = exercise.Part2(text);
stopwatch.Stop();

Console.WriteLine("-------------------------");
Console.WriteLine($"Parte 1: {part1}");
Console.WriteLine($"Parte 2: {part2}");
Console.WriteLine("-------------------------");
Console.WriteLine(TimeSpan.FromMilliseconds(stopwatch.ElapsedMilliseconds).TotalSeconds);