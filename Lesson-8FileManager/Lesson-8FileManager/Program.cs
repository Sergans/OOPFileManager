using System;
using System.IO;
using Lesson_8FileManager;
using Lesson_8FileManager.Files;
using Lesson_8FileManager.Content;
using System.Collections.Generic;


namespace Lesson_8FileManager
{
    class Program
    {    public static void Print(ListContent content)
        {
            foreach (var c in content.ContentList)
            {
                //Console.BackgroundColor=ConsoleColor.Red;
                Console.Write($"{c.Name} ");
                Console.Write($"{c.Size} ");
                Console.Write($"{c.DataCreate} ");
                Console.WriteLine();
            }
        }
        //public static ListContent Select(ListContent content)
        //{
        //    if(ConsoleKey.DownArrow)
        //}
        static void Main(string[] args)
        {
            
            ListContent content = new ListContent();
            content.Open(@"C:\Users\GANS\Desktop\Catalog");
            // var a = content.ContentList[4];
            // content.Delete(a);

            Print(content);
           Console.WriteLine(content.GetSize());
           
        }
    }
}
