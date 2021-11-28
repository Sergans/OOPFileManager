using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_8FileManager.Files;
using System.IO;

namespace Lesson_8FileManager.Content
{
   public class ListContent<T>
   {
      public string RootPath { get; set; }
      public List<T> ContentList = new List<T>();
       
      public ListContent<T> Open(string path)
        {
            var list = Directory.EnumerateFileSystemEntries(path);
            RootPath = path;
                //ContentList = new List<IContent>();
                if (Directory.Exists(path))
                {

                    foreach (var a in list)
                    {
                        ContentList.Add(new Folder(a));
                    }
                }
                else if (File.Exists(path))
                {
                    Console.WriteLine(File.ReadAllText(path));
                }
                return this;
            
             
        }
      public long GetSize()
        {
            long sum = 0;
            foreach(var a in ContentList)
            {
                sum += a.Size;
            }
            return sum;  
        }
      public void Delete(ContentModel item)
      {
          for(int i = 0; i < ContentList.Count; i++)
          {
            if (ContentList[i] == item)
            {
              if (Directory.Exists(ContentList[i].Path))
              {
                Directory.Delete(ContentList[i].Path,true);
                ContentList.Remove(item);
              }
              else if (File.Exists(ContentList[i].Path))
              {
                File.Delete(ContentList[i].Path);
                ContentList.Remove(item);
              }
                  
            }
                
          }
      }
        public void Rename(ContentModel item,string path)
        {

            for (int i = 0; i < ContentList.Count; i++)
            {
                if (ContentList[i] == item)
                {
                    if (Directory.Exists(ContentList[i].Path))
                    {
                        ContentList[i].Name = path;
                        string NewPath = Path.Combine(RootPath, path);
                        Directory.Move(ContentList[i].Path,NewPath);
                        
                    }
                    else if (File.Exists(ContentList[i].Path))
                    {
                        var extension = new FileInfo(ContentList[i].Path);
                        ContentList[i].Name = path+extension.Extension;
                        string NewPath = Path.Combine(RootPath, ContentList[i].Name);
                        File.Move(ContentList[i].Path, NewPath);
                        
                        
                    }

                }

            }

        }
   }
}
