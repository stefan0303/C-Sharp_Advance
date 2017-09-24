using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] colRow = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = colRow[1];
        int col = colRow[0];

        string[,] matrix = new string[col, rows];
        for (int i = 0; i < col; i++) //Read the matrix
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int j = 0; j < rows; j++)
            {

                matrix[i, j] = input[j];
            }

        }
        int count = 0;
        for (int i = 0; i < col; i++) //Read the matrix
        {

            for (int j = 0; j < rows; j++)
            {
                if (i + 1 < col && j + 1 < rows)
                {
                    if (matrix[i, j] == matrix[i, j + 1] && matrix[i + 1, j] == matrix[i + 1, j + 1] && matrix[i, j] == matrix[i + 1, j])
                    {
                        count += 1;
                    }

                }

            }
        }

        Console.WriteLine(count);
    }
}

