using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_8FileManager.Files
{
    public class Folder:IContent
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public DateTime DataCreate { get; set; }
        public List<FileModel> ListFileModel = new List<FileModel>();
        public List<Folder> ListFolderModel = new List<Folder>();
        public Folder()
        {

        }
        public Folder(string path)
        {
            Path = path;
            DirectoryInfo directory = new DirectoryInfo(Path);
            Name = directory.Name;
            DataCreate = directory.CreationTime;
            AddFile();
            AddFolder();
            Size = GetSize();

        }
        public long GetSize()
        { long sum = 0;
            foreach(var file in ListFileModel)
            {
                sum +=file.Size;
            }
            foreach (var folder in ListFolderModel)
            {
                sum += folder.Size;
            }
            return sum;
        }
        public void AddFile()
        {
            var a = Directory.GetFiles(Path);
            foreach(var file in a)
            {
                ListFileModel.Add(new FileModel(file));
            }
        }
        public void AddFolder()
        {
            var a = Directory.GetDirectories(Path);
            foreach (var directory in a)
            {
                ListFolderModel.Add(new Folder(directory));
            }
        }
       
    }
}
