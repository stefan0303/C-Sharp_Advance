using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string inputLine;
        StringBuilder input = new StringBuilder();
        StringBuilder output = new StringBuilder();
        Dictionary<char, int> specialSymbolWeights = new Dictionary<char, int>
        {
            {'$', 1},
            {'%', 2},
            {'&', 3},
            {'\'', 4}
        };

        while ((inputLine = Console.ReadLine()) != "burp")
        {
            input.Append(inputLine);
        }

        string text = Regex.Replace(input.ToString(), @"\s+", " ");
        Regex stringMatcher = new Regex(@"([$%&'])([^$%&']+)\1");
        var matches = stringMatcher.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
            char specialSymbol = match.Groups[1].Value[0];
            string capturedString = match.Groups[2].Value;
            int stringLength = capturedString.Length;

            for (int i = 0; i < stringLength; i++)
            {
                char currentSymbol = capturedString[i];
                char resultingSymbol;

                if (i % 2 == 0)
                {
                    resultingSymbol = (char)(currentSymbol + specialSymbolWeights[specialSymbol]);
                }
                else
                {
                    resultingSymbol = (char)(currentSymbol - specialSymbolWeights[specialSymbol]);
                }

                output.Append(resultingSymbol);
            }

            output.Append(" ");
        }

        Console.WriteLine(output);
    }
}