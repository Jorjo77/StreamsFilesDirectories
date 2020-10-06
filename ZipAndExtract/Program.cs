using System;
using System.IO.Compression;

namespace ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
             ZipFile.CreateFromDirectory(@"D:\SoftUni\AdvancedC#\ZipFileDemo", @"D:\SoftUni\AdvancedC#\myZipFile.zip");
             ZipFile.ExtractToDirectory(@"D:\SoftUni\AdvancedC#\myZipFile.zip", @"D:\SoftUni\AdvancedC#\ZipFileDemoResult");
        }
    }
}
