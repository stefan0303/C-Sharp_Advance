using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] range = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        int count = 1;

        for (int i = 0; i < range[0]; i++)
        {
            Console.Write(new String(alphabet[i], 3) + " ");

            for (int j = 0; j < range[1] - 1; j++)
            {
                Console.Write(new String(alphabet[i], 1) + new String(alphabet[j + count], 1) + new String(alphabet[i], 1) + " ");
            }
            count++;

            Console.WriteLine();
        }
    }
}

