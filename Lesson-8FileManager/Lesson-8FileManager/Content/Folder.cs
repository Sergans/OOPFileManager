﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_8FileManager.Files
{
    public class Folder:IContent
    {
        public string FolderPath { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public DateTime DataCreate { get; set; }
        public List<FileModel> ListFileModel = new List<FileModel>();
        public List<Folder> ListFolderModel = new List<Folder>();
        
        public Folder(string path)
        {
            FolderPath = path;
            DirectoryInfo directory = new DirectoryInfo(FolderPath);
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
            try
            {
                var a = Directory.GetFiles(FolderPath);
                foreach (var file in a)
                {
                    ListFileModel.Add(new FileModel(file));
                }
            }
            catch
            {

            }
        }
        public void AddFolder()
        {
            try
            {
                var a = Directory.GetDirectories(FolderPath);
                foreach (var directory in a)
                {
                    ListFolderModel.Add(new Folder(directory));
                }

            }
            catch
            {

            }
        }
        public void Delete()
        {
            Directory.Delete(this.FolderPath, true);
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
            this.Name = name;
            string NewPath = Path.Combine(root_path, name);
            Directory.Move(FolderPath, NewPath);
            FolderPath = NewPath;
           
        }
        public string GetPath()
        {
            return FolderPath;
        }

        public IContent Copy(string root_path,string folder_name)
        {
            
            DirectoryInfo dir = new DirectoryInfo(root_path);
           
            string file1;
            string destFile;
            string NewPath = Path.Combine(dir.Parent.ToString(), folder_name);
            Directory.CreateDirectory(NewPath);
            
            string[] files = Directory.GetFiles(root_path);
            var folder = dir.GetDirectories();
            foreach(var f in folder)
            {
                string new_path = Path.Combine(NewPath, f.Name);
                Directory.CreateDirectory(new_path);
                Copy(f.FullName, f.Name);
            }
            foreach(var s in files)
            {
                file1 = Path.GetFileName(s);
                destFile = Path.Combine(NewPath, file1);
                File.Copy(s, destFile, true);
            }
            
            return (new Folder(NewPath));
        }
    }
}
