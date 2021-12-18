﻿using System;
using System.IO;
using Lesson_8FileManager;
using Lesson_8FileManager.Files;
using Lesson_8FileManager.Content;
using System.Collections.Generic;
using Lesson_8FileManager.SelectOperation;


namespace Lesson_8FileManager
{
    class Program
    {  
        public static void Print(ContentOperation content)
        {
            DriveInfo disk = new DriveInfo("C");
            if (content.contents.Count == 0)
            {
                Console.WriteLine("Эта папка пуста");
            }
            for (int i = 0; i < content.contents.Count; i++)
            {
                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{content.contents[i].GetName()} {disk.Name} ");
                    Console.Write($"{content.contents[i].GetSize()} ");
                    Console.Write($"{content.contents[i].GetDate()} ");
                    Console.WriteLine();
                }
                else
                {
                    Console.ResetColor();
                    Console.Write($"{content.contents[i].GetName()} ");
                    Console.Write($"{content.contents[i].GetSize()} ");
                    Console.Write($"{content.contents[i].GetDate()} ");
                    Console.WriteLine();
                }
            }

        }
        public static void Print(ContentOperation content, IContent selectContent)
        {
            Console.Clear();
            if (content.contents.Count == 0 && selectContent == null)
            {
                Console.ResetColor();
                Console.WriteLine("Эта папка пуста");
            }
            for (int i = 0; i < content.contents.Count; i++)
            {


                if ((content.contents[i] == selectContent) && i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{content.contents[i].GetName()} ");
                    Console.Write($"{content.contents[i].GetSize()} ");
                    Console.Write($"{content.contents[i].GetDate()} ");
                    Console.WriteLine();
                }
                else if (content.contents[i] == selectContent)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{content.contents[i].GetName()} ");
                    Console.Write($"{content.contents[i].GetSize()} ");
                    Console.Write($"{content.contents[i].GetDate()} ");
                    Console.WriteLine();
                }
                else
                {
                    Console.ResetColor();
                    Console.Write($"{content.contents[i].GetName()} ");
                    Console.Write($"{content.contents[i].GetSize()} ");
                    Console.Write($"{content.contents[i].GetDate()} ");
                    Console.WriteLine();
                }

            }

        }

        static void Main(string[] args)
        {
            DriveInfo disk =new DriveInfo("C");
          // var a=  Directory.GetFiles(@"C:\Program Files (x86)");
           ContentOperation content = new ContentOperation();
           SelectCommand operation = new SelectCommand();
           Print(content.Open(@"C:\Program Files (x86)"));
            while (true)
            {
                var button = Console.ReadKey().Key;
                Print(content, operation.Select(content, button));
            }

        }
    }
}
