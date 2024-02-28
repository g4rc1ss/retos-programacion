using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text.RegularExpressions;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        CheckInput(digits, span);
        var listResult = new List<long>();
        for (int i = 0; i < digits.Length; i++)
        {
            var maxIndex = i + span;
            if (maxIndex > digits.Length)
            {
                break;
            }
            var numbers = digits[i..maxIndex]
                .Select(x => int.Parse(new ReadOnlySpan<char>(in x)));

            long result = 1;
            foreach (var item in numbers)
                result *= item;

            listResult.Add(result);
        }
        return listResult
            .Max();
    }

    private static void CheckInput(string digits, int span)
    {
        if (span <= digits.Length && span > 0
        && !string.IsNullOrEmpty(digits) 
        // Busca caracteres no numericos
        && !Regex.IsMatch(digits, @"(\D)"))
        {
            return;
        }
        throw new ArgumentException();
    }
}