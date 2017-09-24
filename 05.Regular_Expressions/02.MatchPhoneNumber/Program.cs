using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string pattren = "\\+359 2 [1-9][1-9][1-9] [1-9][1-9][1-9][1-9]";
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

