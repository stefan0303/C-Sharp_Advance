using System;

class Program
{
    static void Main()
    {
        //Declarations and Initialization
        int subMatrixRows = 3;
        int subMatrixCols = 3;
        int maxSum;
        int startRow;
        int startCol;
        string[] input = Console.ReadLine().Split();
        int rows = int.Parse(input[0]);
        int cols = int.Parse(input[1]);
        int[,] matrix = new int[rows + 1, cols + 1];

        //Methods
        FillMatrix(matrix, rows, cols);
        FindMaximalSum(matrix, subMatrixRows, subMatrixCols, out maxSum, out startRow, out startCol);

        //Printing
        Console.WriteLine();
        Console.WriteLine("Sum = {0}", maxSum);
        PrintSubMatrix(matrix, startRow, startCol, subMatrixRows, subMatrixCols);

    }

    static void FillMatrix(int[,] matrix, int rows, int cols)
    {
      
        for (int i = 0; i < rows; i++)
        {
            string[] line = Console.ReadLine().Split();
            for (int l = 0; l < cols; l++)
            {
                matrix[i, l] = int.Parse(line[l]);
            }
        }
    }

    static void FindMaximalSum(int[,] matrix, int subRows, int subCols, out int maxSum, out int startRow, out int startCol)
    {
        maxSum = 0;
        startRow = 0;
        startCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - (subRows - 1); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - (subCols - 1); col++)
            {
                int sum = 0;
                for (int tempRow = row; tempRow < row + subRows; tempRow++)
                {
                    for (int tempCol = col; tempCol < col + subCols; tempCol++)
                    {
                        sum += matrix[tempRow, tempCol];
                    }
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    startRow = row;
                    startCol = col;
                }
            }
        }
    }
    static void PrintSubMatrix(int[,] matrix, int startRow, int startCol, int subRows, int subCols)
    {
        for (int row = startRow; row < startRow + subRows; row++)
        {
            for (int col = startCol; col < startCol + subCols; col++)
            {
                Console.Write(matrix[row, col]+" ");
            }
            Console.WriteLine();
        }
    }
}