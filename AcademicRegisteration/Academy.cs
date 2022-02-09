using System;
using AcademicOnlineLibrart;

namespace AcademicRegisteration
{
    class Academy
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter the name and familyName of head: ");
            Head head = new Head(Console.ReadLine(), Console.ReadLine(), "head");
            while (true)
            {
                Console.WriteLine("1) add student ");
                Console.WriteLine("2) add profosser ");
                Console.WriteLine("3) add instructor ");
                Console.WriteLine("4) add course ");
                Console.WriteLine("5) determine course ");
                Console.WriteLine("6) see masters and courses ");
                Console.WriteLine("7) choose course");
                Console.WriteLine("8) determine grade ");
                Console.WriteLine("9) get student detail ");
                Console.WriteLine("10) get worker ID ");
                Console.WriteLine("11) get workers list ");
                Console.WriteLine("12) delete worker ");
                Console.WriteLine("13) update course ");
                Console.WriteLine("0) exite ");
                Console.WriteLine("enter number :");
                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        string name = Console.ReadLine();
                        string familyName = Console.ReadLine();
                        head.AddWorker(name, familyName, "student");
                        break;
                    case 2:
                        string namee = Console.ReadLine();
                        string familyNamee = Console.ReadLine();
                        head.AddWorker(namee, familyNamee, "master");
                        break;
                    case 3:
                        string Name = Console.ReadLine();
                        string FamilyName = Console.ReadLine();
                        head.AddWorker(Name, FamilyName, "instructor");
                        break;
                    case 4:
                        string courseName = Console.ReadLine();
                        int unit = Convert.ToInt32(Console.ReadLine());
                        Course c = new Course(courseName, unit);
                        head.AddCourse(c);
                        break;
                    case 5:
                        string instructorName = Console.ReadLine();
                        string masterName = Console.ReadLine();
                        string CourseName = Console.ReadLine();
                        head.DetCourse(instructorName, masterName, CourseName);
                        break;
                    case 6:
                        string InstructoreName = Console.ReadLine();
                        head.Show_master_courses(InstructoreName);
                        break;
                    case 7:
                        string StudentName = Console.ReadLine();
                        string Mastername = Console.ReadLine();
                        string Coursename = Console.ReadLine();
                        head.ChooseCourse(StudentName, Mastername, Coursename);
                        break;
                    case 8:
                        string Masternamee = Console.ReadLine();
                        int grade = Convert.ToInt32(Console.ReadLine());
                        string nameStudent = Console.ReadLine();
                        string nameCourse = Console.ReadLine();
                        head.DetGrade(Masternamee, grade, nameStudent, nameCourse);
                        break;
                    case 9:
                        string NameStudent = Console.ReadLine();
                        head.StudentDetails(NameStudent);
                        break;
                    case 10:
                        int Id = Convert.ToInt32(Console.ReadLine());
                        head.GetDetail(Id);
                        break;
                    case 11:
                        head.ShowWorkers();
                        break;
                    case 12:
                        int ID = Convert.ToInt32(Console.ReadLine());
                        head.DelWorker(ID);
                        break;
                    case 13:
                        string currentCourse = Console.ReadLine();
                        string updatedCourse = Console.ReadLine();
                        head.updateCourse(currentCourse,updatedCourse);
                        break;
                    case 0:
                        return;

                }
            }
        }
    }
}
