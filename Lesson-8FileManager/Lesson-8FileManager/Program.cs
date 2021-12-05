using System;
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
            if (content.contents.Count == 0)
            {
                Console.WriteLine("Эта папка пуста");
            }
            for (int i = 0; i < content.contents.Count; i++)
            {
                if (i == 0)
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
           ContentOperation content = new ContentOperation();
           SelectCommand operation = new SelectCommand();
           Print(content.Open(@"C:\Users\GANS\Desktop\Catalog\"));
            while (true)
            {
                var button = Console.ReadKey().Key;
                Print(content, operation.Select(content, button));
            }

        }
    }
}
