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
        static int c = 0;
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

        public static ContentModel SelectUpDown(ListContent content)
        {
           var kl = Console.ReadKey().Key;
           if (ConsoleKey.DownArrow == kl&&b <(content.ContentList.Count-1))
            {
              return content.ContentList[++b];           
            }
            else if(ConsoleKey.UpArrow==kl && b <= content.ContentList.Count-1&&b>0)
            {
                return content.ContentList[--b];
            }
           else if (ConsoleKey.Delete == kl)
            {
                content.Delete(content.ContentList[b]);
                b = 0;
            }
           else if (ConsoleKey.RightArrow == kl)
            {
                content.Open(content.ContentList[b].Path);
                b = 0;
            }
            else if (ConsoleKey.LeftArrow == kl)
            {
                
              content.Open(Directory.GetParent(content.RootPath).ToString());
                b = 0; 
            }

            return content.ContentList[b];
        }
        static void Main(string[] args)
        {
            
            ListContent content = new ListContent();
            //content.Open(@"C:\Users\GANS\Desktop\Catalog");
            
            //var a = content.ContentList[3];
            // content.Delete(a);
            Print(content.Open(@"C:\Users\GANS\Desktop\Catalog"));
            //var a=Select(content);
            //content.Open(a.Path);
            //Console.WriteLine();
            while (true)
            {
                var c = SelectUpDown(content);
                Print(content, c);
            }






            //Console.WriteLine(content.GetSize());

        }
    }
}
