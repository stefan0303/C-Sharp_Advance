using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        var regex = new Regex("(.)\\1+");


        Console.WriteLine(regex.Replace(input, "$1")); // something like! this
    }
}

