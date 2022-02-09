using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicOnlineLibrart
{
    public class Worker
    {

        public string Name { get; set; }
        public string Familyname { get; set; }
        public long Id { get; set; }
        public string Post { get; set; }

        public Worker(string name, string familyname, string post)
        {
            this.Name = name;
            this.Familyname = familyname;
            this.Post = post;
        }
        public static List<Worker> WorkersList { get; set; } = new List<Worker>();
    }
}
