using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, long>> countryTowns = new Dictionary<string, Dictionary<string, long>>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "report") { break; }
            string[] inputInarray = input.Split('|').ToArray();
            string town = inputInarray[0];
            string country = inputInarray[1];
            long population = Convert.ToInt64(inputInarray[2]);
            if (!countryTowns.ContainsKey(country))
            {
                countryTowns.Add(country, new Dictionary<string, long>());
                countryTowns[country].Add(town, population);
            }
            else
            {
                countryTowns[country].Add(town, population);
            }
        }

        Console.WriteLine();
        foreach (var item in countryTowns.OrderByDescending(t => t.Value.Values.Sum()))
        {


            Console.WriteLine(item.Key + " (total population: " + item.Value.Values.Sum() + ")");



            foreach (var town in item.Value.OrderByDescending(t => t.Value))
            {
                Console.WriteLine("=>" + town.Key + ": " + town.Value);
            }

        }
    }
}

