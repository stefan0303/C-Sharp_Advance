using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        List<int> zero = new List<int>();
        List<int> one = new List<int>();
        List<int> two = new List<int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] % 3 == 0)
            {
                zero.Add(input[i]);
            }
            else if (input[i] % 3 == 1 || input[i] % 3 == -1)
            {
                one.Add(input[i]);
            }
            else if (input[i] % 3 == 2 || input[i] % 3 == -2)
            {
                two.Add(input[i]);
            }

        }
        Console.WriteLine(string.Join(" ", zero));
        Console.WriteLine(string.Join(" ", one));
        Console.WriteLine(string.Join(" ", two));

    }
}
