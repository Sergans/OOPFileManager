using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Lesson_8FileManager.Files;

namespace Lesson_8FileManager.Content
{
    public class ContentOperation
    {
        public string RootPath { get; set; }
        public List<IContent> contents { get; set; }
                
        public ContentOperation Open(string path)
        {
            ListContent<IContent> content = new ListContent<IContent>();

            var list = Directory.EnumerateFileSystemEntries(path);
            RootPath = path;
            contents = new List<IContent>();
            foreach (var a in list)
            {
                if (Directory.Exists(a))
                {
                    content.ContentList.Add(new Folder(a));
                }
                else if (File.Exists(a))
                {
                    content.ContentList.Add(new FileModel(a));
                }
            
            }
            contents = content.ContentList;

            return this;

        }
        public long GetSize()
        {
            long sum = 0;
            foreach (var a in contents)
            {
                sum += a.GetSize();
            }
            return sum;
        }
        public void Delete(IContent item)
        {
            item.Delete();
            contents.Remove(item);
            
        }
        public void Rename(IContent item, string name)
        {
            item.Rename(RootPath,name); 
        }
        public void CreateFolder(string new_path)
        {
            Directory.CreateDirectory(new_path);
            contents.Add(new Folder(new_path));
        }
        public void CreateFileTxt(string new_path)
        {
            File.Create(new_path);
            contents.Add(new FileModel(new_path));
            

        }
        
    }
}