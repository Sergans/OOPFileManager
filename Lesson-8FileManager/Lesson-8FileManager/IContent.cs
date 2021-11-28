using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_8FileManager.Files;

namespace Lesson_8FileManager
{
    public interface IContent
    {
        //void Create();
        //void Get();
        //void Update();
        void Delete();
        string GetName();
        long GetSize();
        DateTime GetDate();
        void Rename(string root_path,string name);
        string GetPath();
        



    }
}
