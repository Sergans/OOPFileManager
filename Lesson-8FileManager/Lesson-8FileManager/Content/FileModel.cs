using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_8FileManager.Files
{
    public class FileModel:IContent
    {
        public string FilePath { get; set; }
        private string Name;
        public long Size { get; set; }
        public DateTime DataCreate { get; set; }
        public string Extens { get; set; }
        public FileModel(string path)
        {   
            FilePath = path;
            FileInfo file = new FileInfo(FilePath);
            Name = file.Name;
            Size = file.Length;
            DataCreate = file.CreationTime;
            Extens = file.Extension;

        }

        public long GetSize()
        {
            return Size;
        }
        public void Delete()
        {
            try
            {
                File.Delete(FilePath);
            }
            catch
            {
                Console.WriteLine("Падаем");
               
            }
            
        }
        public string GetName()
        {
            return Name;
        }
        public DateTime GetDate()
        {
            return DataCreate;
        }
        public void Rename(string root_path,string name)
        {
            
            string NewPath = Path.Combine(root_path, name+Extens);
            File.Move(FilePath, NewPath);
            this.Name = name + Extens;
        }
        public string GetPath()
        {
            return FilePath;
        }
        public IContent Copy(string copy_path,string to_path,string file_name)
        {
            string new_file = Path.Combine(to_path, file_name + Extens);
            File.Copy(FilePath, new_file);
            return(new FileModel(new_file));
        }

    }
}
