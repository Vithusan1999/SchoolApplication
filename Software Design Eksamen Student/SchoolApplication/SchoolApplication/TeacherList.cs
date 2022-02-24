using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication
{
    public class TeacherList
    {

        public List<Teacher> Teachers { get; set; }

        public TeacherList()
        {

            Teachers = new List<Teacher>();
        }
    }
}
