using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Employee
    {
        string empname;//Instance variable
        static double salary;
        string[] projects = { "Project1", "Project2", "Project3" };
        string[] skills = { "Angular", "Dotnet", "SQL" };
        static void Main()
        {
            int count = 0;//Local Variable
            int[] numbers = new int[6] { 1, 2, 3, 4, 5, 6 };//Array type Variable
            Console.WriteLine("Employee class");
            Console.WriteLine(count);
        }
    }
}
