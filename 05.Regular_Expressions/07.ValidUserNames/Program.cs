using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        Regex regex = new Regex(@"^[\w\d-]{3,16}$");
        while (text != "END")
        {
            MatchCollection matches = regex.Matches(text);
            if (matches.Count > 0)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
            text = Console.ReadLine();
        }
    }
}

