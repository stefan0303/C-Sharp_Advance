using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string html = Console.ReadLine();

        string pattern = "<a(\\shref=.+)>(.+)<\\/a>";

        Console.WriteLine(Regex.Replace(html, pattern, @"[URL href=$1]$2[/URL]"));
    }
}

