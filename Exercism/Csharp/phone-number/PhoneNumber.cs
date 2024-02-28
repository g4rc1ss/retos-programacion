using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var result = Regex.Replace(phoneNumber, @"\D", string.Empty);
        var _ = Validate(result) ? true : throw new ArgumentException();

        var stringResult = new StringBuilder();
        foreach (var item in result.TakeLast(10))
        {
            stringResult.Append(item);
        }
        return stringResult.ToString();
    }

    private static bool Validate(string cleanNumber) => 
        Regex.IsMatch(cleanNumber, @"^(1|\+1|)[2-9]\d{2}[2-9]\d{6}$");
}