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

    }
}
