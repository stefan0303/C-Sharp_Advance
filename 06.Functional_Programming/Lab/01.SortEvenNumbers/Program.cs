using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(string.Join(", ", Console.ReadLine()
            .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).Where(n => n % 2 == 0).OrderBy(n => n).ToList()));
    }
}