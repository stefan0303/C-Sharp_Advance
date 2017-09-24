using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Dictionary<string, string> nameEmail = new Dictionary<string, string>();
        string command = "";

        while (command != "stop")
        {
            command = Console.ReadLine().Trim();
            if (command == "stop")
            {
                break;
            }
            nameEmail.Add(command, "");

            string email = Console.ReadLine().Trim();
            string[] check = email.Split('.');
            if (check[1] == "us" || check[1] == "uk")
            {
                nameEmail.Remove(command);
            }
            else
            {
                nameEmail[command] = email;
            }
        }

        Console.WriteLine();
        foreach (var item in nameEmail)
        {
            Console.WriteLine(item.Key + " -> " + item.Value);
        }
    }
}


