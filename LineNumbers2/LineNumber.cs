using System;
using System.IO;
using System.Linq;

namespace LineNumbers2
{
    class LineNumber
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../text.txt");
            string[] result = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                int letterCount = lettersCounter(line);
                int punctuationsCount = punctuationsCounter(line);

                result[i] = ($"Line {i + 1}: {line} ({letterCount})({punctuationsCount})");
                //и тук може и отвън File.WriteAllLines("../../../output.txt", result);
            }
            File.WriteAllLines("../../../output.txt", result);
        }
        static int lettersCounter(string line)
        {
            int counter = 0;
            for (int i = 0; i < line.Length; i++)
            {
                char currSymbol = line[i];
                if (Char.IsLetter(currSymbol))
                {
                    counter++;
                }
            }
            return counter;
        }
        static int punctuationsCounter(string line)
        {
            int counter = 0;
            char[] punctuationsSymbols = new char[] { '-', '.', ',', '\'', ':', ';', '!', '?' };
            for (int i = 0; i < line.Length; i++)
            {
                char currSymbol = line[i];
                if (punctuationsSymbols.Contains(currSymbol))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
