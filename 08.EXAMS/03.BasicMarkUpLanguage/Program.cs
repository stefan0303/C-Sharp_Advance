using System;
using System.Linq;

class Program
{

    static void Main()
    {
        string input = Console.ReadLine().Trim();
        var sentence = input.Split(new[] { '=', '"' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        int count = 1;
        while (sentence[0] != "<stop/>")
        {
            switch (sentence[0])
            {
                case "<inverse content":
                    if (sentence[1].Length == 0)
                    {
                        break;
                    }
                    if (sentence[1] == "/>")
                    {
                        Console.Write("{0}.", count);
                        break;
                    }
                    Console.Write("{0}. ", count);

                    foreach (var c in sentence[1])
                    {
                        if (char.IsLower(c))
                        {
                            Console.Write(char.ToUpper(c));
                        }
                        else
                        {
                            Console.Write(char.ToLower(c));
                        }

                    }
                    Console.WriteLine();
                    break;
                case "<reverse content":
                    Console.Write("{0}. ", count);
                    char[] charArray = sentence[1].ToCharArray();
                    if (charArray.Length == 0)
                    {
                        break;
                    }
                    for (int i = charArray.Length - 1; i >= 0; i--)
                    {
                        Console.Write(charArray[i]);
                    }
                    Console.WriteLine();
                    break;
                case "<repeat value":

                    int numberOfRepeat = Convert.ToInt32(sentence[1]);
                    if (sentence[3].Length == 0 || numberOfRepeat == 0)
                    {
                        break;
                    }
                    for (int i = 0; i < numberOfRepeat; i++)
                    {
                        Console.WriteLine("{0}. {1}", count, sentence[3]);
                        count++;
                    }
                    count -= 1;
                    break;

            }
            count++;
            input = Console.ReadLine().Trim();

            sentence = input.Split(new[] { '=', '"' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
    }

}


