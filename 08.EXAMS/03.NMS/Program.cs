using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<string> words = new List<string>();

        List<char> chars = new List<char>();
        string word = "";

        while (input != "---NMS SEND---")
        {
            foreach (var c in input)
            {
                chars.Add(c);
            }
            input = Console.ReadLine();
        }

        for (int i = 0; i < chars.Count; i++)
        {
            if (i + 1 < chars.Count && char.ToLower(chars[i]) <= char.ToLower(chars[i + 1]))
            {
                word += chars[i];
            }
            else//check i+1
            {
                word += chars[i];
                if (i + 1 < chars.Count && char.ToLower(chars[i]) <= char.ToLower(chars[i + 1])) //U>t
                {

                }

                else
                {
                    words.Add(word);
                    word = "";
                }
            }
        }
        string split = Console.ReadLine();

        for (int i = 0; i < words.Count; i++)
        {
            if (i < words.Count - 1)
            {
                Console.Write(words[i] + split);
            }
            else
            {
                Console.WriteLine(words[i]);
            }
        }


    }
}

