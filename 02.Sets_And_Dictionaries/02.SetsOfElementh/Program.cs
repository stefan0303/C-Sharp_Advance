using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = input[0];   //lenght of first set
        int m = input[1];  //lenght of second set
        HashSet<int> firstSet = new HashSet<int>();
        HashSet<int> secondSet = new HashSet<int>();

        for (int i = 0; i < n; i++)
        {
            firstSet.Add(int.Parse(Console.ReadLine()));
        }

        for (int i = 0; i < m; i++)
        {
            secondSet.Add(int.Parse(Console.ReadLine()));
        }

        foreach (var item in firstSet)
        {
            if (secondSet.Contains(item))
            {
                Console.WriteLine(item);
            }

        }
    }
}

