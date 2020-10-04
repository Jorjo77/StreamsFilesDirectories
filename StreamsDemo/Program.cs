using System;
using System.IO;

namespace StreamsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Най-важното за stream-а:
            //stream пази само до къде е стигнал stream.Position и до къде може да стигне stream.Length
            //stream знае от къде да вземе "../../../input.txt" и знае къде да сложи - в buffer и той това прави!!!

            //абсолютните пътища са нещо много лошо, което не трябва да се използва, това е релативен път "../../../input.txt" т.е. относителен, от там където се намираме!
            byte[] buffer = new byte[100];

            using (FileStream stream = new FileStream("../../../input.txt", FileMode.OpenOrCreate))
            {
                Console.WriteLine($"File length: {stream.Length}");
                int bytes = stream.Read(buffer, 0, 3);
                Console.WriteLine($"Read bytes: {bytes}");
                Console.WriteLine($"Stream Position: {stream.Position}");
                //stream.Write(buffer, 0, buffer.Length);
                stream.Read(buffer, 0, 3);
                Console.WriteLine($"Stream Position: {stream.Position}");
                stream.Read(buffer, 3, 3);
                Console.WriteLine($"Stream Position: {stream.Position}");
                stream.Read(buffer, 6, 3);
                Console.WriteLine($"Stream Position: {stream.Position}");
                Console.WriteLine(string.Join(" ", buffer));
            }

        }
    }
}
