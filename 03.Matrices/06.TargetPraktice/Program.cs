using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rows = input[0];
        int cols = input[1];
        int[][] matrix = new int[rows][];
        for (int row = 0; row < rows; row++)
        {
            matrix[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
        int[] inputTarget = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int r = inputTarget[0];
        int c = inputTarget[1];
        int value = matrix[r][c];

        matrix[r][c] = matrix[r][c] * (matrix[r - 1][c - 1] + matrix[r - 1][c] + matrix[r - 1][c + 1] + matrix[r][c - 1] + matrix[r][c + 1] + matrix[r + 1][c - 1] + matrix[r + 1][c] + matrix[r + 1][c + 1]);
        matrix[r - 1][c - 1] = value * matrix[r - 1][c - 1];
        matrix[r - 1][c] = value * matrix[r - 1][c];
        matrix[r - 1][c + 1] = value * matrix[r - 1][c + 1];
        matrix[r][c - 1] = value * matrix[r][c - 1];
        matrix[r][c + 1] = value * matrix[r][c + 1];
        matrix[r + 1][c - 1] = value * matrix[r + 1][c - 1];
        matrix[r + 1][c] = value * matrix[r + 1][c];
        matrix[r + 1][c + 1] = value * matrix[r + 1][c + 1];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(matrix[row][col] + " ");
            }
            Console.WriteLine();
        }
    }
}

