using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        //  @"(?<=\s|^)([^\W_][\w.-]*[^\W_]|[^\W_])@[^\W_](([a-zA-Z-]*[a-zA-Z]+|[a-zA-Z]*)\.([a-zA-Z]+[a-zA-Z-]*|[a-zA-Z]*))+[^\W_]\b";

        string patternMeil = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@[a-z]+\-?[a-z]+(?:\.[a-z]+)+)\b";
        Regex regexMail = new Regex(patternMeil);
        MatchCollection matches = regexMail.Matches(text);

        foreach (Match name in matches)
        {
            Console.WriteLine(name.Groups[0]);
        }
    }
}