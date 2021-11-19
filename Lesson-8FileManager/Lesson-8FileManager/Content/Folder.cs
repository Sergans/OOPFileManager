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
            AddFile();
            Size = GetSize();



        }
        public long GetSize()
        { long sum = 0;
            foreach(var file in ListContentModel)
            {
                sum +=file.Size;
            }
            return sum;
        }
        public void AddFile()
        {
            var a = Directory.GetFiles(Path);
            foreach(var file in a)
            {
                ListContentModel.Add(new FileModel(file));
            }
            

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
