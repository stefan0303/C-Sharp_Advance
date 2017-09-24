using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();
        List<string> results = new List<string>();
        string input = Console.ReadLine();
        while (input != "stop")
        {
            if (input == "search")
            {
                while (input != "stop")
                {
                    string search = Console.ReadLine();
                    if (search == "stop")
                    {
                        input = "stop";
                        break;
                    }
                    if (phoneNumbers.ContainsKey(search))
                    {
                        results.Add(search + " -> " + phoneNumbers[search]);
                        
                    }
                    else
                    {
                        results.Add("Contact " + search + " does not exist.");
                      
                    }

                }
            }
            else if (!phoneNumbers.ContainsKey(input) && input != "search" && input != "stop")
            {
                string[] namePhone = input.Split('-');
                if (phoneNumbers.ContainsKey(namePhone[0]))
                {
                    phoneNumbers[namePhone[0]] = namePhone[1];
                }
                else
                {
                    phoneNumbers.Add(namePhone[0], namePhone[1]);
                }

            }
            if (input == "stop")
            {
                break;
            }

            input = Console.ReadLine();

        }
        for (int i = 0; i < results.Count; i++)
        {
            Console.WriteLine(results[i]);
        }
    }
}

