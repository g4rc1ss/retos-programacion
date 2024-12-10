using System.Text.RegularExpressions;

namespace _07_Bridge_repair;

public class Exercise()
{
    public long Part1(string[] textLines)
    {
        long finalResult = 0;
        foreach (var text in textLines)
        {
            var (expectedResult, numbersToCheck) = ParseResults(text);
            var prueba = new Operation(numbersToCheck[0]);

            for (var i = 1; i < numbersToCheck.Count; i++)
            {
                prueba.Do(numbersToCheck[i]);
            }

            Console.WriteLine(text);
            if (!prueba.FindResult(expectedResult)) continue;
            finalResult += expectedResult;
        }

        return finalResult;
    }

    public long Part2(string[] textLines)
    {
        long finalResult = 0;
        foreach (var text in textLines)
        {
            var (expectedResult, numbersToCheck) = ParseResults(text);
            var prueba = new OperationWithConcat(numbersToCheck[0]);

            for (var i = 1; i < numbersToCheck.Count; i++)
            {
                prueba.Do(numbersToCheck[i]);
            }

            Console.WriteLine(text);
            if (!prueba.FindResult(expectedResult)) continue;
            finalResult += expectedResult;
        }

        return finalResult;
    }

    private (long expected, List<long> numbersToCheck) ParseResults(string line)
    {
        var patternExpectedValue = @"\d{1,100}\:";
        var regex = new Regex(patternExpectedValue);
        var expectedValue = long.Parse(regex.Matches(line).Single().Value.TrimEnd(':'));

        var patterValuesToCheck = @"(\d{1,10} )|( \d{1,10})";
        regex = new Regex(patterValuesToCheck);
        var valuesToCheck = regex.Matches(line).Select(x => long.Parse(x.Value)).ToList();

        return (expectedValue, valuesToCheck)!;
    }
}