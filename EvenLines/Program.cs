using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                string line = reader.ReadLine();
                int lineCounter = 0;
                while (line!=null)
                {

                    if (lineCounter%2==0)
                    {
                        string pattern = @"[.,!?-]";
                        Regex regex = new Regex(pattern);
                        line = regex.Replace(line, "@");
                        var reversedLine = line.Split().ToArray().Reverse();
                        Console.WriteLine(string.Join(" ", reversedLine));

                    }
                    lineCounter++;
                    line = reader.ReadLine();
                }
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
