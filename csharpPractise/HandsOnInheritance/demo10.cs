using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    class Teacher
    {
        public String name;
        public String description;
        public Teacher(string name)
        {
            this.name = name;
        }
        //overriding to string method (to dtring method consists of virtual keyword
        //we can only override methods that has virtual keyword
        public override string ToString()
        {
            return "Good morning " + name;
        }
    }
    internal class demo10
    {
        static void Main()
        {
            Teacher teacher = new Teacher("Mani");
            Console.WriteLine(teacher.ToString());
        }
    }
}
