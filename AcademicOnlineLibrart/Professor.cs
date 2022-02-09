using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademicOnlineLibrart
{
    
        public class Professor : Worker
        {
            public Professor(string name, string familyname, string post) : base(name, familyname, post)
            {

            }
            public List<Student> ProfessorStudents { get; set; } = new List<Student>();
            public List<Course> ProfessorCourses { get; set; } = new List<Course>();

            public void AddGrade(int grade, Student studentt, string courseName)
            {

            var student = ProfessorStudents.Where(a => a.Name == studentt.Name).FirstOrDefault();
            var course = ProfessorCourses.Where(s => s.CourseName == courseName).FirstOrDefault();
            course.Point = grade;
            Console.WriteLine(student.Name + " grade is: " + course.Point);
            }

        }
    }
