using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {

        string input = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        string pattern = @"(^\d+)([a-zA-Z]+)([^a-zA-Z]*$)";

        while (input != "Over!")
        {
            Regex regex = new Regex(pattern);
            var match = regex.Match(input);
            string lastPartOfInput = input.Substring(match.Groups[1].Length + match.Groups[2].Length, input.Length - match.Groups[1].Length - match.Groups[2].Length);
            bool result = true;
            foreach (var c in lastPartOfInput)
            {
                if (char.IsLetter(c))
                {
                    result = false;
                }
            }

            if (match.Groups[2].Length == n && regex.IsMatch(match.Groups[2].Value) && regex.IsMatch(match.Groups[1].Value) && result == true)
            {
                string firstPartNums = match.Groups[1].Value;
                string allNums = firstPartNums + lastPartOfInput;
                string text = match.Groups[2].Value;
                Console.Write(text + " == ");
                List<int> indexes = new List<int>();//Covert string with integers like 43255132 to list with single integer

                for (int i = 0; i < allNums.Length; i++)
                {
                    int currentIndex;
                    bool isNumber = int.TryParse(allNums[i].ToString(), out currentIndex);//check is it num
                    if (isNumber)
                    {
                        indexes.Add(currentIndex);
                    }
                }
                StringBuilder results = new StringBuilder();

                foreach (int index in indexes)
                {
                    if (index < text.Length && index >= 0)
                    {
                        Console.Write(results.Append(text[index]));

                    }
                    else
                    {
                        Console.Write(results.Append(" "));

                    }
                }

            }
            input = Console.ReadLine();
            n = int.Parse(Console.ReadLine());

        }

    }
}












