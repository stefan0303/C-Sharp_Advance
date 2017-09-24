using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = input[0];
        int col = input[1];
        int sum = 0;
        int[,] matrix = new int[rows, col];

        for (int i = 0; i < rows; i++)
        {
            var line = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (var j = 0; j < col; j++)
            {
                matrix[i, j] = line[j];
                sum += matrix[i, j];
            }
        }

        Console.WriteLine(rows);
        Console.WriteLine(col);
        Console.WriteLine(sum);
    }
}

