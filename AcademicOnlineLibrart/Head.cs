using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademicOnlineLibrart
{
    public class Head
    {
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string Post { get; set; }
        public long Id { get; set; }
        public static List<Course> AllCourses { get; set; } = new List<Course>();

        public static long ID = 0;
        
        public Head(string name, string familyname, string post)
        {
            this.Name = name;
            this.FamilyName = familyname;
            this.Post = post;
            Id = 0;
        }

        public void DelWorker(int id)
        {
            id--;
            Worker.WorkersList.RemoveAt(id);
            id++;
            Console.WriteLine("worker id: "+ id + " deleted");
           
        }
        public void AddWorker(string name, string familyName, string post)
        {
            switch (post)
            {
                case "student":
                    Student stu = new Student(name, familyName, post);
                    stu.Id = ++ID;
                    Worker.WorkersList.Add(stu);
                    break;
                case "master":
                    Professor mst = new Professor(name, familyName, post);
                    mst.Id = ++ID;
                    Worker.WorkersList.Add(mst);
                    break;
                case "instructor":
                    Instructor inst = new Instructor(name, familyName, post);
                    inst.Id = ++ID;
                    Worker.WorkersList.Add(inst);
                    break;
            }
        }
        public void ShowWorkers()
        {
            if (Worker.WorkersList.Count == 0)
                Console.WriteLine("no one is employed");
            foreach (Worker w in Worker.WorkersList)
            {
                Console.WriteLine("id: "+w.Id + " " + w.Name + " " + w.Familyname + " post: " + w.Post);
            }
        }
        public void GetDetail(int id) 
        {
            try {
                id--;
                if (id < 0 || id > Worker.WorkersList.Count)
                    throw new ArgumentOutOfRangeException("invalid number");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("invalid number");
                return;
            }
            
                string post = Worker.WorkersList[id].Post;
            switch (post)
            {
                case "student":
                    Student stu = (Student)(Worker.WorkersList[id]);
                    Console.WriteLine(stu.Number + " " + post);
                    break;
                case "master":
                    Professor mast = (Professor)Worker.WorkersList[id];
                    Console.WriteLine(mast.Id + " " + post);
                    break;
                case "instructor":
                    Instructor inst = (Instructor)Worker.WorkersList[id];
                    Console.WriteLine(inst.Id + " " + post);
                    break;
            }
        }
        public void DetCourse(string nameInstructor, string masterName, string courseName)
        {
            
            
                var instructor = (Instructor)Worker.WorkersList.Where(a => a.Name == (nameInstructor)).FirstOrDefault();
                var professor = (Professor)Worker.WorkersList.Where(v => v.Name == (masterName)).FirstOrDefault();
                instructor.Professors.Add(professor);
                instructor.DetCourses(masterName, courseName);
           
        }
        public void Show_master_courses(string instructorName)
        {
            foreach (Worker w in Worker.WorkersList)
            {
                if (w.Name == instructorName)
                {
                    Instructor ins = (Instructor)w;
                    ins.ShowCourses_Masters();
                }
            }
        }

        public void ChooseCourse(string studentName, string masterName, string courseName)
        {
            var professor = (Professor)Worker.WorkersList.Where(a => a.Name == (masterName)).FirstOrDefault();
            var student = (Student)Worker.WorkersList.Where(c => c.Name == (studentName)).FirstOrDefault();
            professor.ProfessorStudents.Add(student);
            var course = AllCourses.Where(v => v.CourseName == (courseName)).FirstOrDefault();
            student.Courses.Add(course);
            Console.WriteLine(student.Name + " chose: "+ courseName);

        }

        public void DetGrade(string masterName, int grade, string studentName, string courseName)
        {
            var professor = (Professor)Worker.WorkersList.Where(a => a.Name == (masterName)).FirstOrDefault();
            var student = (Student)Worker.WorkersList.Where(c => c.Name == (studentName)).FirstOrDefault();
            professor.AddGrade(grade, student, courseName);

        }
        public void StudentDetails(string studentName)
        {
            foreach (Worker w in Worker.WorkersList)
            {
                if (w.Name == studentName)
                {
                    Student stu = (Student)w;
                    Console.WriteLine("student " + stu.Name + " number is : " + stu.Number);
                    stu.GetPassCourses();
                    stu.GetNotPassCourses();
                    stu.AverageCounter();
                }
            }
        }
        public void AddCourse(Course course)
        {
            AllCourses.Add(course);
            Console.WriteLine(course.CourseName + " added ");
        }
        //new 
        public void updateCourse(string current , string updated)
        {
            foreach(Course c in AllCourses)
            {
                if(c.CourseName == current)
                {
                    c.CourseName = updated;
                }

            }
            Console.WriteLine(current + " updated to: "+updated);

        }
    }

}
