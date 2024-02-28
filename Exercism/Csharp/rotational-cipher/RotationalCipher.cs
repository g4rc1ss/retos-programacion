using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

public static class RotationalCipher
{
    private static readonly string abc = "abcdefghijklmnopqrstuvwxyz";
    private static readonly string ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static string Rotate(string text, int shiftKey)
    {
        var result = new StringBuilder();
        foreach (var character in text)
        {
            var indexMinus = abc.IndexOf(character);
            var indexMayus = ABC.IndexOf(character);
            if (indexMinus == -1 && indexMayus == -1)
            {
                result.Append(character);
                continue;
            }
            if (indexMayus != -1)
            {
                result.Append(ABC[(indexMayus + shiftKey) % ABC.Length]);
            }

            if (indexMinus != -1)
            {
                result.Append(abc[(indexMinus + shiftKey) % abc.Length]);
            }
        }
        return result.ToString();
    }
}