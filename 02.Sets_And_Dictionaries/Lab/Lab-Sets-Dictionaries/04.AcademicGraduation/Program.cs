using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        SortedDictionary<string, List<decimal>> nameScore = new SortedDictionary<string, List<decimal>>();

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            var score = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();
            nameScore.Add(name, new List<decimal>());
            for (int j = 0; j < score.Count; j++)
            {
                nameScore[name].Add(score[j]);
            }
        }

        foreach (var na in nameScore)
        {
            decimal averageScore = 0;
            Console.Write(na.Key);
            foreach (var scores in na.Value)
            {
                averageScore += scores;
            }
            Console.Write(" is graduated with " + averageScore / na.Value.Count);
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

