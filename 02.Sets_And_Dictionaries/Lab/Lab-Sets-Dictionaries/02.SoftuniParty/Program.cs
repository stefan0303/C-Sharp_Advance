using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var partyNumbers = new SortedSet<string>();
        string input = Console.ReadLine();
        while (input != "PARTY")
        {
            if (input.Length != 8)
            {
                break;
            }
            partyNumbers.Add(input);
            input = Console.ReadLine();
        }
        while (input != "END")
        {
            input = Console.ReadLine();
            if (partyNumbers.Contains(input))
            {
                partyNumbers.Remove(input);
            }
        }
        Console.WriteLine(partyNumbers.Count);
        foreach (var num in partyNumbers)
        {
            Console.WriteLine(num);
        }
    }
}

