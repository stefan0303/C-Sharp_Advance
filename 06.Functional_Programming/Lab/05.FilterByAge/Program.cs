using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, int> nameAge = new Dictionary<string, int>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            nameAge.Add(input[0], Convert.ToInt32(input[1]));

        }
        string condition = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string format = Console.ReadLine();
        Func<int, bool> tester = CreateTester(condition, age);
        Action<KeyValuePair<string, int>> printer =
                                          CreatePrinter(format);
        foreach (var perosn in nameAge)
        {
            if (tester(perosn.Value))
            {
                printer(perosn);
            }
        }
        //  CreatePrinter(people, tester, printer);

    }

    public static Func<int, bool> CreateTester
                 (string condition, int age)
    {
        switch (condition)
        {
            case "younger": return x => x < age;
            case "older": return x => x >= age;
            default: return null;
        }
    }

    public static Action<KeyValuePair<string, int>>
        CreatePrinter(string format)
    {
        switch (format)
        {
            case "name":
                return person => Console.WriteLine($"{person.Key}");
            case "age":
                return person => Console.WriteLine($"{person.Value}");
            case "name age":
                return person =>
                    Console.WriteLine($"{person.Key} - {person.Value}");
            default:
                return null;
        }

    }
}
