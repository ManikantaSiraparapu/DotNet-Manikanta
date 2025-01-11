using System;

namespace assignment1
{
    // Define GovtRules interface
    interface GovtRules
    {
        double EmployeePF(double basicSalary);  // Method to calculate PF
        string LeaveDetails();  // Method to get leave details
        double GratuityAmount(int serviceCompleted, double basicSalary);  // Method to calculate gratuity
    }

    // TCS class implementing GovtRules
    class TCS : GovtRules
    {
        private int emp_id;
        private string emp_name;
        private string dept;
        private string desg;
        private double basicSalary;
        private int serviceCompleted;

        public TCS(int emp_id, string emp_name, string dept, string desg, double basicSalary, int serviceCompleted)
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

        // Implements EmployeePF from GovtRules
        public double EmployeePF(double basicSalary)
        {
            double empPF = basicSalary * 0.12;
            double comPF = basicSalary * 0.0833;
            double pension = basicSalary * 0.0367;
            return empPF + comPF + pension;
        }

        // Implements LeaveDetails from GovtRules
        public string LeaveDetails()
        {
            return "Leave Details for TCS: 1 day of Casual Leave per month, 12 days of Sick Leave per year, 10 days of Privilege Leave per year.";
        }

        // Implements GratuityAmount from GovtRules
        public double GratuityAmount(int serviceCompleted, double basicSalary)
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

    // Accenture class implementing GovtRules
    class Accenture : GovtRules
    {
        private int emp_id;
        private string emp_name;
        private string dept;
        private string desg;
        private double basicSalary;
        private int serviceCompleted;

        public Accenture(int emp_id, string emp_name, string dept, string desg, double basicSalary, int serviceCompleted)
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

        // Implements EmployeePF from GovtRules
        public double EmployeePF(double basicSalary)
        {
            double empPF = basicSalary * 0.12;
            double comPF = basicSalary * 0.12;
            return empPF + comPF;
        }

        // Implements LeaveDetails from GovtRules
        public string LeaveDetails()
        {
            return "Leave Details for Accenture: 2 days of Casual Leave per month, 5 days of Sick Leave per year, 5 days of Privilege Leave per year.";
        }

        // Implements GratuityAmount from GovtRules
        public double GratuityAmount(int serviceCompleted, double basicSalary)
        {
            return 0.0; // Accenture doesn't offer gratuity
        }
    }

    // Main Program to interact with user
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a company");
            Console.WriteLine("1.TCS\n2.Accenture");
            int ch = int.Parse(Console.ReadLine());
            GovtRules emp = null; // Declare interface reference

            switch (ch)
            {
                case 1:
                    // Get TCS employee details
                    Console.WriteLine("Enter TCS Employee Details");
                    Console.Write("Enter Employee ID: ");
                    int empIdTCS = int.Parse(Console.ReadLine());
                    Console.Write("Enter Employee Name: ");
                    string nameTCS = Console.ReadLine();
                    Console.Write("Enter Department: ");
                    string deptTCS = Console.ReadLine();
                    Console.Write("Enter Designation: ");
                    string desgTCS = Console.ReadLine();
                    Console.Write("Enter Basic Salary: ");
                    double basicSalaryTCS = double.Parse(Console.ReadLine());
                    Console.Write("Enter Service years : ");
                    int serviceCompletedTCS = int.Parse(Console.ReadLine());

                    // Create instance of TCS class and assign to interface reference
                    emp = new TCS(empIdTCS, nameTCS, deptTCS, desgTCS, basicSalaryTCS, serviceCompletedTCS);
                    break;

                case 2:
                    // Get Accenture employee details
                    Console.WriteLine("Enter Accenture Employee Details");
                    Console.Write("Enter Employee ID: ");
                    int empIdAcc = int.Parse(Console.ReadLine());
                    Console.Write("Enter Employee Name: ");
                    string nameAcc = Console.ReadLine();
                    Console.Write("Enter Department: ");
                    string deptAcc = Console.ReadLine();
                    Console.Write("Enter Designation: ");
                    string desgAcc = Console.ReadLine();
                    Console.Write("Enter Basic Salary: ");
                    double basicSalaryAcc = double.Parse(Console.ReadLine());
                    Console.Write("Enter Service years : ");
                    int serviceCompletedAcc = int.Parse(Console.ReadLine());

                    // Create instance of Accenture class and assign to interface reference
                    emp = new Accenture(empIdAcc, nameAcc, deptAcc, desgAcc, basicSalaryAcc, serviceCompletedAcc);
                    break;
            }
            // Check if emp is not null before calling methods
            if (emp != null)
            {
                // If emp is a TCS object, cast it and access properties
                if (emp is TCS tcsEmp)
                {
                    Console.WriteLine("\nEmployee Details:");
                    Console.WriteLine("Employee ID: " + tcsEmp.EmpId);
                    Console.WriteLine("Name: " + tcsEmp.Name);
                    Console.WriteLine("Department: " + tcsEmp.Dept);
                    Console.WriteLine("Designation: " + tcsEmp.Desg);
                    Console.WriteLine("Basic Salary: " + tcsEmp.BasicSalary);

                    // Display Provident Fund (PF)
                    Console.WriteLine("\nProvident Fund Contribution: " + tcsEmp.EmployeePF(tcsEmp.BasicSalary));

                    // Display Leave Details
                    Console.WriteLine("\nLeave Details:\n" + tcsEmp.LeaveDetails());

                    // Display Gratuity Amount
                    Console.WriteLine("\nGratuity Amount: " + tcsEmp.GratuityAmount(tcsEmp.ServiceCompleted, tcsEmp.BasicSalary));
                }
                // If emp is an Accenture object, cast it and access properties
                else if (emp is Accenture accentureEmp)
                {
                    Console.WriteLine("\nEmployee Details:");
                    Console.WriteLine("Employee ID: " + accentureEmp.EmpId);
                    Console.WriteLine("Name: " + accentureEmp.Name);
                    Console.WriteLine("Department: " + accentureEmp.Dept);
                    Console.WriteLine("Designation: " + accentureEmp.Desg);
                    Console.WriteLine("Basic Salary: " + accentureEmp.BasicSalary);

                    // Display Provident Fund (PF)
                    Console.WriteLine("\nProvident Fund Contribution: " + accentureEmp.EmployeePF(accentureEmp.BasicSalary));

                    // Display Leave Details
                    Console.WriteLine("\nLeave Details:\n" + accentureEmp.LeaveDetails());

                    // Display Gratuity Amount
                    Console.WriteLine("\nGratuity Amount: " + accentureEmp.GratuityAmount(accentureEmp.ServiceCompleted, accentureEmp.BasicSalary));
                }
            }
            else
            {
                Console.WriteLine("Employee details could not be loaded.");
            }

        }
    }
}
