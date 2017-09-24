using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ').ToArray();
        Func<string, bool> findStrings = x => x.Length <= n;

        foreach (var name in input)
        {
            if (findStrings(name))
            {
                Console.WriteLine(name);
            }
        }

    }
}

