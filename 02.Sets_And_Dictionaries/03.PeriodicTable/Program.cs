using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        SortedSet<string> elements = new SortedSet<string>();

        for (int i = 0; i < n; i++)
        {
            string[] inputLineElements = Console.ReadLine().Split(' ');

            for (int m = 0; m < inputLineElements.Length; m++)
            {
                elements.Add(inputLineElements[m]);
            }
        }

        Console.WriteLine();
        foreach (var item in elements)
        {
            Console.Write(item + " ");
        }
    }
}

