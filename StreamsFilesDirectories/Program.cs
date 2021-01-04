﻿using System;
using System.IO;

namespace StreamsFilesDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
