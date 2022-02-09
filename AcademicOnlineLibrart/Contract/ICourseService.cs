using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicOnlineLibrart.Contract
{
    internal interface ICourseService
    {
        void AddCourse(Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(long id);
        List<Course> GetAllCourses();
        Course GetAllCourses(long id);

    }
}
