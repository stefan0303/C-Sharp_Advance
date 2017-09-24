using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        List<string> names = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        string[] command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        while (command[0] != "Party!")
        {
            switch (command[0])
            {
                case "Remove":
                    if (command[1] == "StartsWith")
                    {
                        var remove = names.Where(n => n.StartsWith(command[2])).ToList();
                        foreach (var name in remove)
                        {
                            names.Remove(name);
                        }
                    }
                    if (command[1] == "Lenght")
                    {
                        var makeDoubleNames = names.Where(n => n.Length == Convert.ToInt32(command[2])).ToList();
                        foreach (var name in makeDoubleNames)
                        {
                            names.Remove(name);
                        }
                    }
                    else
                    {
                        var remove = names.Where(n => n.EndsWith(command[2])).ToList();
                        foreach (var name in remove)
                        {
                            names.Remove(name);
                        }
                    }
                    break;
                case "Double":
                    if (command[1] == "StartsWith")
                    {
                        var makeDoubleNames = names.Where(n => n.StartsWith(command[2])).ToList();
                        foreach (var name in makeDoubleNames)
                        {
                            names.Add(name);
                        }
                    }
                    if (command[1] == "Length")
                    {
                        var makeDoubleNames = names.Where(n => n.Length == Convert.ToInt32(command[2])).ToList();
                        foreach (var name in makeDoubleNames)
                        {
                            names.Add(name);
                        }
                    }
                    if (command[1] == "EndsWith")
                    {
                        var makeDoubleNames = names.Where(n => n.EndsWith(command[2])).ToList();
                        foreach (var name in makeDoubleNames)
                        {
                            names.Add(name);
                        }
                    }
                    break;
            }

            command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }

        var sortedNames = names.OrderBy(n => n).ToList();
        if (sortedNames.Count == 0)
        {
            Console.WriteLine("Nobody is going to the party!");

        }
        else
        {
            Console.WriteLine(string.Join(", ", sortedNames) + " are going to the party!");
        }

    }
}

