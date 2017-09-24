using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = input[0]; //Push elements in Stack
        int s = input[1]; //Elements to Pop  from Stack
        int x = input[2]; //Elementh present in stack

        int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Stack<int> numbers = new Stack<int>();
        for (int i = 0; i < n; i++)
        {
            numbers.Push(num[i]);
        }
        for (int i = 0; i < s && numbers.Count > 0; i++)
        {
            numbers.Pop();
        }
        if (numbers.Contains(x))
        {
            Console.WriteLine("true");
        }
        else if (numbers.Count == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(numbers.Min());
        }
    }
}

