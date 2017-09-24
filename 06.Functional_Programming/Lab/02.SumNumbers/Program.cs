using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split(new[] { ' ', ',' },
            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
   
        Console.WriteLine(input.Count);
        Console.WriteLine(input.Sum());
        
    }
}

