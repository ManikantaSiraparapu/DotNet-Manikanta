using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinQ
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
    }
    class Enroll
    {
        public string Course { get; set; }
        public int StudentId { get; set; }
    }
    internal class demo6
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { StudentId = 1, Name = "Mani" },
                new Student() { StudentId = 2, Name = "Sai" },
                new Student() { StudentId = 3, Name = "Murali" }
            };
            List<Enroll> enrolls = new List<Enroll>()
            {
                new Enroll() { StudentId = 1, Course = ".Net" },
                new Enroll() { StudentId = 2, Course = "Java" },
                new Enroll() { StudentId = 3, Course = "Python" },
                new Enroll() { StudentId = 1, Course = "C" },
                new Enroll() { StudentId = 2, Course = "Azure" },
                new Enroll() { StudentId = 3, Course = "Angular" },
            };
            //using join
            var r = from s in students
                    join e in enrolls
                    on s.StudentId equals e.StudentId
                    select new { s.StudentId, s.Name, e.Course };
            foreach (var i in r)
            {
                Console.WriteLine($"Id: {i.StudentId} Name:{i.Name} Courses: {i.Course}");
            }
            var r1 = from s in students
                     where enrolls.Where(e => e.Course == "Angular").Select(e => e.StudentId).Contains(s.StudentId)
                     select new { s.Name };
            foreach (var i in r1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
