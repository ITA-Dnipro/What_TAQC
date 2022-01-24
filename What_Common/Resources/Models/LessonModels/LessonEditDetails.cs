using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_PageObject.LessonPage.Models
{
    public class LessonEditDetails
    {
        public string LessonTheme { get; set; }
        public string GroupName { get; set; }
        public string LessonsDateTime { get; set; }
        public List<string> Students { get; set; }
    }
}
