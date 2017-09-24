using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> minary = new Dictionary<string, int>();
        string command = "";

        while (command != "stop")
        {
            command = Console.ReadLine();
            if (command == "stop")
            {
                break;
            }
            int quantity = int.Parse(Console.ReadLine());

            if (minary.ContainsKey(command))
            {
                int value = minary[command];
                minary[command] = quantity + value;
            }
            else
            {
                minary.Add(command, 0);

                minary[command] = quantity;
            }
        }

        Console.WriteLine();
        foreach (var item in minary)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}

