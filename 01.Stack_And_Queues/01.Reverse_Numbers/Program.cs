using System;
using System.Collections.Generic;
using System.Linq;

class Stack
{
    static void Main()
    {
        int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Stack<int> numbers = new Stack<int>();
        for (int i = 0; i < num.Length; i++)
        {
            numbers.Push(num[i]);
        }

        for (int i = 0; i < num.Length; i++)
        {
            Console.Write(numbers.Pop() + " ");
        }
    }

}

