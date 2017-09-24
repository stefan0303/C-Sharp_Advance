using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> brackets =new Stack<int>();
            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                     
                    brackets.Push(i);
                }
                else if (input[i] == ')')
                {
                    
                  var startIndex=  brackets.Pop();
                    string print = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(print);
                }
           
            }
        }
    }
}
