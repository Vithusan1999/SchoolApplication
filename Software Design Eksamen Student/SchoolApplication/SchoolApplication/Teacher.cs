using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication
{
    public class Teacher
    {
        public string Name { get; set; }
        public int YearBorn { get; set; }
        public string Subject { get; set; }

        public string Salary { get; set; } 

        public Teacher()
        {
            Name = "";
            YearBorn = 0;
            Subject = "";
            Salary = ""; 
        }

        public Teacher(string Name, int YearBorn, string Subject, int Salary)
        {
            Name = Name;
            YearBorn = YearBorn;
            Subject = Subject;
            Salary = Salary;    
        }

    }
}
