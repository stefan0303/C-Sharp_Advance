using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        SortedDictionary<char, int> letters = new SortedDictionary<char, int>();
        char[] sentece = Console.ReadLine().ToCharArray();

        foreach (var item in sentece)
        {
            if (letters.ContainsKey(item))
            {
                letters[item] += 1;
            }
            else
            {
                letters.Add(item, 1);
            }

        }
        foreach (var item in letters)
        {
            Console.WriteLine("{0}: {1} time/s", item.Key, item.Value);
        }
    }
}

