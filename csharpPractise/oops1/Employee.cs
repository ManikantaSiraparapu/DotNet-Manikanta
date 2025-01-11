using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    internal class Employee
    {
        //instance variable
        public int emp_id;
        public string emp_name;
        //static variable
        public static string company;
        public static string project;
        public void show()
        {
            Console.WriteLine($"Id : {emp_id} Name : {emp_name} company : {company} project : {project}");
        }
    }
    class text_employess
    {
        static void Main()
        {
            //set values to static data
            Employee.company = "SPS";
            Employee.project = "Vehicle Insurance";
            Employee e1 = new Employee() { emp_id = 1, emp_name = "Mani" };
            Employee e2 = new Employee() { emp_id = 2, emp_name = "sai" };
            Employee e3 = new Employee() { emp_id = 3, emp_name = "Murali" };
            Employee[] list = new Employee[3];
            list[0] = e1;
            list[1] = e2;
            list[2] = e3;
            foreach (Employee e in list)
            {
                e.show();
            }
            Employee.company = "WSI";
            Employee.project = "Health insurance";
            Employee e4 = new Employee() { emp_id = 4, emp_name = "Ranga" };
            Employee e5 = new Employee() { emp_id = 5, emp_name = "sreenu" };
            Employee[] list1 = new Employee[3];
            list1[0] = e4;
            list1[1] = e5;
            list1[2] = new Employee() { emp_id = 6, emp_name = "pandu" };
            foreach (Employee e in list1)
            {
                e.show();
            }
        }
    }
}
