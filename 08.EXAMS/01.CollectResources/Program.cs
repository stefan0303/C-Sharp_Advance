using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> name_quantity = new List<string>();
        string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == "stone" || input[i] == "gold" || input[i] == "wood" || input[i] == "food")//if input i is only one word
            {
                name_quantity.Add(input[i] + "_1");

            }
            else if (input[i].Any(char.IsDigit))//check is there digit
            {

                name_quantity.Add(input[i]);

            }
        }
        int n = int.Parse(Console.ReadLine());
        int startIndex;
        int step;
        int max = 0;
        List<int> indexThatweHaveBeenThere = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int[] inputIndex = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            startIndex = inputIndex[0];
            step = inputIndex[1];
            //  name_quantity[startIndex]
            for (int j = 0; j < name_quantity.Count; j++)
            {
                if (startIndex < name_quantity.Count)
                {
                    string[] nameQuantitySplit = name_quantity[startIndex].Split('_').ToArray();
                    int quantity = int.Parse(nameQuantitySplit[1]);
                    string name = nameQuantitySplit[0];
                    if (indexThatweHaveBeenThere.Contains(startIndex))
                    {
                        break;
                    }
                    if (name == "stone" || name == "gold" || name == "wood" || name == "food")
                    {
                        indexThatweHaveBeenThere.Add(startIndex);//we have been there
                        max += quantity;
                    }

                    startIndex += step;
                    j += step;
                    if (j >= name_quantity.Count)//ist outside of the array
                    {

                        j = name_quantity.Count - j;

                    }
                }
                else                       //ist outside of the array
                {

                    if (j >= name_quantity.Count)
                    {
                        j = name_quantity.Count - j;
                    }
                }
            }
        }
        Console.WriteLine(max);
    }
}

