using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();
        Action<string> example1 =
                (x) => Console.WriteLine(x);
        for (int i = 0; i < input.Length; i++)
        {

            example1.Invoke(input[i]);
        }

    }
}

