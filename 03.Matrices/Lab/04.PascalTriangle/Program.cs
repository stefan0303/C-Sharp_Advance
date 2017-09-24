using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = n + 1;
        int[,] arr = new int[m, m];
        int spaces = (n + 1) * 2;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (i > 0)
                {
                    if (j == 0 || j == i - 1)
                    {
                        arr[i, j] = 1;
                    }
                }
                if (j > 0 && i > 0 && (j != 0 || j != i - 1))
                {
                    arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j];
                }
            }
        }

        for (int i = 0; i < m; i++)
        {
           
            for (int j = 0; j < m; j++)
            {
                if (arr[i, j] != 0)
                {
                    if (arr[i, j] < 10)
                    {
                        Console.Write("{0} ", arr[i, j]);
                    }
                    else if (arr[i, j] > 9 && arr[i, j] < 100)
                    {
                        Console.Write("{0} ", arr[i, j]);
                    }
                    else Console.Write("{0} ", arr[i, j]);
                }
            }

            Console.WriteLine();
            spaces -= 2;
        }
    }
}