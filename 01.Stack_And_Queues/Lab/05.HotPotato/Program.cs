using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(Console.ReadLine());

            Queue<string> kids = new Queue<string>();
            for (int i = 0; i < input.Length; i++)
            {
                kids.Enqueue(input[i]); //vkarvame vuv opashkata
            }
            
            int cycle = 1;
            while (kids.Count > 1) //broim za da ostane edin element v opashkata
            {
                for (int i = 0; i < n - 1; i++) //cikul do n
                {
                    string reminder = kids.Dequeue(); //vadim purvia elemen ot opashkata
                    kids.Enqueue(reminder); //vkarvame go na posledno misto v opashkata

                }
                if (PrimeTool.IsPrime(cycle))
                {
                    Console.WriteLine($"Prime {kids.Peek()}");
                }
                else
                {
                    Console.WriteLine("Removed " + kids.Dequeue());
                }
                cycle++;
                
            }
            Console.WriteLine("Last is " + kids.Dequeue());

        }
        
        
    }
    public static class PrimeTool
    {
        public static bool IsPrime(int candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // Note:
            // ... This version was changed to test the square.
            // ... Original version tested against the square root.
            // ... Also we exclude 1 at the end.
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }
}


