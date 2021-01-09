using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WordsCounter
{
    class WordCount
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            using (var reader = new StreamReader("../../../words.txt"))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var text = File.ReadAllText("../../../text.txt");
                    char[] separators = new char[] { ' ', '.', ',', '!', '?', '-' };
                    var splitedText = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < splitedText.Length; i++)
                    {
                        string currWord = splitedText[i].ToLower();
                        if (currWord == line)
                        {
                            if (!result.ContainsKey(currWord))
                            {
                                result.Add(currWord, 0);
                            }

                            result[currWord] += 1;
                        }
                    }
                }

                using (var writer = new StreamWriter("../../../actualResults.txt", true))
                {
                    foreach (var word in result)
                    {
                        writer.WriteLine($"{ word.Key} - {word.Value}");
                    }
                }
                var sortedResult = result.OrderByDescending(x => x.Value);
                StringBuilder sb = new StringBuilder();
                foreach (var word in sortedResult)
                {
                    sb.AppendLine($"{ word.Key} - {word.Value}");
                }
                File.WriteAllText("../../../expectedResult.txt", sb.ToString());
            }


            //Dictionary<string, int> wordsCounter = new Dictionary<string, int>();
            //string[] separators = new string[] { " ", "/n", "?", "!", "?!", ".", ",", "-" };
            //string text = File.ReadAllText("../../../text.txt");
            //string[] words = File.ReadAllLines("../../../words.txt");
            //string[] splitedText = text.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //for (int i = 0; i < words.Length; i++)
            //{
            //    string currWord = words[i];
            //    for (int j = 0; j < splitedText.Length; j++)
            //    {
            //        string word = splitedText[j].ToLower();
            //        if (word == currWord)
            //        {
            //            if (!wordsCounter.ContainsKey(word))
            //            {
            //                wordsCounter.Add(word, 0);
            //            }
            //            wordsCounter[word] += 1;
            //        }
            //    }
            //}
            //using (StreamWriter writer = new StreamWriter("../../../actualResults.txt"))
            //{
            //    foreach (var kvp in wordsCounter)
            //    {
            //        writer.WriteLine($"{kvp.Key} - {kvp.Value}");
            //    }
            //}
            //using (StreamWriter writer2 = new StreamWriter("../../../expectedResults.txt"))
            //{
            //    foreach (var kvp in wordsCounter.OrderByDescending(x => x.Value))
            //    {
            //        writer2.WriteLine($"{kvp.Key} - {kvp.Value}");
            //    }
            //}


            // с клас StreamReader и StreamWriter
            //Dictionary<string, int> wordsCounter = new Dictionary<string, int>();
            //using (StreamReader wordsReader = new StreamReader("../../../words.txt"))
            //{
            //    using (StreamReader textReader = new StreamReader("../../../text.txt"))
            //    {

            //        string[] separators = new string[] { " ", "/n", "?", "!", "?!", ".", ",", "-" };
            //        string[] text = textReader.ReadToEnd().ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //        string word = wordsReader.ReadLine();
            //        while (word != null || word != "")
            //        {

            //            if (word == null || word == "")
            //            {
            //                break;
            //            }
            //            for (int i = 0; i < text.Length; i++)
            //            {
            //                string currWord = text[i];
            //                if (word == currWord)
            //                {
            //                    if (!wordsCounter.ContainsKey(word))
            //                    {
            //                        wordsCounter.Add(word, 0);
            //                    }
            //                    wordsCounter[word] += 1;
            //                }
            //            }
            //            word = wordsReader.ReadLine();
            //        }
            //        using (StreamWriter writer = new StreamWriter("../../../actualResults.txt"))
            //        {
            //            foreach (var kvp in wordsCounter)
            //            {
            //                writer.WriteLine($"{kvp.Key} - {kvp.Value}");
            //            }

            //        }
            //        using (StreamWriter writer2 = new StreamWriter("../../../expectedResults.txt"))
            //        {
            //            foreach (var kvp in wordsCounter.OrderByDescending(x => x.Value))
            //            {
            //                writer2.WriteLine($"{kvp.Key} - {kvp.Value}");
            //            }
            //        }
            //    }
            //}
        }
    }
}
 
