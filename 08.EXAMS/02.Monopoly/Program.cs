using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] colRow = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = colRow[1];
        int col = colRow[0];

        string[,] matrix = new string[col, rows];
        for (int i = 0; i < col; i++) //Read the matrix
        {
            char[] input = Console.ReadLine().ToCharArray();
            for (int j = 0; j < rows; j++)
            {

                matrix[i, j] = input[j].ToString();
            }
        }
        int count = 0;
        int money = 50;
        int numberOfHotels = 0;
        int jail = 1;
        int turns = 0;
        for (int i = 0; i < col; i++) //WORK WITH MATRIX
        {

            if (count % 2 == 0)
            {

                for (int j = 0; j < rows; j++)
                {
                    turns++;

                    switch (matrix[i, j])
                    {
                        case "H":

                            numberOfHotels++;
                            Console.WriteLine("Bought a hotel for {0}. Total hotels: {1}.", money, numberOfHotels);
                            money = 0;

                            break;
                        case "J":
                            Console.WriteLine("Gone to jail at turn {0}.", turns - 1);

                            jail++;
                            turns += 2;
                            money += 2 * (numberOfHotels * 10);
                            break;
                        case "F":

                            break;
                        case "S":
                            Console.WriteLine("Spent {0} money at the shop.", i + j + 1);
                            if (money > i)
                            {
                                money -= i + 1 + j;
                            }
                            else
                            {
                                money = 0;
                            }
                            break;
                    }
                    if (numberOfHotels > 0)
                    {
                        money += numberOfHotels * 10;
                    }
                }
            }
            else
            {

                for (int j = rows - 1; j >= 0; j--)
                {
                    turns++;

                    switch (matrix[i, j])
                    {
                        case "H":

                            numberOfHotels++;
                            Console.WriteLine("Bought a hotel for {0}. Total hotels: {1}.", money, numberOfHotels);

                            money = 0;

                            break;
                        case "J":
                            Console.WriteLine("Gone to jail at turn {0}.", turns - 1);

                            jail++;
                            turns += 2;
                            money += 2 * (numberOfHotels * 10);
                            break;
                        case "F":
                            if (numberOfHotels > 0)
                            {

                            }
                            break;
                        case "S":
                            Console.WriteLine("Spent {0} money at the shop.", i + j + 1);
                            if (money > i)
                            {
                                money -= i + 1 + j;
                            }
                            else
                            {
                                money = 0;
                            }
                            break;
                    }
                    if (numberOfHotels > 0)
                    {
                        money += numberOfHotels * 10;
                    }
                }
            }
            count++;

        }
        Console.WriteLine("Turns {0}", turns);
        Console.WriteLine("Money {0}", money);
    }
}

