using System;
using System.IO;
using System.Linq;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file and inserts line numbers in front of each of its lines and count all the letters
            //and punctuation marks. The result should be written to another text file.Use the static class File.

            var text = File.ReadLines("../../../input.txt");
            int lineCount = 1;
            foreach (var line in text)
            {
                var symbolsNumber = 0;
                var lettersNumber = 0;
                for (int i = 0; i < line.Length; i++)
                {
                    if (char.IsLetter(line[i]))
                    {
                        lettersNumber++;
                    }
                    else if (!char.IsWhiteSpace(line[i]) && !char.IsLetterOrDigit(line[i]))
                    {
                        symbolsNumber++;
                    }

                }
                File.AppendAllText("../../../output.txt", $"Line {lineCount}: {line} ({lettersNumber})({symbolsNumber})\n");
                lineCount++;
            }


            //Друга е тази задача:
            //using (var reader = new StreamReader("../../../input.txt"))
            //{

            //    using (var writer = new StreamWriter("../../../output.txt"))
            //    {
            //        var line = reader.ReadLine();
            //        int index = 1;
            //        while (line!=null)
            //        {
            //            writer.WriteLine($"{index}. {line}");
            //            Console.WriteLine($"{index}. {line}");
            //            index++;
            //            line = reader.ReadLine();
            //        }
            //    }
            //}
        }
    }
}

