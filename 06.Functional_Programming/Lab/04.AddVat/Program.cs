using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.ReadLine()
   .Split(new string[] { ", " },
       StringSplitOptions.RemoveEmptyEntries)
   .Select(double.Parse)
   .Select(n => n * 1.2)
   .ToList()
   .ForEach(n => Console.WriteLine($"{n:n2}"));

    }
}

