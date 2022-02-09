using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademicOnlineLibrart
{

    public class Instructor : Worker
    {
        public Instructor(string name, string familyname, string post) : base(name, familyname, post)
        {

        }
        public List<Professor> Professors { get; set; } = new List<Professor>();
        public void DetCourses(string masterName, string courseName)
        {

            var professeor = Professors.Where(a => a.Name == (masterName)).FirstOrDefault();
            Course course =Head.AllCourses.Where(a => a.CourseName ==(courseName)).FirstOrDefault();
            professeor.ProfessorCourses.Add(course);
        }
        
        public void ShowCourses_Masters()
        {
            foreach (Professor m in Professors)
            {
                foreach (Course c in m.ProfessorCourses)
                {
                    Console.WriteLine(m.Name + " course is: " + c.CourseName);
                }

            }
        }
    }
}

