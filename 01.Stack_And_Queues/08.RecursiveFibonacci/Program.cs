using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(recursiveFibonacci(n));

    }
    private static long recursiveFibonacci(int n)
    {
        if (n <= 2)
        {
            return 1;
        }
        return recursiveFibonacci(n - 1) + recursiveFibonacci(n - 2);
    }
}


