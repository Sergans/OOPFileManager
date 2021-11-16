using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8FileManager
{
    public interface IOperation
    {
        void Create();
        void Get();
        void Update();
        void Delete();
    }
}
