using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        SortedDictionary<string, List<int>> nameNumber = new SortedDictionary<string, List<int>>();

        for (int i = 0; i < input.Length; i++)
        {
            string currentNum = Convert.ToString(input[i]);
            if (currentNum.Length > 1)
            {
                char[] charArray = currentNum.ToCharArray();
                string forKey = "";
                foreach (var c in charArray)
                {
                    int number = (int)Char.GetNumericValue(c);
                    forKey += NumberToWords(number) + "-";
                }
                forKey = forKey.Substring(0, forKey.Length - 1);
                if (!nameNumber.ContainsKey(forKey))//check duplicate numbers
                {
                    nameNumber.Add(forKey, new List<int>());
                    nameNumber[forKey].Add(input[i]);
                }
                else
                {
                    nameNumber[forKey].Add(input[i]);
                }

            }
            else
            {
                string numInWord = NumberToWords(input[i]);
                if (!nameNumber.ContainsKey(numInWord))//check duplicate numbers
                {
                    nameNumber.Add(numInWord, new List<int>());
                    nameNumber[numInWord].Add(input[i]);
                }
                else
                {
                    nameNumber[numInWord].Add(input[i]);
                }
            }

        }

        string print = "";
        foreach (var n in nameNumber)
        {
            foreach (var num in n.Value)
            {
                print += num + ", ";

            }

        }
        print = print.Substring(0, print.Length - 2);
        Console.WriteLine(print);

    }
    public static string NumberToWords(int number)
    {
        if (number == 0)
            return "zero";

        if (number < 0)
            return "minus " + NumberToWords(Math.Abs(number));

        string words = "";

        if ((number / 1000000) > 0)
        {
            words += NumberToWords(number / 1000000) + " million ";
            number %= 1000000;
        }

        if ((number / 1000) > 0)
        {
            words += NumberToWords(number / 1000) + " thousand ";
            number %= 1000;
        }

        if ((number / 100) > 0)
        {
            words += NumberToWords(number / 100) + " hundred ";
            number %= 100;
        }

        if (number > 0)
        {
            if (words != "")
                words += "and ";

            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += "-" + unitsMap[number % 10];
            }
        }

        return words;
    }
}

