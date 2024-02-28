using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

public static class ParallelLetterFrequency
{
    public static Dictionary<char, int> Calculate(IEnumerable<string> texts)
    {
        var response = new Dictionary<char, int>();
        var lockContainsObject = new object();
        var lockNewObject = new object();

        Parallel.ForEach(texts, new ParallelOptions() { MaxDegreeOfParallelism = 100 },
            item =>
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            var lowerItem = item.ToLower();
            foreach (var character in lowerItem)
            {
                if (Regex.IsMatch(character.ToString(), @"(\s|,|\d)"))
                {
                    continue;
                }
                if (response.ContainsKey(character))
                {
                    lock (lockContainsObject)
                    {
                        response[character] = ++response[character];
                    }
                }
                else
                {
                    lock (lockNewObject)
                    {
                        response.Add(character, 1);
                    }
                }
            }
        });

        return response.ToDictionary();
    }
}