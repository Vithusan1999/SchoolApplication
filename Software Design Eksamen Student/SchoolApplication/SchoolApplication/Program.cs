using System;

namespace SchoolApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling out the properties of student

            Student student = new Student();

            //Calling out the properties of teacher

            Teacher teacher = new Teacher();


            //StudentList 

            StudentList list = new StudentList();

            //TeacherList

            TeacherList list2 = new TeacherList();


            //Console menu

            Console.WriteLine("Hi and welcome to the school application, where you can add youre students and youre teacher. " +
                "This program is meant for the school admistration. In this application you can add name, year born and the subject. " +
                "You have to type in the number for the action you want. You have to do that twice then you can fill in the information" +
                "or see the student or the teacher list");
            Console.WriteLine("1 Add your student"); 
            Console.WriteLine("2 Add your teacher");
            Console.WriteLine("3 Show student"); 
            Console.WriteLine("4 show teacher");
            Console.WriteLine("0 close");

            int action = chooseAction(); 

            //While loop that the user can do different task in the console 

            while (action != 0)
            {
                action = chooseAction();

                switch (action)
                {
                    //Case 1 is to add the students. I bring the properties from student class and i use the userinput and put it in the list

                    case 1:
                        Console.WriteLine("You have chosen to add a student. Implement the student name, year born and subject");

                        student.Name = Console.ReadLine();
                        student.YearBorn = int.Parse(Console.ReadLine());
                        student.Subject = Console.ReadLine();   


                        list.Students.Add(student);

                       


                        break; 

                        //Case 2 I do the same as i did in case 1

                        case 2:
                        Console.WriteLine("You have chosen to add a teacher. Implement the teacher name, year born, subject and their salary"); 

                        teacher.Name = Console.ReadLine();
                        teacher.YearBorn = int.Parse(Console.ReadLine()); 
                        teacher.Subject = Console.ReadLine();
                        teacher.Salary = Console.ReadLine();

                        list2.Teachers.Add(teacher);    

                       

                        break;

                        //List out the students you have added in the list

                    case 3:
                        Console.WriteLine("List of the students");

                        printStudent(list);


                        break;

                        //List out the teacher you have added in the list

                    case 4: 
                        Console.WriteLine("List of the teachers");

                        printTeacher(list2);

                        break; 
                            
                       

                }

                action = chooseAction();    
            }

           
        }
        //Takes in the userinput to navigate in the console and do the different cases in switch

        private static int chooseAction()
        {
            int insertValue = 0;

            insertValue = int .Parse(Console.ReadLine());    
            return insertValue;  
        }

        //Prints out the students from the list

        private static void printStudent(StudentList list)
        {
           foreach(Student student in list.Students)
                Console.WriteLine(student.Name + student.YearBorn + student.Subject);
        }

        //Prints out the teachers from the list

        private static void printTeacher(TeacherList list)
        {
            foreach (Teacher teacher in list.Teachers)
                Console.WriteLine(teacher.Name + teacher.YearBorn + teacher.Subject + teacher.Salary);
        }
    }
}
