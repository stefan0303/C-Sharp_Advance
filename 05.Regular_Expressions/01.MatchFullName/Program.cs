using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string pattren = "\\b([A-Z][a-z]+) [A-Z][a-z]+\\b";
        string input = Console.ReadLine();
        Regex regex = new Regex(pattren);

        while (input != "end")
        {
            if (regex.IsMatch(input))
            {
                Console.WriteLine(input);
            }

            input = Console.ReadLine();
        }
    }
}

