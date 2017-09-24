using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    //#([A-Z][a-z]*):\s?@([A-Z][a-z]*)\s?([0-9]{2}):([0-9]{2})
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        SortedDictionary<string, SortedDictionary<string, List<DateTime>>> location_Person_time = new SortedDictionary<string, SortedDictionary<string, List<DateTime>>>();
        string person = "";
        string location = "";

        string pattern = "^#([A-Za-z]*):\\s*?@([A-Za-z]*)\\s*?([0-9]{2}):([0-9]{2})$  ";
        Regex regex = new Regex(pattern);

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            var match = regex.Match(input);
            if (regex.IsMatch(match.Groups[0].Value))
            {
                person = match.Groups[1].Value;
                location = match.Groups[2].Value;

                int hour = Convert.ToInt32(match.Groups[3].Value);
                if (hour < 0 || hour > 23)//check valid hours
                {
                    continue;
                }

                int minutes = Convert.ToInt32(match.Groups[4].Value);
                if (minutes < 0 || minutes > 59)//check valid minutes
                {
                    continue;
                }
                DateTime time = DateTime.MinValue;
                TimeSpan ts = new TimeSpan(hour, minutes, 0);
                time = time.Date + ts;
                if (!location_Person_time.ContainsKey(location))
                {
                    location_Person_time.Add(location, new SortedDictionary<string, List<DateTime>>());

                    location_Person_time[location].Add(person, new List<DateTime>());

                    location_Person_time[location][person].Add(time);

                }
                else
                {
                    if (!location_Person_time[location].ContainsKey(person))
                    {
                        location_Person_time[location].Add(person, new List<DateTime>());
                        location_Person_time[location][person].Add(time);
                    }
                    else
                    {
                        location_Person_time[location][person].Add(time);
                    }
                }
            }
        }
        string[] outputTowns = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        Array.Sort(outputTowns, StringComparer.InvariantCulture);

        for (int i = 0; i < outputTowns.Length; i++)
        {
            string town = outputTowns[i];
            if (location_Person_time.ContainsKey(town))
            {
                Console.WriteLine(town + ":");
                int count = 1;

                foreach (var p in location_Person_time[town])
                {
                    Console.Write(count + ". " + p.Key + " -> ");
                    count++;
                    var numberOfHours = p.Value.Count;
                    foreach (var hour in p.Value.OrderBy(t => t))
                    {
                        numberOfHours -= 1;
                        if (numberOfHours == 0)
                        {
                            Console.Write(hour.ToString("HH:mm"));
                        }
                        else
                        {
                            Console.Write(hour.ToString("HH:mm") + ", ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

