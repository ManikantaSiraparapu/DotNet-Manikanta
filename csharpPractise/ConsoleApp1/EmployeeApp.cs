using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeApp
{
    // 1. Define the GovtRules interface
    interface GovtRules
    {
        double EmployeePF(double basicSalary);          // Method to calculate Provident Fund
        string LeaveDetails();                          // Method to get Leave details
        double GratuityAmount(int serviceCompleted, double basicSalary);  // Method to calculate Gratuity
    }

    // 2. TCS Class implementing GovtRules
    class TCS : GovtRules
    {
        private int emp_id;
        private string emp_name;
        private string dept;
        private string desg;
        private double basicSalary;
        private int serviceCompleted;

        // Constructor to initialize TCS employee details
        public TCS(int emp_id, string emp_name, string dept, string desg, double basicSalary, int serviceCompleted)
        {
            this.emp_id = emp_id;
            this.emp_name = emp_name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
            this.serviceCompleted = serviceCompleted;
        }

        // Properties to access employee details
        public int EmpId => emp_id;
        public string Name => emp_name;
        public string Dept => dept;
        public string Desg => desg;
        public double BasicSalary => basicSalary;
        public int ServiceCompleted => serviceCompleted;

        // Method to calculate Employee PF (Employee + Employer Contributions + Pension Fund)
        public double EmployeePF(double basicSalary)
        {
            double empPF = basicSalary * 0.12;
            double comPF = basicSalary * 0.0833;
            double pension = basicSalary * 0.0367;
            return empPF + comPF + pension;
        }

        // Method to display Leave details for TCS
        public string LeaveDetails()
        {
            return "Leave Details for TCS:\n1 day of Casual Leave per month\n12 days of Sick Leave per year\n10 days of Privilege Leave per year";
        }

        // Method to calculate Gratuity amount for TCS
        public double GratuityAmount(int serviceCompleted, double basicSalary)
        {
            if (serviceCompleted > 20)
                return basicSalary * 3;
            else if (serviceCompleted > 10)
                return basicSalary * 2;
            else if (serviceCompleted > 5)
                return basicSalary * 1;
            else
                return 0.0;
        }
    }

    // 3. Accenture Class implementing GovtRules
    class Accenture : GovtRules
    {
        private int emp_id;
        private string emp_name;
        private string dept;
        private string desg;
        private double basicSalary;
        private int serviceCompleted;

        // Constructor to initialize Accenture employee details
        public Accenture(int emp_id, string emp_name, string dept, string desg, double basicSalary, int serviceCompleted)
        {
            this.emp_id = emp_id;
            this.emp_name = emp_name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
            this.serviceCompleted = serviceCompleted;
        }

        // Properties to access employee details
        public int EmpId => emp_id;
        public string Name => emp_name;
        public string Dept => dept;
        public string Desg => desg;
        public double BasicSalary => basicSalary;
        public int ServiceCompleted => serviceCompleted;

        // Method to calculate Employee PF (Employee + Employer Contributions)
        public double EmployeePF(double basicSalary)
        {
            double empPF = basicSalary * 0.12;
            double comPF = basicSalary * 0.12;
            return empPF + comPF;
        }

        // Method to display Leave details for Accenture
        public string LeaveDetails()
        {
            return "Leave Details for Accenture:\n2 days of Casual Leave per month\n5 days of Sick Leave per year\n5 days of Privilege Leave per year";
        }

        // Gratuity for Accenture is not applicable
        public double GratuityAmount(int serviceCompleted, double basicSalary)
        {
            return 0.0; // No gratuity for Accenture
        }
    }

    // 4. Main Program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a company:\n1. TCS\n2. Accenture");
            int choice = int.Parse(Console.ReadLine());

            GovtRules emp = null;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter TCS Employee Details:");
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
                    Console.Write("Enter Service Years: ");
                    int serviceYearsTCS = int.Parse(Console.ReadLine());

                    // Create TCS employee object
                    emp = new TCS(empIdTCS, nameTCS, deptTCS, desgTCS, basicSalaryTCS, serviceYearsTCS);

                    break;

                case 2:
                    Console.WriteLine("Enter Accenture Employee Details:");
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
                    Console.Write("Enter Service Years: ");
                    int serviceYearsAcc = int.Parse(Console.ReadLine());

                    // Create Accenture employee object
                    emp = new Accenture(empIdAcc, nameAcc, deptAcc, desgAcc, basicSalaryAcc, serviceYearsAcc);

                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

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
