using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> readWords = new List<string>(); //List of words to find
        StreamReader reader = new StreamReader("..//..//words.txt");
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                readWords.Add(line);
                line = reader.ReadLine();
            }
        }
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        using (StreamReader sr = new StreamReader("..//..//text.txt"))
        {

            int total = 0;
            while (!sr.EndOfStream)
            {
                var words = sr
                    .ReadLine()
                    .Split(' ', '.', '-', '?', '!', ',').ToArray();
                for (int i = 0; i < readWords.Count; i++)
                {
                    for (int j = 0; j < words.Length; j++)
                    {

                        if (readWords[i].ToLower() == words[j].ToLower())
                        {
                            total += 1;
                        }
                    }
                    if (!wordCount.ContainsKey(readWords[i]))
                    {
                        wordCount.Add(readWords[i], total);
                    }
                    else
                    {
                        wordCount[readWords[i]] += total;
                    }

                    total = 0;
                }
            }
        }
        using (var writer = new StreamWriter("../../result03.txt"))
        {
            foreach (var word in wordCount.OrderByDescending(w => w.Value))
            {
                //  Console.WriteLine(word.Key + " " + word.Value);
                writer.WriteLine("{0} - {1}", word.Key, word.Value);
            }
            writer.Close();
        }
    }
}

