using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, n];
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            char[] input = Console.ReadLine().ToCharArray();
            for (int j = 0; j < n; j++)
            {

                matrix[i, j] = input[j].ToString();
            }
        }

        for (int i = 0; i < n; i++)//cow
        {

            for (int j = 0; j < n; j++)//row
            {
                if (matrix[i, j] == "K")
                {
                    if (i + 2 < n && j - 1 < n && j - 1 >= 0 && matrix[i + 2, j - 1] == "K")//K down Left
                    {
                        matrix[i + 2, j - 1] = "0";
                        count++;

                    }
                    if (i + 2 < n && j + 1 < n && matrix[i + 2, j + 1] == "K")// K down Right
                    {
                        matrix[i + 2, j + 1] = "0";
                        count++;
                    }
                    if (i + 1 < n && j + 2 < n && matrix[i + 1, j + 2] == "K")//K right down
                    {
                        matrix[i + 1, j + 2] = "0";
                        count++;
                    }
                    if (i - 1 >= 0 && j + 2 < n && matrix[i - 1, j + 2] == "K")//K right up
                    {
                        matrix[i - 1, j + 2] = "0";
                        count++;
                    }
                    if (i - 1 >= 0 && j - 2 >= 0 && matrix[i - 1, j - 2] == "K")//K left down
                    {
                        matrix[i - 1, j - 2] = "0";
                        count++;
                    }
                    if (i + 1 < n && j - 2 >= 0 && matrix[i + 1, j - 2] == "K")  //K left up
                    {
                        matrix[i + 1, j - 2] = "0";
                        count++;
                    }
                    if (i - 2 >= 0 && j - 1 >= 0 && matrix[i - 2, j - 1] == "K")//K up left
                    {
                        matrix[i - 2, j - 1] = "0";
                        count++;
                    }
                    if (i - 2 >= 0 && j + 1 < n && matrix[i - 2, j + 1] == "K")//K up right
                    {
                        matrix[i - 2, j + 1] = "0";
                        count++;
                    }
                }
            }
        }

        Console.WriteLine(count);

    }

}

