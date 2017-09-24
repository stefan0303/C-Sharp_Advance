using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = input[0];
        int s = input[1];
        int x = input[2];
        Queue<int> numbers = new Queue<int>();

        for (int i = 0; i < n; i++)
        {
            numbers.Enqueue(inputNums[i]);
        }
        for (int i = 0; i < s; i++)
        {
            numbers.Dequeue();
        }
        if (numbers.Contains(x))
        {
            Console.WriteLine("true");
        }
        else if (numbers.Count != 0)
        {
            Console.WriteLine(numbers.Min());
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}

