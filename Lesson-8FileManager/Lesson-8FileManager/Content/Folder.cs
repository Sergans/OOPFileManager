using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_8FileManager.Files
{
    public class Folder
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public DateTime DataCreate { get; set; }
        public List<FileModel> ListContentModel = new List<FileModel>();

        public Folder(string path)
        {
            Path = path;
            DirectoryInfo directory = new DirectoryInfo(Path);
            Name = directory.Name;
            DataCreate = directory.CreationTime;
            Size = file.Length;
            

        }
        public FileModel Delete(FileModel content)
        {
            for(int i = 0; i < ListContentModel.Count; i++)
            {
                if (ListContentModel[i] == content)
                {
                    ListContentModel.Remove(content.Delete());
                    return content;
                }
            }
            return content;
        }
        

       
    }
}
