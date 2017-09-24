using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        string command = Console.ReadLine();
        FunctionBulder(command, input);
    }

    private static void FunctionBulder(string command, int[] inputNums)
    {
        while (command != "end")
        {
            switch (command)
            {
                case "add":
                    for (int i = 0; i < inputNums.Length; i++)
                    {
                        inputNums[i] += 1;
                    }
                    break;
                case "print":
                    Func<int, string> printed = x => x.ToString();
                    foreach (var n in inputNums)
                    {
                        Console.Write(printed(n) + " ");
                    }
                    Console.WriteLine();
                    break;
                case "multiply":
                    for (int i = 0; i < inputNums.Length; i++)
                    {
                        inputNums[i] *= 2;
                    }
                    break;
                case "subtract":
                    for (int i = 0; i < inputNums.Length; i++)
                    {
                        inputNums[i] -= 1;
                    }
                    break;
            }
            command = Console.ReadLine();
        }
    }
}

