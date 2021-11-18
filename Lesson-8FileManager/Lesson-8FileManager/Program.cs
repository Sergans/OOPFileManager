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
            var a=Directory.EnumerateFileSystemEntries(@"C:\Users\GANS\Desktop\Catalog\");
            var Content = new Content();
            foreach(var s in a)
            {  
                Content.ListContentModel.Add(new ContentModel { Path=s});
            }
            
            foreach(var z in Content.Get())
            {
                Console.WriteLine(z);
                Console.WriteLine();

            }
            //var f = Content.ListContentModel[1];
            //Content.Delete(f);




        }
    }
}
