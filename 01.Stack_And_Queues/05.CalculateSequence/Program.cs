using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        Queue<long> numbers = new Queue<long>();
        numbers.Enqueue(n);
        List<long> results = new List<long>();
        results.Add(n);

        for (long i = 1; i < 50; i++)
        {
            var currentNumber = numbers.Dequeue();

            long firstNumber = currentNumber + 1;
            long secondNumber = (2 * currentNumber) + 1;
            long thirdNumber = currentNumber + 2;

            numbers.Enqueue(firstNumber);
            numbers.Enqueue(secondNumber);
            numbers.Enqueue(thirdNumber);


            results.Add(firstNumber);
            results.Add(secondNumber);
            results.Add(thirdNumber);

        }

        for (int i = 0; i < 50; i++)
        {
            Console.Write(results[i] + " ");
        }
    }
}

