using System.IO;

class Program
{
    static void Main()
    {
        //    using (FileStream stream = File.OpenRead("..//..//PA-3619118.jpg"))
        //    using (FileStream writeStream = File.OpenWrite("..//..//resultImage.jpg"))
        string NImagePath = "..//..//PA-3619118.jpg";
        string DestinationPath = "..//..//resultImage.jpg";

        using (var source = new FileStream(NImagePath, FileMode.Open))
        {
            using (var destination = new FileStream(DestinationPath, FileMode.Create))
            {
                byte[] buffer = new byte[source.Length];
                while (true)
                {
                    int readBytes = source.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }

                    destination.Write(buffer, 0, readBytes);
                }
            }
        }
    }
}

