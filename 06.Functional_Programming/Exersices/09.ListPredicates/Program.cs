using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int count = 0;
        Func<int, int, bool> filter = (g, p) => g % p == 0;
        List<int> result = new List<int>();

        for (int j = 1; j <= n; j++) //all nums
        {
            var hasPassed = true;

            for (int i = 0; i < input.Length; i++) //all divide numbers
            {

                if (!filter(j, input[i]))
                {

                    hasPassed = false;
                    break;
                }

            }
            if (hasPassed)
            {
                result.Add(j);
            }
        }
        Console.WriteLine(string.Join(" ", result));

    }
}

