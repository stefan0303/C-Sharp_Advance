using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string allLines = "";
        while (input != "//END_OF_CODE")
        {
            allLines += input;
            input = Console.ReadLine();
        }
        string[] splitText = allLines.Split(' ', ';', '=', '+', '-', '!', '(', ')').ToArray();
        List<string> doubles = new List<string>();
        List<string> ints = new List<string>();

        for (int i = 0; i < splitText.Length; i++)
        {
            if (splitText[i] == "double" && i + 1 < splitText.Length)
            {

                doubles.Add(splitText[i + 1]);

            }
            else if (splitText[i] == "int" && i + 1 < splitText.Length)
            {

                ints.Add(splitText[i + 1]);

            }

        }

        doubles.Sort();
        ints.Sort();
        doubles.Remove("");
        ints = ints.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
        doubles = doubles.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
        if (doubles.Count == 0)
        {
            Console.WriteLine("Doubles: None");
        }
        else
        {
            Console.WriteLine("Doubles: " + String.Join(", ", doubles));
        }
        if (ints.Count == 0)
        {
            Console.WriteLine("Ints: None");
        }
        else
        {
            Console.WriteLine("Ints: " + String.Join(", ", ints));
        }

    }
}

