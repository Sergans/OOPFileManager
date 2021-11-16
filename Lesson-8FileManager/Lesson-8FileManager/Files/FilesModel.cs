using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8FileManager.Files
{
   public class FilesModel
    {
        public string Path { get; set;}
        public string Print()
        {
            return Path;
        }
    }
}
