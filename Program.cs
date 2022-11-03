using System;
using System.IO;

namespace LA1200
{
    class Program
    {
        static void Main(string[] args)
        {

            string inPath = @"path/to/jlpt.csv";
            string text = File.ReadAllText(inPath);

            string[] lines = text.Split("\r\n");
            int words = lines.Length;
            string[] kanji = new string[words];
            string[] kana = new string[words];
            string[] english = new string[words];

            for (int line = 0; line < lines.Length; line++)
            {
                string[] items = lines[line].Split(',');
                kanji[line] = items[0];
                kana[line] = items[1];
                english[line] = items[2].Replace("\"", string.Empty); ;
            }

            string outText = "";


            Random rnd = new Random();
            
            for (int i = 0; i < kanji.Length; i++ )
            {
                outText += $"{i},{kanji[i]},{rnd.Next()}\r\n";
            }

            string outPath = @"/Users/sazerac/Downloads/jlpt_scores.csv";

            File.WriteAllText(outPath, outText);
        }
    }
}
