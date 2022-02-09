using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademicOnlineLibrart
{
    public class Course
    {
        public long Id { get; set; }
        public Course(string courseName, int unit)
        {
            this.CourseName = courseName;
            this.Unit = unit;
        }
        public string CourseName { get; set; }
        public string Professor { get; set; }
        public int Unit { get; set; }
        public int Point { get; set; }
    }
}
