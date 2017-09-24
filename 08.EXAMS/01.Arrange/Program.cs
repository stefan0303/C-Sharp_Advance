using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<int, string> numWord =
            new Dictionary<int, string>
            {
                    {1, "one"},
                    {2, "two"},
                    {3, "three"},
                    {4, "four"},
                    {5, "five"},
                    {6, "six"},
                    {7, "seven"},
                    {8, "eight"},
                    {9, "nine"},
                    {0, "zero"}
            };

        SortedDictionary<string, string> nameNumber = new SortedDictionary<string, string>();

        string[] input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        foreach (var num in input)
        {
            char[] word = num.ToCharArray();
            string finalWord = "";
            foreach (var w in word)
            {
                finalWord += numWord.FirstOrDefault(n => n.Key.ToString() == w.ToString()).Value;

            }
            nameNumber.Add(finalWord, num);
        }

        Console.Write(string.Join(", ", nameNumber.Values));
    }
}

