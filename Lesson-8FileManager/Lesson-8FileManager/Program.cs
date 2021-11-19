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
         var Content = new Folder(@"C:\Users\GANS\Desktop\Catalog");
            
         Console.WriteLine(Content.Name);
         Console.WriteLine(Content.Size);
         Console.WriteLine(Content.DataCreate);
        }
    }
}
