using System;
using System.IO;

namespace FileSizeWithRecurtion
{
    class Program
    {
        //Подавам на конзолата път до директория, която искам да изтрия и всичко включително поддиректориите изчезва!

        static void Main(string[] args)
        {
            string directoryPath = Console.ReadLine();//А ако му напишем тук "C:/" става вирус ще затрие Ц -то (особено ако се стартира като администрарор, защото уиндоус си има защити)

            Console.WriteLine(GetDirectorySize(directoryPath));
        }

        static double GetDirectorySize(string directoryPath)
        {
            string[] files = Directory.GetFiles(directoryPath);

            double sum = 0;

            string[] directories = Directory.GetDirectories(directoryPath);
            for (int i = 0; i < directories.Length; i++)
            {
                Console.WriteLine($"Directory: {directories[i]}");
                sum += GetDirectorySize(directories[i]);
                Directory.Delete(directories[i]);
            }

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                Console.WriteLine($"---{info.FullName} --> {info.Length}");
                sum += info.Length;
                File.Delete(files[i]);

            }

            return sum;
        }
    }
}
