using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        SortedDictionary<string, int> keyMaterials = new SortedDictionary<string, int>();
        keyMaterials.Add("shards", 0);
        keyMaterials.Add("fragments", 0);
        keyMaterials.Add("motes", 0);
        SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();

        string[] input = Console.ReadLine().ToLower().Split(' ').ToArray();
        int sumValuesOfKeyMaterials;
        bool outofWhile = true;
        while (true)
        {
            for (int i = 0; i < input.Length; i++)
            {
                string material = input[i + 1];
                int materialValue = Convert.ToInt32(input[i]);

                if (material != "shards" && material != "fragments" && material != "motes") //junk Materials
                {
                    if (!junkMaterials.ContainsKey(material))
                    {
                        junkMaterials.Add(material, materialValue);
                    }
                    else
                    {
                        junkMaterials[material] += materialValue;
                    }
                }
                else if (material == "shards" || material == "fragments" || material == "motes")  //key Materials
                {
                    sumValuesOfKeyMaterials = materialValue;
                    keyMaterials[material] = sumValuesOfKeyMaterials + keyMaterials[material];

                    if (keyMaterials[material] >= 250)
                    {
                        keyMaterials[material] -= 250;
                        switch (material)
                        {
                            case "motes":
                                Console.WriteLine("Dragonwrath obtained!");
                                outofWhile = false;
                                break;
                            case "fragments":

                                Console.WriteLine("Valanyr obtained!");
                                outofWhile = false;
                                break;
                            case "shards":
                                Console.WriteLine("Shadowmourne obtained!");
                                outofWhile = false;
                                break;
                        }
                        if (outofWhile == false) { break; }
                    }
                }

                i = i + 1;
            }
            if (outofWhile == false) { break; }
            input = Console.ReadLine().ToLower().Split(' ').ToArray();
        }

        var sortKeyMatirialsDict = keyMaterials.OrderByDescending(x => x.Value);
        foreach (var item in sortKeyMatirialsDict)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
        foreach (var item in junkMaterials)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}



