using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csassign1
{
    class Student
    {
        private int rollno;
        private string name;
        private string classs;
        private int sem;
        private string branch;
        private int[]marks=new int[5];

        public Student(int a,string b,string c,int d,string e,int []f)
        {
            this.rollno = a;
            this.name = b;
            this.classs = c;
            this.sem = d;
            this.branch = e;
            this.marks = f;
        }
        public void result()
        {
            int flag = 0, s = 0;
            foreach (int mark in marks)
            {
                s += mark;
                if (mark < 35)
                {
                    flag = 1;
                    break;
                }
            }
            double avg = s / 5;
            if (flag == 1 || avg < 50)
            {
                Console.WriteLine("Failed");
            }
            else
            {
                Console.WriteLine("Passed");
            }
        }
        public void Display()
        {
            Console.WriteLine($"Roll number : {rollno}");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"class : {classs}");
            Console.WriteLine($"Semister : {sem}");
            Console.WriteLine($"Branch : {branch}");
            foreach(int mark in marks)
            {
                Console.Write($"{mark} ");
            }
            Console.WriteLine();
            result();

        }
        
    }
    internal class Students
    {
        static void Main()
        {
            //int[] marks = { 21, 72, 73, 74, 75 };
            //Student student = new Student(1,"Mani","Btech",3,"ECE",marks);
            //student.Display();
            int[] mark = new int[5];
            Console.WriteLine("Enter marks");
            for(int i=0;i <mark.Length;i++)
            {
                mark[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter roll number");
            int rollno=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter class");
            string classs=Console.ReadLine();
            Console.WriteLine("Enter semister");
            int sem=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter branch");
            string branch=Console.ReadLine();
            Student st = new Student(rollno,name,classs,sem,branch,mark);
            st.Display();
        }
    }
}
