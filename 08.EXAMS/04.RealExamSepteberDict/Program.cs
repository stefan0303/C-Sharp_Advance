using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        long bagCapacity = long.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        long allGold = 0;
        long allGem = 0;
        long allCash = 0;

        long currentBagAmount = 0;

        Dictionary<string, long> goldAmount = new Dictionary<string, long>();
        Dictionary<string, long> gemAmount = new Dictionary<string, long>();
        Dictionary<string, long> cashAmount = new Dictionary<string, long>();
        for (long i = 0; i < input.Length; i += 2)
        {

            string name = input[i];
            long quatity = long.Parse(input[i + 1]);
            currentBagAmount += quatity;

            if (name == "Gold" && goldAmount.Values.Sum() < bagCapacity)
            {
                if (!goldAmount.ContainsKey("Gold"))
                {
                    goldAmount.Add(name, quatity);
                    allGold += quatity;
                }
                else
                {
                    goldAmount[name] += quatity;
                    allGold += quatity;
                }
            }
            //change
            if ((name.ToLower().EndsWith("gem") || name.EndsWith("gem")) && gemAmount.Values.Sum() < bagCapacity)//Gem
            {
                if (allGem + quatity < allGold && allGem + quatity > allCash)//check gold is more then gem
                {

                    if (!gemAmount.ContainsKey(name))//there is no such key
                    {
                        allGem += quatity;
                        gemAmount.Add(name, quatity);
                    }
                    else
                    {
                        allGem += quatity;
                        gemAmount[name] += quatity;
                    }
                }

            }
            if (name.Length == 3 && cashAmount.Values.Sum() < bagCapacity)//Cash Amount
            {
                //gem amount more then cash amount
                if (allCash + quatity <= allGem)
                {
                    if (!cashAmount.ContainsKey(name))
                    {
                        allCash += quatity;
                        cashAmount.Add(name, quatity);
                    }
                    else
                    {
                        allCash += quatity;
                        cashAmount[name] += quatity;
                    }
                }
            }
        }
        if (goldAmount.Keys.Count > 0)
        {
            Prlong(goldAmount, "Gold");
        }
        if (gemAmount.Keys.Count > 0)
        {
            Prlong(gemAmount, "Gem");
        }
        if (cashAmount.Keys.Count > 0)
        {
            Prlong(cashAmount, "Cash");
        }
    }

    public static void Prlong(Dictionary<string, long> prlongDict, string name)
    {
        if (prlongDict.Values.Count > 0)//the dict is not empty
        {
            Console.WriteLine("<" + name + "> $" + prlongDict.Values.Sum());

            foreach (var item in prlongDict.OrderByDescending(k => k.Key).ThenBy(v => v.Value))
            {
                Console.WriteLine("##" + item.Key + " - " + item.Value);
            }
        }
    }
}

