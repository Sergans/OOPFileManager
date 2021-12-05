using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_8FileManager.Content;
using System.IO;


namespace Lesson_8FileManager.SelectOperation
{
   public class SelectCommand
   {
        int b=0;
        public IContent Select(ContentOperation content,ConsoleKey _button)
        {
            if (ConsoleKey.LeftArrow == _button)
            {
                content.Open(Directory.GetParent(content.RootPath).ToString());
                b = 0;
            }
            if (ConsoleKey.F3 == _button)//создать папку
            {
                string NewContent = Console.ReadLine();
                string NewPath;
                NewPath = Path.Combine(content.RootPath, NewContent);
                content.CreateFolder(NewPath);
                b = 0;
            }
            if (ConsoleKey.F4 == _button) //создать текстовый файл
            {
                string NewContent = Console.ReadLine();
                string NewPath;
                NewPath = Path.Combine(content.RootPath, NewContent + ".txt");
                content.CreateFileTxt(NewPath);

                b = 0;
            }
            if (content.contents.Count != 0)
            {
                if (ConsoleKey.DownArrow == _button && b < (content.contents.Count - 1))
                {
                    return content.contents[++b];
                }
                else if (ConsoleKey.UpArrow == _button && b <= content.contents.Count - 1 && b > 0)
                {
                    return content.contents[--b];
                }
                else if (ConsoleKey.Delete == _button)
                {
                    content.Delete(content.contents[b]);
                    if (content.contents.Count == 0)
                    {
                        b = 0;
                        return null;
                    }
                    b = 0;
                }
                else if (ConsoleKey.RightArrow == _button)
                {
                    content.Open(content.contents[b].GetPath());
                    if (content.contents.Count == 0)
                    {
                        b = 0;
                        return null;
                    }
                    b = 0;
                }
                else if (ConsoleKey.F2 == _button)
                {
                    string NewFolder = Console.ReadLine();
                    content.Rename(content.contents[b], NewFolder);
                    b = 0;
                }

            }
            else
            {
                b = 0;
                return null;
            }
            return content.contents[b];
        }
   }
}
