using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.intToBinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Stack<int> binaryConvert=new Stack<int>();
            if (num==0)
            {
                Console.WriteLine("0");
            }
            else
            {
                while (num>0)
                {
                    binaryConvert.Push(num % 2);
                    num = num / 2;
                    
                }
            }
            while (binaryConvert.Count>0)
            {
                Console.Write(binaryConvert.Pop());
            }
                
               
               
            
            Console.WriteLine();
        }
    }
}
