using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
      
            Queue<string> calculate = new Queue<string>();
            for (int i = 0; i < input.Length; i++)
            {              
                    calculate.Enqueue(input[i]);
                               
            }
            string operation;
            int sum = Convert.ToInt32(calculate.Dequeue());
            int lenght = calculate.Count;
            for (int i = 0; i <lenght-1; i++)
            {
                
                if (calculate.Peek()=="+")
                {
                    calculate.Dequeue();
                    sum += Convert.ToInt32(calculate.Dequeue()) ;
                }
                else if ((calculate.Peek() == "-"))
                {
                    calculate.Dequeue();
                    sum -= Convert.ToInt32(calculate.Dequeue());
                }
                if (calculate.Count==0)
                {
                    break;
                }
                
            }
            Console.WriteLine(sum);
            Console.WriteLine();
        }
    }
}
