using System;
using System.IO;

namespace DirectoriesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ////не излиза в солюшън експлорера като е празна, но я създава където сме казали!
            //Directory.CreateDirectory("../../../papkata");

            //Directory.GetFiles("papkata");
            //Directory.GetCurrentDirectory();
            //02:57 от видеото има как да си направим вирус!
            //02:59 резюме!:
            //StreamReader and StreamWriter са основните и важни от тази лекция!!!
            Console.WriteLine(GetDirectorySize(directoryPath));
        }
        static double GetDirectorySize(string directoryPath)
        {

            string[] files = Directory.GetFiles(directoryPath);
            double sum = 0;
            string[] directofies = Directory.GetDirectories(directoryPath);
            for (int i = 0; i < directofies.Length; i++)
            {
                sum += GetDirectorySize(directofies[i]);
            }
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                Console.WriteLine($"{info.FullName}-->{info.Length} bytes");
                sum += info.Length;
            }
            return sum;
        }
    }
}
