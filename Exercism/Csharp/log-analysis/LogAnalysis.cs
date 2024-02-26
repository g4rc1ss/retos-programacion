using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string text, string filter){
        var index = text.IndexOf(filter);
        var result = text[(index + filter.Length)..];
        Console.WriteLine(result);
        return result;
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string text, string start, string end){
        var startIndex = text.IndexOf(start);
        Console.WriteLine(startIndex);
        var endIndex = text.IndexOf(end);
        Console.WriteLine(endIndex);
        var result = text[(startIndex + start.Length)..endIndex];
        Console.WriteLine(result);

        return result;
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string text){
        return text.SubstringAfter("]:").TrimStart().TrimEnd();
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string text){
        return text.SubstringBetween("[", "]").TrimStart().TrimEnd();
    }
}