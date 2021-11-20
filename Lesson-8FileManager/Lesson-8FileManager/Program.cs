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
        static void Main(string[] args)
        {
            ListContent content = new ListContent();
            var b = Directory.EnumerateFileSystemEntries(@"C:\Users\GANS\Desktop\Catalog");
            foreach(var a in b)
            {
                content.ContentList.Add(new ContentModel(a));
            }
            content.ContentList.RemoveAt(4);
            foreach (var c in content.ContentList)
            {
                Console.WriteLine(c.Name);
                Console.WriteLine(c.Size);
                Console.WriteLine(c.DataCreate);
                Console.WriteLine();
            }

            //var Content = new Folder(@"C:\Users\GANS\Desktop\Catalog\Catalog4");

            //Console.WriteLine(Content.Name);
            //Console.WriteLine(Content.Size);
            //Console.WriteLine(Content.DataCreate);

        }
    }
}
