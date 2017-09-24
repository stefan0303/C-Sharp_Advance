using System;
using System.Collections.Generic;
using System.Linq;

class Program
{   //Note that if at one region 1 000 000 Green Meteors gather, they combine longo 1 Red Meteor.
    //By the same logic, 1 000 000 Red Meteors get combined longo 1 Black Meteor
    //green 1m => 1 red     red 1m=> 1 black
    static void Main()
    {

        string[] input = Console.ReadLine().Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        Dictionary<string, SortedDictionary<string, long>> regionMeteorsNum = new Dictionary<string, SortedDictionary<string, long>>();

        while (input[0] != "Count em all")
        {
            string region = input[0].Trim();
            string meteor = input[1].Trim();
            long numMeteors = long.Parse(input[2].Trim());

            if (!regionMeteorsNum.ContainsKey(region))
            {
                regionMeteorsNum.Add(region, new SortedDictionary<string, long>());
                regionMeteorsNum[region].Add("Black", 0);//add all meteors
                regionMeteorsNum[region].Add("Red", 0);
                regionMeteorsNum[region].Add("Green", 0);

                regionMeteorsNum[region][meteor] += numMeteors; //make meteor with new value
                if (regionMeteorsNum[region][meteor] >= 1000000 && meteor == "Green")
                {
                    regionMeteorsNum[region]["Red"] += regionMeteorsNum[region]["Green"] / 1000000;
                    regionMeteorsNum[region]["Green"] = regionMeteorsNum[region]["Green"] % 1000000;
                }
                if (regionMeteorsNum[region]["Red"] >= 1000000)
                {
                    regionMeteorsNum[region]["Black"] += regionMeteorsNum[region]["Red"] / 1000000;
                    regionMeteorsNum[region]["Red"] = regionMeteorsNum[region]["Red"] % 1000000;
                }
            }
            else
            {
                regionMeteorsNum[region][meteor] += numMeteors;
                if (regionMeteorsNum[region][meteor] >= 1000000 && meteor == "Green")
                {
                    regionMeteorsNum[region]["Red"] += regionMeteorsNum[region]["Green"] / 1000000;
                    regionMeteorsNum[region]["Green"] = regionMeteorsNum[region]["Green"] % 1000000;
                }
                if (regionMeteorsNum[region]["Red"] >= 1000000)
                {
                    regionMeteorsNum[region]["Black"] += regionMeteorsNum[region]["Red"] / 1000000;
                    regionMeteorsNum[region]["Red"] = regionMeteorsNum[region]["Red"] % 1000000;
                }
            }

            input = Console.ReadLine().Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
        var orderRegions =
            regionMeteorsNum.OrderByDescending(r => r.Value.Values.First()).ThenBy(r => r.Key.Length).ThenBy(r => r.Key).ToList();
        foreach (var region in orderRegions)
        {
            Console.WriteLine(region.Key);
            foreach (var meteor in region.Value.OrderByDescending(m => m.Value).ThenBy(m => m.Key))
            {
                Console.WriteLine("-> " + meteor.Key + " : " + meteor.Value);
            }
        }
    }
}

