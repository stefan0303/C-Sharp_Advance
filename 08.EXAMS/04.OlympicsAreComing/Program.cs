using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> countryAthleteWins = new Dictionary<string, Dictionary<string, int>>();
        string[] input = Console.ReadLine().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        List<string> text = new List<string>();

        foreach (var n in input)
        {
            text.Add(Regex.Replace(n, @"\s+", " ").Trim());
        }
        while (text[0] != "report")
        {
            string athlete = text[0];
            string country = text[1];
            if (!countryAthleteWins.ContainsKey(country))
            {
                countryAthleteWins.Add(country, new Dictionary<string, int>());
                countryAthleteWins[country].Add(athlete, 1);
            }
            else//there is country
            {
                if (!countryAthleteWins[country].ContainsKey(athlete))//there is no athlete
                {
                    countryAthleteWins[country].Add(athlete, 1);
                }
                else
                {
                    countryAthleteWins[country][athlete] += 1;
                }
            }

            input = Console.ReadLine().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            text.Clear();
            foreach (var n in input)
            {
                text.Add(Regex.Replace(n, @"\s+", " ").Trim());
            }
        }

        var orderCountries = countryAthleteWins.OrderByDescending(k => k.Value.Values.Sum()).ToList();
        Console.WriteLine();
        foreach (var country in orderCountries)
        {
            int countryParticipants = country.Value.Count;
            int countryWins = country.Value.Values.Sum();
            Console.Write(country.Key + " (" + countryParticipants + " participants): " + countryWins + " wins");
            Console.WriteLine();
        }
    }
}
