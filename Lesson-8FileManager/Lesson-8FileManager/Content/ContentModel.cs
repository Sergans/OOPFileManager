using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_8FileManager.Files
{
   public class ContentModel:IOperation
    {
        public string Path { get; set;}
        public string Name()
        {
            if (Directory.Exists(Path))
            {
                DirectoryInfo directory = new DirectoryInfo(Path);
                return directory.Name;
            }
            else 
            {
                FileInfo file = new FileInfo(Path);
                return file.Name; 
            }
        }
        public long GetSize()
        {
            if (Directory.Exists(Path))
            {
                return 0;// добавить логику подсчета размера
            }
           else if(File.Exists(Path))
            {
                FileInfo file = new FileInfo(Path);
                return file.Length;
            }
            return 0;
        }
        public ContentModel Delete()
        {
            if (Directory.Exists(Path))
            {
               // добавить логику удаления
            }
            else
            {
                FileInfo file = new FileInfo(Path);
                file.Delete();
                return this;
            }
            return this;
        }

       
    }
}
