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
            // FileInfo a = new FileInfo();
            // File.Delete(@"C:\Users\GANS\Desktop\Catalog\2.txt");
            //Directory.Delete(@"C:\Users\GANS\Desktop\Catalog\Catalog4");
            //IEnumerable<string> a=Directory.(@"C:\Users\GANS\Desktop\Catalog");
            DirectoryInfo a = new DirectoryInfo(@"C:\Users\GANS\Desktop\Catalog");
            foreach(var z in a.GetDirectories())
            {
                Console.WriteLine(z.Name);
                foreach(var v in z.GetDirectories())
                {
                    Console.WriteLine(v.Name);
                    if (v.Name == "11")
                    {
                        v.Delete();
                    }
                   
                }
                
            }

            
            

            
        }
    }
}
