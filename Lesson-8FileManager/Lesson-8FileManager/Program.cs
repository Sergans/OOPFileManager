using System;
using System.IO;
using Lesson_8FileManager;
using Lesson_8FileManager.Files;
using Lesson_8FileManager.Content;
using System.Collections.Generic;


namespace Lesson_8FileManager
{
    class Program
    {    public static void Print(ContentModel content)
        {
            
                //Console.BackgroundColor=ConsoleColor.Red;
                Console.Write($"{content.Name} ");
                Console.Write($"{content.Size} ");
                Console.Write($"{content.DataCreate} ");
                Console.WriteLine();
         }

        public static ContentModel Select(ListContent content)
        {
            int i = 0;
            if (ConsoleKey.DownArrow == Console.ReadKey().Key)
            {
                i++;
                return content.ContentList[i];
            }

            return content.ContentList[i];
        }
        static void Main(string[] args)
        {
            
            ListContent content = new ListContent();
            content.Open(@"C:\Users\GANS\Desktop\Catalog");
            // var a = content.ContentList[4];
            // content.Delete(a);

            Print(Select(content));
            Print(Select(content));
            Console.WriteLine(content.GetSize());
           
        }
    }
}
