using System;
using System.IO;
using Lesson_8FileManager;
using Lesson_8FileManager.Files;
using Lesson_8FileManager.Content;
using System.Collections.Generic;


namespace Lesson_8FileManager
{
    class Program
    {  
       static int b=0;
        public static void Print(ListContent content)
        {
            for (int i = 0; i < content.ContentList.Count; i++)
            {
                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{content.ContentList[i].Name} ");
                    Console.Write($"{content.ContentList[i].Size} ");
                    Console.Write($"{content.ContentList[i].DataCreate} ");
                    Console.WriteLine();
                }
                else
                {
                    Console.ResetColor();
                    Console.Write($"{content.ContentList[i].Name} ");
                    Console.Write($"{content.ContentList[i].Size} ");
                    Console.Write($"{content.ContentList[i].DataCreate} ");
                    Console.WriteLine();
                }
            }
              
        }
        public static void Print(ListContent content,ContentModel selectContent)
        {
            Console.Clear();
            for(int i = 0; i < content.ContentList.Count; i++)
            {

                if ((content.ContentList[i] == selectContent)&&i==0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{content.ContentList[i].Name} ");
                    Console.Write($"{content.ContentList[i].Size} ");
                    Console.Write($"{content.ContentList[i].DataCreate} ");
                    Console.WriteLine();
                }
                else if(content.ContentList[i] == selectContent)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{content.ContentList[i].Name} ");
                    Console.Write($"{content.ContentList[i].Size} ");
                    Console.Write($"{content.ContentList[i].DataCreate} ");
                    Console.WriteLine();
                }
                else {
                    Console.ResetColor();
                    Console.Write($"{content.ContentList[i].Name} ");
                    Console.Write($"{content.ContentList[i].Size} ");
                    Console.Write($"{content.ContentList[i].DataCreate} ");
                    Console.WriteLine();
                }
                

            }
            
         }

        public static ContentModel Select(ListContent content)
        {
            //if (b > content.ContentList.Count&& ConsoleKey.DownArrow == Console.ReadKey().Key)
            //{
            //    b = 0;
            //    return content.ContentList[b];
               
            //}
           if (ConsoleKey.DownArrow == Console.ReadKey().Key)
            {
               
                return content.ContentList[++b];
            }
            else if (ConsoleKey.UpArrow == Console.ReadKey().Key)
            {
                
                return content.ContentList[--b];
            }

            return content.ContentList[b];
        }
        static void Main(string[] args)
        {
            
            ListContent content = new ListContent();
            content.Open(@"C:\Users\GANS\Desktop\Catalog");
            //var a = content.ContentList[3];
            // content.Delete(a);
            Print(content);
            while (true)
            {
                Print(content, Select(content));
            }






            //Console.WriteLine(content.GetSize());

        }
    }
}
