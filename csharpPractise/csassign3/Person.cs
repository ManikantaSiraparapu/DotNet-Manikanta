using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csassign3
{
    internal class Person
    {
        public String Fname;
        public String Lname;
        public string Email;
        public DateTime DOB;

        public Person(string Fname,string Lname,string Email,DateTime DOB)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            this.Email = Email;
            this.DOB = DOB;
        }
        public Person(string Fname,string Lname,string Email)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            this.Email = Email;
        }
        public Person(string Fname,string Lname,DateTime DOB)
        {
            this.Fname = Fname;  
            this.Lname = Lname;
            this.DOB= DOB;
        }
        public void Display()
        {
            Console.WriteLine($"First name : {Fname}");
            Console.WriteLine($"Last name : {Lname}");
            Console.WriteLine($"Email Address : {Email}");
            Console.WriteLine($"Date of Birth : {DOB.ToString("yyyy-MM-dd")}");
        }
        public static void Main()
        {
            Person p1 = new Person("Mani", "Siraparapu", "mani@123",new DateTime(2002, 08, 23));
            Console.WriteLine("Person1 details");
            p1.Display();
            Person p2 = new Person("Mani", "Siraparapu", "mani@123");
            Console.WriteLine("Person2 details");
            p2.Display();
            Person p3 = new Person("Mani", "Siraparapu", new DateTime(2002, 08, 23));
            Console.WriteLine("Person3 details");
            p3.Display();
        }
    }
}
