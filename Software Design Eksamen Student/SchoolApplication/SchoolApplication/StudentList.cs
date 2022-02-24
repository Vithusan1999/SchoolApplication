using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication
{
    public class StudentList
    {

        public List <Student> Students { get; set; }

        public StudentList()
        { 
        
            Students = new List<Student>();
        }
    }
}
