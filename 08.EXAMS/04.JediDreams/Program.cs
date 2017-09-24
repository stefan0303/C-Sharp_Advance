using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, List<string>> methodNameInvokedMethods = new Dictionary<string, List<string>>();
        string currentMethod = "";
        for (int i = 0; i < n; i++)
        {
            string[] inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int j = 0; j < inputLine.Length; j++)
            {
                string[] specialLine = inputLine[j].Split('(').ToArray();
                if (methodNameInvokedMethods.ContainsKey(specialLine[0]))
                {
                    methodNameInvokedMethods[currentMethod].Add(specialLine[0]);
                }
            }
            if (inputLine.Contains("static"))
            {
                if (inputLine[2].Any(char.IsUpper))
                {
                    string key = inputLine[2].Substring(0, inputLine[2].IndexOf('('));
                    methodNameInvokedMethods.Add(key, new List<string>());
                    currentMethod = key; //we now the current method key
                }
            }

            for (int j = 0; j < inputLine.Length; j++)
            {
                if (inputLine[j].Contains('.'))
                {
                    string[] changeLine = inputLine[j].Split('.');
                    for (int k = 0; k < changeLine.Length; k++)
                    {
                        if (changeLine[k].Contains('('))
                        {                           
                            string involkedMethod = changeLine[k].Substring(0, changeLine[k].IndexOf('('));
                            methodNameInvokedMethods[currentMethod].Add(involkedMethod);
                        }
                    }
                }
            }
        }

        foreach (var key in methodNameInvokedMethods.OrderByDescending(v => v.Value.Count).ThenBy(k => k.Key))
        {
            Console.WriteLine(key.Key + " -> " + key.Value.Count + " -> " + string.Join(", ", key.Value.OrderBy(v => v)));

        }
    }
}

