using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        string oddOrEven = Console.ReadLine();

        for (int i = input[0]; i <= input[1]; i++)
        {
            FindEvenOrOdd(oddOrEven, i);
        }
    }

    private static void FindEvenOrOdd(string command, int num)
    {
        Predicate<int> isEven = n => n % 2 != 0;
        if (command == "even" && isEven(num) == false)
        {
            Console.Write(num + " ");
        }

        else if (command == "odd" && isEven(num))
        {
            Console.Write(num + " ");
        }
    }
}

