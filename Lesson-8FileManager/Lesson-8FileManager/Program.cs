using System;
using System.IO;
using Lesson_8FileManager;
using Lesson_8FileManager.Files;
using System.Collections.Generic;

namespace Lesson_8FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
           // var a=Directory.EnumerateFileSystemEntries(@"C:\Users\GANS\Desktop\Catalog\Catalog3");
            var Content = new Folder(@"C:\Users\GANS\Desktop\Catalog\Catalog3");
            //foreach(var s in a)
            //{
            //    Content.ListContentModel.Add(new FileModel(s));
            //}
            Console.WriteLine();
            
        }
    }
}
