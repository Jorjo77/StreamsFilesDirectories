using System;
using System.IO;

namespace StreamsSecondDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            using (FileStream stream = new FileStream("../../../input.txt", FileMode.Open))
            {
                byte[] buffer = new byte[3];
                int count = 0;
                while (stream.Position < stream.Length)
                {
                    stream.Read(buffer, 0, buffer.Length);
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        Console.Write((char)buffer[i]);
                    }
                    //Console.WriteLine();
                }
            }
        }
    }
}
