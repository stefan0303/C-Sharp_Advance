using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Func<int[], int> print = x => x.Min();
        Console.WriteLine(print(input));

    }
}




