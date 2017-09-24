using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader("..//..//students.txt");
        int lineNumber = 0;
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 == 0)
                {
                    Console.WriteLine(line);
                }
                line = reader.ReadLine();
                lineNumber++;
            }


        }
        reader.Close();
    }
}

