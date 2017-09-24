using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Stack<int> numbers = new Stack<int>();
        Stack<int> results = new Stack<int>();

        int maxElementh = 0;
        for (int i = 0; i < n; i++)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (input[0] == 2) //Remove
            {
                if (results.Peek() == numbers.Peek() && results.Count > 0)
                {

                    results.Pop();
                    if (results.Count > 0)
                    {
                        maxElementh = results.Peek();
                    }
                    else
                    {
                        maxElementh = int.MinValue;
                    }
                }
                numbers.Pop();
            }
            else if (input[0] == 1) //Add
            {
                if (maxElementh <= input[1])
                {
                    maxElementh = input[1];
                    results.Push(maxElementh);

                }
                numbers.Push(input[1]);
            }

            else     //See max elementh
            {
                Console.WriteLine(results.Peek());

            }
        }


    }
}

