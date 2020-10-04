using System;
using System.IO;

namespace FileApi
{
    class Program
    {
        static void Main(string[] args)
        {
            //той препоръчва StreamReader и StreamWriter, но и това върши работа File.Exist, File.Delate, File.Mouve полезни
            Console.WriteLine(File.ReadAllText("../../../filedemo.txt"));
            File.WriteAllText("../../../filedemo.txt", "eazy pizi");
        }
    }
}
