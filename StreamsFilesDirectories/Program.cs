using System;
using System.IO;

namespace StreamsFilesDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            //Стрийм е клас в С#, който използваме за да работим с данни от източник различен от РАМ паметта, като файлова с-ма, данни от мрежата (дори за отваряне и четене/записване на файл се използва стрийм, като не прочитаме наведнъж целия файл (той може да е огромен спрямо нашата РАМ памет)). Една от бавните операции е четенето от харддиска (дори от ССД). Стрийма помни къде се намира (до къде е стигнала четящата глава) и може да се мести напред и назад. Командите за стийма са: Запиши, прочети, премести се! Четенето става през буфер, който е масив с определен размер 4096 bite, което е 4 kb - това е стандартния размер за буфер и първоначално е от нули.

            //Декоратор стриймове са такива, които освен да запишат файла, могат и да го компресират, кодират и изпратят.

            //StreamReader и StreamWriter са за текстови данни (файлове), а BinaryReader и BinaryWriter са за данни (файлове) които са в бинарната (двуичната бройна с-ма)

            //Console.WriteLine(Environment.CurrentDirectory);//показва ни в коя директория е програмата

            //StreamWriter writer = new StreamWriter("MyTextFile.txt");//Така ще създадем текст файл във папката на програмата//Тук можем да подадем друг стрийм (така се прави декорейтинг патерна)

            //StreamWriter writer2 = new StreamWriter("MyTextFile2.txt", false, Encoding.UTF32);//false за апендването (всеки път ще пише наново (отначало), с true ще продължава текста от края), а енкодинга може да се сменя. UTF8 е дефолтния енкодинг и е най-мощния и най-използвания в света (в него текста заема най-малко място най-добре оптимизиран е, докато при другите енкодинги размера е фиксиран)!!!

            //1 ASCI символ се кодира в 1 байт
            //1 байт има 8 бита
            //1 байт може да има 256 различни ст-сти!
            //1 бит можем да запазим 2 ст-сти - 0 и 1-ца!
            //В енкодинг windows 1251 e кирилицата, но трябва да инсталитаме такъв нугет за VS -a !

            //writer.Write("Hello!");
            //writer.Close();
            //Когато използваме Уиндоус, ние използваме NTFS файлова с-ма, която е хубава и бърза, но има и други видове, например на Линукс XT3  или XT4 файлова с-ма. Файловата с-ма е абстракция на единиците и нулите на харддиска.

            //Ако класа ни наследява IDisposable, то той може да бъде слаган в Using (всички стримове са така)

            //Ако създадем текстов файл в директорията на програм, за да го вижда VS-a, трябва да му кажем с десен бутон Properties - copy aways и ще заработи, като си прави копие на този файл в bin папката.

            //using (var reader = new StreamReader("lines.txt"))
            //{
            //    using (var writer3 = new StreamWriter("output.txt"))//създава файл там където ни е програмата в bin папката и пише в него!
            //    {
            //        while (!reader.EndOfStream)//така е правилно да четем докато има редове във файла
            //        {
            //            var line = reader.ReadLine();
            //            writer3.WriteLine(line);
            //        }
            //    }
            //}

            //!!!конвентиране от текст към байт масив:
            //var a = Encoding.UTF8.GetBytes("a,b,c");
            //!!!конвентиране от байт масив към текст :
            //var b = Encoding.UTF8.GetString(new byte[]{48, 49, 50 });

            //Как да разделим файл на n на брой части:
            //double n = double.Parse(Console.ReadLine());

            //var totalSize = new FileInfo("lines.txt").Length;

            //var sizePerFile = (int)Math.Ceiling(totalSize / n);

            //using (var reader = new FileStream("lines.txt", FileMode.Open))
            //{
            //    for (int i = 1; i <= n; i++)
            //    {
            //        var bufer = new byte[sizePerFile];
            //        var readBytes = reader.Read(bufer, 0, sizePerFile);
            //        using (var writer = new FileStream($"File-{i}.txt", FileMode.Create))
            //        {
            //            writer.Write(bufer, 0, readBytes);
            //        }
            //    }
            //}


            //Ако искаме да прочетем файл от друга директория можем да му дадем пътя до нея (кейс инсенситив е):
            //using (var reader = new StreamReader(@"C:/MyTemp/jojo.txt"))//@ is for escaping special symbols!
            //{
            //    while (!reader.EndOfStream)//така е правилно да четем докато има редове във файла
            //    {
            //        var line = reader.ReadLine();
            //        Console.WriteLine(line);
            //    }
            //}

            //Ако искаме да изтрием файл от някоя дирекрория, просто трябва да:
            //File.Delete(@"C:\MyTemp\Jojo.txt");
            string text = File.ReadAllText("file.txt");//така можем да четем целия текст от файла
            string[] textArr = File.ReadAllLines("file.txt");//така можем да четем целия текст от файла ако го искаме във стринг масив (всеки ред е отделен елемент от масива)

            //Писане на стринг в текст файл:
            File.WriteAllText("string path", "string content");//без ридъри, без райтъри, без нищо!
            string[] names = new string[] { "An", "George", "Ivo" };
            File.ReadAllLines("output.txt", names);
            File.AppendAllText("output.txt", "/n More text /n");

            //Други полезни:
            File.Create("string path");
            File.GetCreationTime("string path");
            File.GetAttributes("string path");
            File.Encrypt("string path");
            //и още много възможности (да променим със Set мета информацияв за файла например)

            //Полезни за Directory:
            //Creating a directory (with all its subdirectories at the specified path), unless they already exists:

            Directory.CreateDirectory("TestFolder");
            Directory.Delete("TestFolder", true);
            Directory.Move("TestFolder", "New Folder"); //Move е rename!!!
            string[] filesInDir = Directory.GetFiles("TestFolder");
            string[] subDirs = Directory.GetDirectories("TestFolder");


            //възможността да създаваме файл, да записваме в него или четем от него ни дава много възможности:
            //1. програмата ни да има стейт (запазено състояние)!!!
            //2. можем да си направим елементарна база данни (до вчера не можехме)
            //3. така при игрите se записва във файл до къде си стигнал (за да не започваш всеки път от начало)

            //Идея: с регекс можем да направим програма, която намира мейли в даден сайт и ги записва във файл.

            // . означава там където съм, с наклонена ни дава директорията в която сме ./ (за CMD също важи това)
            //С две точки и наклонена (../) в уиндоус е една папка назад
            //.Read - чете само един символ!

            //OFF TOPIC:
            //Познанията които имаме по програмиране са ни достатъчни да почнем да се занимаваме с data science, AI, mashine learning, но при тези трябва и математика и статистика. Програмирането е на много ниско базово ниво.  
            //leetCode.com и hackerRanc.com - сайт с много хубави задачи, включително такива които са се падали на интервюта на големите компании!

            //прочитаме първи ред от файла
            //StreamReader reader = new StreamReader("../../../input.txt");
            //string firstStudent = reader.ReadLine();
            //Console.WriteLine(firstStudent);
            //reader.Close();


            //прочитаме всички редове от файла с char (така ако не кастнем към char ще получим ASCi кодовете на символите)
            //StreamReader reader = new StreamReader("../../../input.txt");

            //а може и с ReadToEnd() да разпечатаме всички редове
            //var student = reader.ReadToEnd();
            //Console.WriteLine(student);

            //var student = reader.Read();
            //while (student != -1)
            //{
            //    Console.Write(/*(char)*/student);
            //    student = reader.Read();
            //}
            //reader.Close();

            //прочитаме всички редове от файла
            //StreamReader reader = new StreamReader("../../../input.txt");
            //string student = reader.ReadLine();
            //while (student!=null)
            //{
            //    Console.WriteLine(student);
            //    student = reader.ReadLine();
            //}
            //reader.Close();

            //for (int i = 0; i < 10; i++)
            //{
            //    StreamWriter writer = new StreamWriter($"../../../students part {i + 1}.txt");
            //    writer.Write("First student");
            //    writer.WriteLine("Second student");
            //    writer.WriteLine("Thirth student");
            //    writer.Close();
            //}
            //reader.Close() не се използва в практиката за затваряне, използва се using!!!
            //Изполсването на Using е гаранция че ще спрем memory leak.
            //StreamReader reader = new StreamReader("../../../input.txt");
            //using (reader)
            //{
            //    Console.WriteLine(reader.ReadToEnd());
            //}


            //новия синтаксис:
            //using StreamReader reader = new StreamReader("../../../input.txt");
            //{
            //    Console.WriteLine(reader.ReadToEnd());
            //}

            //FileStream класа има повече функционалности от StreamReader и StreamWriter и се използва повече!

            //FileStream stream = new FileStream("../../../input.txt", FileMode.)
            //сега за да мога да пишa в този файл трябва да използвам някакъв буфер, понеже стриймовете използват поредица от байтове, трябва да използвам байт масив който да ми е буфер и с него да чета и пиша в/у този файл използвайки стийма който съм създал!


            //using- ите можем да ги подреждаме един под друг, без да ги нестваме и пак ще се затворят както трябва:
            //можем да използваме using по този начин (без да бъдат нестнати и ще се затворят и двата както трябва):
            //using (StreamReader reader = new StreamReader("../../../input.txt"))
            //using (StreamWriter writer = new StreamWriter($"../../../students part.txt"))
            //{
            //    Console.WriteLine(reader.ReadToEnd());
            //}

            ////не излиза в солюшън експлорера като е празна, но я създава където сме казали!
            //Directory.CreateDirectory("../../../papkata");

            //Directory.GetFiles("papkata");
            //Directory.GetCurrentDirectory();
            //02:57 от видеото има как да си направим вирус!
            //02:59 резюме!:

            //Ctrl+left click върху клас, тип, метод - ни показва мета датата му(начина по който работи)
        }
    }
}
