using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[][] matrix = new int[n][];

        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        int primaryDiagonal = 0;
        int secondaryDiagonal = 0;

        for (int i = 0; i < n; i++)
        {
            primaryDiagonal += (matrix[i][i]);
        }

        for (int i = 0; i < n; i++)
        {
            secondaryDiagonal += (matrix[i][matrix[i].Length - 1 - i]);
        }
        Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
    }
}
