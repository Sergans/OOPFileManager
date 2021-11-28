using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Lesson_8FileManager.Files;

namespace Lesson_8FileManager.Content
{
    public class ContentModel:Folder
    {
        //public ContentModel(string path) : base()
        //{
        //    Path = path;
        //    if (Directory.Exists(Path))
        //    {
        //        DirectoryInfo directory = new DirectoryInfo(Path);
        //        Name = directory.Name;
        //        DataCreate = directory.CreationTime;
        //        AddFile();
        //        AddFolder();
        //        Size = GetSize();
        //    }
        //   else if(File.Exists(Path))
        //    {
        //        FileInfo file = new FileInfo(Path);
        //        Name = file.Name;
        //        DataCreate = file.CreationTime;
        //        Size = file.Length;
        //   }
        //}
    }
}
