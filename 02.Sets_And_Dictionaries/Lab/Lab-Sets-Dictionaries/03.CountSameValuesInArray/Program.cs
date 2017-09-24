using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        SortedDictionary<double, int> dict = new SortedDictionary<double, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], 1);
            }
            else
            {
                dict[nums[i]] += 1;
            }
        }

        foreach (var item in dict)
        {
            Console.WriteLine(item.Key + " - " + item.Value + " times");
        }
    }
}

