using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace EvenLines
{
    class EvenLines
    {
        static void Main(string[] args)
        {

            //using (var reader = new StreamReader("../../../text.txt"))
            //{
            //    var lineCounter = 0;


            //    char[] symbolsForReplace = new[] { '-', ',', '.', '!', '?' };

            //    while (!reader.EndOfStream)
            //    {
            //        string line = reader.ReadLine();
            //        var splitedLine = line.Split();
            //        if (lineCounter % 2 == 0)
            //        {
            //            for (int i = 0; i < splitedLine.Length; i++)
            //            {
            //                var currWord = splitedLine[i];
            //                foreach (var symbol in symbolsForReplace)
            //                {
            //                    currWord = currWord.Replace(symbol, '@');
            //                }

            //                splitedLine[i] = currWord;
            //            }

            //            var result = string.Join(" ", splitedLine.Reverse());
            //            Console.WriteLine(result);
            //        }

            //        lineCounter++;

            //    }





                //using (StreamReader reader = new StreamReader("../../../text.txt"))
                //{
                //    string line = reader.ReadLine();
                //    int lineCounter = 0;
                //    while (line!=null)
                //    {

                //        if (lineCounter%2==0)
                //        {
                //            string pattern = @"[.,!?-]";
                //            Regex regex = new Regex(pattern);
                //            line = regex.Replace(line, "@");
                //            var reversedLine = line.Split().ToArray().Reverse();
                //            Console.WriteLine(string.Join(" ", reversedLine));

                //        }
                //        lineCounter++;
                //        line = reader.ReadLine();
                //    }
            }
            //ако искаме да го запишем във файл:
            //using (StreamReader reader = new StreamReader("../../../text.txt"))
            //{
            //    using (StreamWriter writer = new StreamWriter("../../../output.txt"))
            //    {
            //        string line = reader.ReadLine();
            //        int lineCounter = 0;
            //        while (line != null)
            //        {

            //            if (lineCounter % 2 == 0)
            //            {
            //                string pattern = @"[.,!?-]";
            //                Regex regex = new Regex(pattern);
            //                line = regex.Replace(line, "@");
            //                var reversedLine = line.Split().ToArray().Reverse();
            //                writer.WriteLine(string.Join(" ", reversedLine));

            //            }
            //            lineCounter++;
            //            line = reader.ReadLine();
            //        }
            //    }
            //}
        }
    }
}
