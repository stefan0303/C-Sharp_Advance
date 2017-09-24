using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //1 8 2 3
    //last 2 odd
    static void Main(string[] args)
    {
        List<int> input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        string[] command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        int maxEven = int.MinValue;
        int maxOdd = int.MinValue;
        int minEven = int.MaxValue;
        int minOdd = int.MaxValue;

        while (command[0] != "end")
        {

            switch (command[0])
            {
                case "exchange"://hardcore!!!
                    int index = Convert.ToInt32(command[1]);
                    if (index >= input.Count)//ist outside of the array
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        int[] arr = input.GetRange(index + 1, input.Count - 1 - index).ToArray();
                        input.InsertRange(0, arr);
                        input.RemoveRange(input.Count - arr.Length, arr.Length);
                    }
                    break;
                case "max":
                    if (command[1] == "even")
                    {
                        int maxEvenIndex = 0;
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] % 2 == 0 && maxEven <= input[i])
                            {
                                maxEven = input[i];
                                maxEvenIndex = i;
                            }
                        }
                        if (maxEven == int.MinValue)
                        {
                            Console.WriteLine("No matches");
                            maxEven = int.MinValue;
                        }
                        else
                        {
                            Console.WriteLine(maxEvenIndex);
                            maxEven = int.MinValue;
                        }
                        break;
                    }
                    if (command[1] == "odd")
                    {
                        int maxOddIndex = 0;
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] % 2 != 0 && maxOdd <= input[i])
                            {
                                maxOdd = input[i];
                                maxOddIndex = i;
                            }
                        }
                        if (maxOdd == int.MinValue)
                        {
                            Console.WriteLine("No matches");
                            maxOdd = int.MinValue;
                        }
                        else
                        {
                            Console.WriteLine(maxOddIndex);
                            maxOdd = int.MinValue;
                        }

                    }
                    break;
                case "min":
                    if (command[1] == "even")
                    {
                        int maxEvenIndex = 0;
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] % 2 == 0 && minEven >= input[i])
                            {
                                minEven = input[i];
                                maxEvenIndex = i;
                            }
                        }
                        if (minEven == int.MaxValue)
                        {
                            Console.WriteLine("No matches");
                            minEven = int.MaxValue;
                        }
                        else
                        {
                            Console.WriteLine(maxEvenIndex);
                            minEven = int.MaxValue;
                        }
                        break;
                    }
                    if (command[1] == "odd")
                    {
                        int maxEvenIndex = 0;
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] % 2 != 0 && minEven >= input[i])
                            {
                                minEven = input[i];
                                maxEvenIndex = i;
                            }
                        }
                        if (minEven == int.MinValue)
                        {
                            Console.WriteLine("No matches");
                            minEven = int.MaxValue;
                        }
                        else
                        {
                            Console.WriteLine(maxEvenIndex);
                            minEven = int.MaxValue;
                        }

                    }
                    break;
                case "first":
                    int count = Convert.ToInt32(command[1]);

                    if (count > input.Count)
                    {
                        Console.WriteLine("Invalid count");
                        break;
                    }
                    if (command[2] == "odd")
                    {

                        Console.Write("[");
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (count == 0)
                            {
                                break;
                            }
                            if (input[i] % 2 != 0)
                            {

                                count--;
                                if (count == 0)
                                {

                                    Console.Write(input[i]);
                                }
                                else
                                {
                                    Console.Write(input[i] + ", ");

                                }
                            }
                        }
                        Console.Write("]");
                        Console.WriteLine();
                    }
                    if (command[2] == "even")
                    {
                        if (count > input.Count)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }
                        Console.Write("[");
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (count == 0)
                            {
                                break;
                            }
                            if (input[i] % 2 == 0)
                            {
                                Console.Write(input[i]);
                                count--;
                                if (count != 0)
                                {
                                    Console.Write(", ");
                                }
                            }
                        }
                        Console.Write("]");
                        Console.WriteLine();
                    }
                    break;
                case "last":
                    int countLast = Convert.ToInt32(command[1]);
                    if (countLast > input.Count)
                    {
                        Console.WriteLine("Invalid count");
                        break;
                    }
                    if (command[2] == "odd")
                    {

                        Console.Write("[");
                        for (int i = input.Count - 1; i >= 0; i--)
                        {
                            if (countLast == 0)
                            {
                                break;
                            }
                            if (input[i] % 2 != 0)
                            {
                                Console.Write(input[i]);
                                countLast--;
                                if (i != 0)
                                {
                                    Console.Write(", ");
                                }

                            }
                        }
                        Console.Write("]");
                        Console.WriteLine();
                    }
                    if (command[2] == "even")
                    {
                        Console.Write("[");
                        for (int i = input.Count - 1; i >= 0; i--)
                        {
                            if (countLast == 0)
                            {
                                break;
                            }
                            if (input[i] % 2 == 0)
                            {
                                Console.Write(input[i]);
                                countLast--;
                                if (countLast != 0)
                                {
                                    Console.Write(", ");
                                }
                            }
                        }
                        Console.Write("]");
                        Console.WriteLine();
                    }
                    break;
            }
            command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
        Console.Write("[");
        for (int i = 0; i < input.Count; i++)
        {
            if (i == input.Count - 1)
            {
                Console.Write(input[i]);
            }
            else
            {
                Console.Write(input[i] + ", ");
            }

        }
        Console.Write("]");
    }
}

