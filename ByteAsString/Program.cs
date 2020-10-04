using System;
using System.IO;
using System.Text;

namespace ByteAsString
{
    class Program
    {
        static void Main(string[] args)
        {
            //полезно е с енкодинга който ни дава и кирилица
            // може да ни се наложи в някои алгуритми за криптиране като shaia, shaia256
            string text = "Hey това е текст in english";
            using (FileStream stream =
                new FileStream("../../../output.txt", FileMode.OpenOrCreate))
            {
                byte[] byteText = Encoding.UTF8.GetBytes(text);
                stream.Write(byteText, 0, byteText.Length);
            }
        }
    }
}
