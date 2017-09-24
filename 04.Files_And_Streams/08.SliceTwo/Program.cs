using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;

class Program
{
    private static List<string> files = new List<string>();
    private static MatchCollection matches;

    static void Main()
    {
        string sourceFile = "";
        string destinationDirectory = "";
        int parts = int.Parse(Console.ReadLine());

        using (var source = new FileStream(sourceFile, FileMode.Open))
        {
            long partSize = (long)Math.Ceiling((double)source.Length / parts);

            long fileOffset = 0;

            string currPartPath;
            FileStream fsPart;
            long sizeRemaining = source.Length;

            string pattern = @"(\w+)(?=\.)\.(?<=\.)(\w+)";
            Regex pairs = new Regex(pattern);
            matches = pairs.Matches(sourceFile);

            for (int i = 0; i < parts; i++)
            {
                currPartPath = destinationDirectory + matches[0].Groups[1] + String.Format(@"-{0}", i) + "." + "gz";
                files.Add(currPartPath);

                using (fsPart = new FileStream(currPartPath, FileMode.Create))
                {
                    using (var compressionStream = new GZipStream(fsPart, CompressionMode.Compress, false))
                    {
                        long currentPieceSize = 0;
                        byte[] buffer = new byte[4096];
                        while (currentPieceSize < partSize)
                        {
                            int readBytes = source.Read(buffer, 0, buffer.Length);
                            if (readBytes == 0)
                            {
                                break;
                            }

                            compressionStream.Write(buffer, 0, readBytes);
                            currentPieceSize += readBytes;
                        }
                    }
                }

                sizeRemaining = (int)source.Length - (i * partSize);
                if (sizeRemaining < partSize)
                {
                    partSize = sizeRemaining;
                }
                fileOffset += partSize;
            }
        }
    }
}

