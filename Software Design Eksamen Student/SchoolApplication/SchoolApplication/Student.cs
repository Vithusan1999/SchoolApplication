using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication
{
    public class Student
    {
        public string Name { get; set; }
        public int YearBorn { get; set; }
        public string Subject { get; set; }

        public Student()
        {
            Name = "";
            YearBorn = 0;
            Subject = "";
        }

        public Student(string Name, int YearBorn, string Subject)
        {
            Name = Name;
            YearBorn = YearBorn;
            Subject = Subject;
        }

    }
}
