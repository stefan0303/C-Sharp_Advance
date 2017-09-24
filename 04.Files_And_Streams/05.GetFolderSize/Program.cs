using System.IO;

class Program
{
    static void Main()
    {
        string[] files = Directory.GetFiles("TestFolder");//Write a folder
        double sum = 0;

        foreach (string file in files)
        {
            FileInfo fileInfo = new FileInfo(file);
            sum += fileInfo.Length;
        }

        sum = sum / 1024 / 1024;

        File.WriteAllText("оutput.txt", sum.ToString());
    }
}

