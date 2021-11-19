using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_8FileManager.Files
{
    public class FileModel
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public DateTime DataCreate { get; set; }
        
        public FileModel(string path)
        {
            Path = path;
            FileInfo file = new FileInfo(Path);
            Name = file.Name;
            Size = file.Length;
            DataCreate = file.CreationTime;

        }

        //public string Name()
        //{
        //    if (Directory.Exists(Path))
        //    {
        //        DirectoryInfo directory = new DirectoryInfo(Path);
        //        return directory.Name;
        //    }
        //    else
        //    {
        //        FileInfo file = new FileInfo(Path);
        //        return file.Name;
        //    }
        //}
        public long GetSize()
        {
            if (Directory.Exists(Path))
            {
                var a = Directory.GetFiles(Path);
                for(int i = 0; i < a.Length; i++)
                {
                    GetSize();
                }
                return 0;// добавить логику подсчета размера
            }
            else if (File.Exists(Path))
            {
                FileInfo file = new FileInfo(Path);
                return file.Length;
            }
            return 0;
        }
        public FileModel Delete()
        {
            if (Directory.Exists(Path))
            {
                DirectoryInfo directory = new DirectoryInfo(Path);
                directory.Delete(true);
                return this;
            }
            else
            {
                FileInfo file = new FileInfo(Path);
                file.Delete();
                return this;
            }
            // return this;
        }
    
       
    }
}
