using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTravarsal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> failsData = new Dictionary<string, Dictionary<string, double>>();
            DirectoryInfo directoryInfo = new DirectoryInfo("../../../");
            FileInfo[] files = directoryInfo.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {

                if (!failsData.ContainsKey(files[i].Extension))
                {
                    failsData.Add(files[i].Extension, new Dictionary<string, double>());
                }
                failsData[files[i].Extension].Add(files[i].Name, files[i].Length/1024);
            }

            using (StreamWriter writer = new StreamWriter(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\DirectoryTraversal.txt"))
            {
                foreach (var extention in failsData.OrderByDescending(f => f.Value.Count).ThenBy(e => e.Key))
                {
                    writer.WriteLine(extention.Key);
                    foreach (var file in extention.Value.OrderBy(e => e.Value))
                    {
                        writer.WriteLine($"--{file.Key} - {file.Value}kb");
                    }
                }
            }
        }
    }
}
