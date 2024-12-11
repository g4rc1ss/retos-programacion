using System.Diagnostics;
using _09_disk_fragmenter;


var text = await File.ReadAllLinesAsync("./input.txt");
var textMock = new[] { "2333133121414131402" };
// var textMock = new[] { "12345" };

var exercise = new Exercise();

var stopwatch = Stopwatch.StartNew();
var part1 = exercise.Part1(text);
var part2 = exercise.Part2(textMock);
stopwatch.Stop();

Console.WriteLine("-------------------------");
Console.WriteLine($"Parte 1: {part1}");
Console.WriteLine($"Parte 2: {part2}");
Console.WriteLine("-------------------------");
Console.WriteLine(TimeSpan.FromMilliseconds(stopwatch.ElapsedMilliseconds).TotalSeconds);