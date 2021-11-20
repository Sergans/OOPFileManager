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
            content.Open(@"C:\Users\GANS\Desktop\Catalog");
            // var a = content.ContentList[4];
            // content.Delete(a);
            
            foreach (var c in content.ContentList)
            {
                Console.WriteLine(c.Name);
                Console.WriteLine(c.Size);
                Console.WriteLine(c.DataCreate);
                Console.WriteLine();
            }
           Console.WriteLine(content.GetSize());

        }
    }
}
