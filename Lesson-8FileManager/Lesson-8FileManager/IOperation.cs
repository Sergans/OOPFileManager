using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_8FileManager.Files;

namespace Lesson_8FileManager
{
    public interface IOperation
    {
        //void Create();
        //void Get();
        //void Update();
        FileModel Delete();
       // string Name();
        //long GetSize();


    }
}
