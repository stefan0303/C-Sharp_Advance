using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int n = int.Parse(Console.ReadLine());
        Predicate<int> divisible = x => x % n != 0;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (divisible(input[i]) == false)
            {
                continue;
            }
            Console.Write(input[i] + " ");
        }
    }
}

