using System;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace assignment1
{
    interface GovtRules
    {
        public double EmployeePF(double basicSalary);
        public void LeaveDetails();
        public double gratuityAmount(float serviceCompleted, double basicSalary);
    }
    class TCS : GovtRules
    {
        private int emp_id;
        private string emp_name;
        private string dept;
        private string desg;
        private double basicSalary;
        private int serviceCompleted;
        public TCS(int emp_id, string emp_name, string eept, string desg,double basicSalary,int serviceCompleted)
        {
            this.emp_id = emp_id;
            this.emp_name = emp_name;
            this.dept = dept;
            this.basicSalary = basicSalary;
            this.desg = desg;
            this.serviceCompleted = serviceCompleted;
        }
        public int EmpId { get { return emp_id; } }
        public string Name { get { return emp_name; } }
        public string Dept { get { return dept; } }
        public string Desg { get { return desg; } }
        public double BasicSalary { get { return basicSalary; } }
        public int ServiceCompleted { get { return serviceCompleted; } }
        public double EmployeePF(double basicSalary)
        {
            double empPF = basicSalary * 0.12;
            double comPF=basicSalary * 0.0833;
            double pension = basicSalary * 0.0367;
            return empPF + comPF + pension;
        }
        public void LeaveDetails()
        {
            Console.WriteLine("Leave Details for TCS is\n1 day of Casual Leave per month\n12 days of Sick Leave per year\n10 days of Previlage Leave per year\n");
        }


        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            if (serviceCompleted > 20)
            {
                return basicSalary * 3;
            }
            else if (serviceCompleted > 10)
            {
                return basicSalary * 2;
            }
            else if (serviceCompleted > 5)
            {
                return basicSalary * 1;
            }
            else
            {
                return 0.0;
            }
        }
        
        
    }
    class Accenture : GovtRules
    {
        private int emp_id;
        private string emp_name;
        private string dept;
        private string desg;
        private double basicSalary;
        private int serviceCompleted;
        public Accenture(int emp_id, string emp_name, string dept, string desg,double basicSalary, int serviceCompleted)
        {
            this.emp_id = emp_id;
            this.emp_name = emp_name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
            this.serviceCompleted = serviceCompleted;
        }
        public int EmpId { get { return emp_id; } }
        public string Name { get { return emp_name; } }
        public string Dept { get { return dept; } }
        public string Desg { get { return desg; } }
        public double BasicSalary { get { return basicSalary; } }
        public int ServiceCompleted { get { return serviceCompleted; } }
        public double EmployeePF(double basicSalary)
        {
            double empPF = basicSalary * 0.12;
            double compf = basicSalary * 0.12;
            return empPF + compf;
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            return 0.0;
        }

        public void LeaveDetails()
        {
            Console.WriteLine("Leave Details for Accenture is\n2 day of Casual Leave per month\n5 days of Sick Leave per year\n5 days of Previlage Leave per year\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a company");
            Console.WriteLine("1.TCS\n2.Accenture");
            int ch=int.Parse(Console.ReadLine());
            GovtRules emp = null;
            switch (ch)
            {     
            }
            
        }
    }
 }
 

