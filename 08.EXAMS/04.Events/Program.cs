using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        SortedDictionary<string, SortedDictionary<string, List<DateTime>>> locationPersonTime = new SortedDictionary<string, SortedDictionary<string, List<DateTime>>>();
        string person = "";
        string location = "";
        DateTime myTime = default(DateTime);

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '@', '#', ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            person = input[0];
            location = input[1];
            int hour = Convert.ToInt32(input[2]);
            if (hour < 0 || hour > 23)//check valid hours
            {
                break;
            }

            int minutes = Convert.ToInt32(input[3]);
            if (minutes < 0 || minutes > 59)//check valid minutes
            {
                break;
            }
            DateTime time = DateTime.MinValue;
            TimeSpan ts = new TimeSpan(hour, minutes, 0);
            time = time.Date + ts;
            if (!locationPersonTime.ContainsKey(location))
            {
                locationPersonTime.Add(location, new SortedDictionary<string, List<DateTime>>());

                locationPersonTime[location].Add(person, new List<DateTime>());

                locationPersonTime[location][person].Add(time);

            }
            else
            {
                if (!locationPersonTime[location].ContainsKey(person))
                {
                    locationPersonTime[location].Add(person, new List<DateTime>());
                    locationPersonTime[location][person].Add(time);
                }
                else
                {
                    locationPersonTime[location][person].Add(time);
                }
            }
        }

        string[] outputTowns = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        Array.Sort(outputTowns, StringComparer.InvariantCulture);

        for (int i = 0; i < outputTowns.Length; i++)
        {
            string town = outputTowns[i];
            if (locationPersonTime.ContainsKey(town))
            {
                Console.WriteLine(town + ":");
                int count = 1;

                foreach (var p in locationPersonTime[town])
                {
                    Console.Write(count + ". " + p.Key + " -> ");
                    count++;
                    foreach (var hour in p.Value)
                    {
                        Console.Write(hour.ToString("HH:mm"));
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

