using System;
using System.Diagnostics;
using System.IO;
using _08_resonant_collinearity;


var text = await File.ReadAllLinesAsync("./input.txt");
var textMock =
    "............\n........0...\n.....0......\n.......0....\n....0.......\n......A.....\n............\n............\n........A...\n.........A..\n............\n............"
        .Split(Environment.NewLine);

var exercise = new Exercise();

var stopwatch = Stopwatch.StartNew();
var part1 = exercise.Part1(textMock);
var part2 = exercise.Part2(textMock);
stopwatch.Stop();

Console.WriteLine("-------------------------");
Console.WriteLine($"Parte 1: {part1}");
Console.WriteLine($"Parte 2: {part2}");
Console.WriteLine("-------------------------");
Console.WriteLine(TimeSpan.FromMilliseconds(stopwatch.ElapsedMilliseconds).TotalSeconds);