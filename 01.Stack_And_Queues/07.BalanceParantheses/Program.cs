using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < input.Length; i++)
        {
            char parenthese = input[i];
            switch (parenthese)
            {
                case '{':
                    stack.Push('{');
                    break;
                case '(':
                    stack.Push('(');
                    break;
                case '[':
                    stack.Push('[');
                    break;
            }
            if (stack.Count > 0)
            {
                char current = stack.Pop();
                if (current == '{')
                {
                    Console.WriteLine("No");
                    break;
                }
                if (current == '(')
                {
                    Console.WriteLine("No");
                    break;
                }
                if (current == '[')
                {
                    Console.WriteLine("No");
                    break;
                }

            }

        }
        Console.WriteLine("Yes");
    }
}

