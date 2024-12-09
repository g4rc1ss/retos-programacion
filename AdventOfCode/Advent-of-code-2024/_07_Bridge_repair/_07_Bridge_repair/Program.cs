using System.Diagnostics;
using _07_Bridge_repair;

var exercise = new Exercise();

var stopwatch = Stopwatch.StartNew();
exercise.Part1();
exercise.Part2();
stopwatch.Stop();
Console.WriteLine(TimeSpan.FromMilliseconds(stopwatch.ElapsedMilliseconds).TotalSeconds);