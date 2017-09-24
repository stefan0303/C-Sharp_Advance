using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = input[0];
        int col = input[1];
        int[,] matrix = new int[rows, col];

        for (int i = 0; i < rows; i++)
        {
            var line = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (var j = 0; j < col; j++)
            {
                matrix[i, j] = line[j];

            }
        }

        int maxSum = 0;
        int currentSum;
        int first = 0;
        int second = 0;
        int third = 0;
        int fourth = 0;

        for (int i = 0; i < rows; i++)
        {

            for (var j = 0; j < col; j++)
            {
                if (j + 1 < col && i + 1 < rows)
                {
                    currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        first = matrix[i, j];
                        second = matrix[i, j + 1];
                        third = matrix[i + 1, j];
                        fourth = matrix[i + 1, j + 1];
                    }
                }

            }
        }
        Console.WriteLine(first + " " + second);
        Console.WriteLine(third + " " + fourth);
        Console.WriteLine(maxSum);

    }
}

