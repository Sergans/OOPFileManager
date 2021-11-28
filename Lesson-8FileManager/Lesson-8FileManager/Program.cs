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

        public static IContent SelectUpDown(ContentOperation content)
        {
            var kl = Console.ReadKey().Key;
            if (ConsoleKey.LeftArrow == kl)
            {
               content.Open(Directory.GetParent(content.RootPath).ToString());
                b = 0;
            }
            //    if(ConsoleKey.F1 == kl)
            //    {
            //        Console.Clear();
            //        string NewFolder = Console.ReadLine();
            //        string NewPath;
            //        if (NewFolder == "")
            //        {
            //            NewFolder = "Новая папка";
            //            NewPath = Path.Combine(content.RootPath, NewFolder);
            //            if (Directory.Exists(NewPath))
            //            {
            //                Console.Clear();
            //                NewFolder = NewFolder + 1;
            //                NewPath = Path.Combine(content.RootPath, NewFolder);
            //                Directory.CreateDirectory(NewPath);
            //                content.Open(NewPath);
            //                content.Open(Directory.GetParent(content.RootPath).ToString());
            //            }
            //            else
            //            {
            //                Directory.CreateDirectory(NewPath);
            //                content.Open(NewPath);
            //                content.Open(Directory.GetParent(content.RootPath).ToString());
            //            }

            //        }
            //        else
            //        {
            //            NewPath = Path.Combine(content.RootPath, NewFolder);
            //            if (Directory.Exists(NewPath))
            //            {
            //                Console.Clear();
            //                NewFolder = NewFolder + 1;
            //                NewPath = Path.Combine(content.RootPath, NewFolder);
            //                Directory.CreateDirectory(NewPath);
            //                content.Open(NewPath);
            //                content.Open(Directory.GetParent(content.RootPath).ToString());

            //            }
            //            else
            //            {
            //                Directory.CreateDirectory(NewPath);
            //                content.Open(NewPath);
            //                content.Open(Directory.GetParent(content.RootPath).ToString());
            //            }

            //        }

            //    }
            if (content.contents.Count != 0)
            {
                if (ConsoleKey.DownArrow == kl && b < (content.contents.Count - 1))
                {
                    return content.contents[++b];
                }
                else if (ConsoleKey.UpArrow == kl && b <= content.contents.Count - 1 && b > 0)
                {
                    return content.contents[--b];
                }
                else if (ConsoleKey.Delete == kl)
                {
                    content.Delete(content.contents[b]);
                    if (content.contents.Count == 0)
                    {
                        b = 0;
                        return null;
                    }
                    b = 0;
                }
                else if (ConsoleKey.RightArrow == kl)
                {
                    content.Open(content.contents[b].GetPath());
                    if (content.contents.Count == 0)
                    {
                        b = 0;
                        return null;
                    }
                    b = 0;
                }
                else if (ConsoleKey.F2 == kl)
                {
                    string NewFolder = Console.ReadLine();
                    content.Rename(content.contents[b], NewFolder);
                    b = 0;
                }
                //else if (ConsoleKey.F3 == kl)
                //{
                //    string NewFolder = Console.ReadLine();
                //    string NewPath;
                //    NewPath = Path.Combine(content.RootPath, NewFolder);
                //    FileInfo s = new FileInfo(NewPath);

                //    content.Open(NewPath);
                //    content.Open(Directory.GetParent(content.RootPath).ToString());
                //}
            }
            else
            {
                b = 0;
                return null;
            }

            return content.contents[b];
        }
        static void Main(string[] args)
        {
            
            ContentOperation content = new ContentOperation();
            //content.Open(@"C:\Users\GANS\Desktop\Catalog\");
            //var a = content.contents[4];
            // content.Delete(a);
           // content.Rename(a, "Catalog40");
           // content.ContentList.Add(new Folder(@"C:\Users\GANS\Desktop\Catalog\"));
            Print(content.Open(@"C:\Users\GANS\Desktop\Catalog\"));
            while (true)
            {
                var c = SelectUpDown(content);
                Print(content, c);
            }

        }
    }
}
