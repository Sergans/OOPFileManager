using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8FileManager.Files
{
    public class Content
    {
        public List<ContentModel> ListContentModel = new List<ContentModel>();
        public ContentModel Delete(ContentModel content)
        {
            for(int i = 0; i < ListContentModel.Count; i++)
            {
                if (ListContentModel[i] == content)
                {
                    ListContentModel.Remove(content.Delete());
                    return content;
                }
            }
            return content;
        }

       
    }
}
