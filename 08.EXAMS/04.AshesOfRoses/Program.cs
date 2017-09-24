using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        //•	Grow <{regionName}> <{colorName}> {roseAmount} 
        //regionName - start with Capital letter and consists only of lowercase letters
        // colorName - must consist only of English alphabet letters and digits. 
        //roseAmount - must be an integer.

        Regex regex = new Regex(@"\b^Grow <([A-Z][a-z]*)> <([a-zA-Z\d]+)> (\d+)$");
        Dictionary<string, Dictionary<string, decimal>> regionColorAmount = new Dictionary<string, Dictionary<string, decimal>>();
        string inputString = Console.ReadLine();
        string[] input = inputString.Split(' ').ToArray();
        while (inputString != "Icarus, Ignite!")
        {

            if (regex.IsMatch(inputString))
            {
                string region = input[1].Substring(1, input[1].Length - 2);
                string colorName = input[2].Substring(1, input[2].Length - 2);
                string roseAmount = input[3];
                //validate input
                int amount = Convert.ToInt32(roseAmount);
                if (!regionColorAmount.ContainsKey(region))
                {
                    regionColorAmount.Add(region, new Dictionary<string, decimal>());
                    regionColorAmount[region].Add(colorName, amount);
                }
                else
                {
                    if (!regionColorAmount[region].ContainsKey(colorName))
                    {
                        regionColorAmount[region].Add(colorName, amount);
                    }
                    else
                    {
                        regionColorAmount[region][colorName] += amount;
                    }
                }
            }

            inputString = Console.ReadLine();
            input = inputString.Split(' ').ToArray();
        }
        var order = regionColorAmount.OrderByDescending(v => v.Value.Values.Sum()).ThenBy(k => k.Key);
        foreach (var region in order)
        {
            Console.WriteLine(region.Key);
            foreach (var amount in region.Value.OrderBy(v => v.Value).ThenBy(k => k.Key))
            {
                Console.WriteLine("*--" + amount.Key + " | " + amount.Value);
            }
        }
    }
}
