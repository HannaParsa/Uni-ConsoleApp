using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademicOnlineLibrart
{
    public class Student : Worker
    {

        public static int NUMBER = 0;
        public int Number { get; set; }
        public double Average { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Course> PassCourses = new List<Course>();
        public List<Course> NotPassCourses = new List<Course>();

        public Student(string name, string familyname, string post) : base(name, familyname, post)
        {
            Number = ++NUMBER;
        }

        public void GetPassCourses()
        {
            var pass = from c in Courses where c.Point >= 10 select c;
            foreach (var v in pass)
            {
                PassCourses.Add(v);
            }
            foreach (Course c in PassCourses)
            {
                Console.WriteLine("passes course is : " + c.CourseName);
            }
        }
        public void GetNotPassCourses()
        {
            var notPass = from c in Courses where c.Point < 10 select c;
            foreach (var v in notPass)
            {
                NotPassCourses.Add(v);
            }
            foreach (Course c in NotPassCourses)
            {
                Console.WriteLine("failed course is: " + c.CourseName);
            }
        }
        public void AverageCounter()

        {
            double sum = 0;
            int count = 0;
            foreach (Course c in Courses)
            {
                sum += c.Point;
                count++;
            }
                Average = Convert.ToDouble(sum / count);
                Console.WriteLine("has no grades");
            Console.WriteLine("average is : " + Average);
        }


    }
}
