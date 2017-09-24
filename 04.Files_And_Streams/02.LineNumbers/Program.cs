using System.IO;

class Program
{
    static void Main()
    {
        using (var reader = new StreamReader("../../students.txt"))
        {
            using (var writer = new StreamWriter("../../studentsWrite.txt"))
            {
                int countLines = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.Write("{0}. {1}", countLines, line);

                    writer.WriteLine();
                    line = reader.ReadLine();
                    countLines++;
                }
            }
        }
    }
}

