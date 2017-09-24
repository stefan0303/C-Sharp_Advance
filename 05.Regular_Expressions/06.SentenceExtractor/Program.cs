using System;
using System.Text.RegularExpressions;

class Program
{
    public static void Main()
    {
        var key = Console.ReadLine();

        var input = Console.ReadLine();
        var pattern = $@"[a-zA-Z0-9 ]+\b{key}\b\s*.*?[?!.]";

        var matches = Regex.Matches(input, pattern);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups[0]);
        }
    }
}

