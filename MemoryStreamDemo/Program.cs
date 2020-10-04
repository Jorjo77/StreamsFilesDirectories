using System;
using System.IO;

namespace MemoryStreamDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //като файл стрийма е, не е във файл а е в паметта. Полезен е за да можем да подадем на базата данни стрийм за да си вземе данните както си иска(правим големи данни на стрийм за да може някой да ги консумира на части), а не наведнъж, което може да даде проблем ако обема е голям. рядко се ползва, но се ползва! 
           MemoryStream stream = new MemoryStream();
            stream.Write(new byte[] { 1, 2, 3 }, 0, 3);
            var buffer = new byte[3];
            stream.Seek(0, SeekOrigin.Begin); //тук си нулираме позишънъ
            stream.Read(buffer, 0, 3);
            Console.WriteLine(string.Join(" ", buffer));
        }
    }
}
