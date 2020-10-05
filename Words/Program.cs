using System;
using System.Collections.Generic;
using System.IO;

namespace Words
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader words = new StreamReader("../../../words.txt"))
            {
                using (StreamReader text = new StreamReader("../../../text.txt"))
                {
                    words.ReadToEnd().ToString().ToLower();
                    Dictionary<string, int> occurrences = new Dictionary<string, int>();
                    for (int i = 0; i < words; i++)
                    {

                    }
                }
            }
            
           
        }
    }
}
