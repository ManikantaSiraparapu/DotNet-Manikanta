using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  
namespace HandsonDatatypes
{
    internal class Employee
    {
        static void Main()
        {
            int emp_id = 1;
            String emp_name = "Mani";
            double emp_salary = 30000;
            char gender = 'M';
            Console.WriteLine("Id: " + emp_id);
            Console.WriteLine("Name: " + emp_name);
            Console.WriteLine($"Id:{emp_id} Name:{emp_name}");
        }

    }
}
