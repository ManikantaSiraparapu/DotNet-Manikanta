using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csassign1
{
    class Accounts
    {
        private int acc_no;
        private string cus_name;
        private string acc_type;
        private string trsn_type;
        private double amt;
        private double bal;
        public void accept()
        {
            Console.WriteLine("Enter account Number");
            acc_no=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter customer name");
            cus_name = Console.ReadLine();
            Console.WriteLine("Enter account type(Savings/Current)");
            acc_type = Console.ReadLine();
            Console.WriteLine("Enter balance");
            bal=int.Parse(Console.ReadLine());
        }
      
        public void credit(double amt)
        {
            bal += amt;
            Console.WriteLine("Amount credited");
        }
        public void debit(double amt)
        {
            if (amt > bal)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                bal-= amt;
                Console.WriteLine("Amount debitted");
            }
        }
        public void show()
        {
            Console.WriteLine($"Account number : {acc_no}");
            Console.WriteLine($"Customer name: {cus_name}");
            Console.WriteLine($"Account type: {acc_type}");
            Console.WriteLine($"Balance is {bal}");
        }
    }
    internal class Bank
    {
        static void Main()
        {
            Accounts acc = new Accounts();

            do
            {
                
                Console.WriteLine("1.Accept data\n2.Credit amount\n3.Debit amount\n4.Display data");
                Console.WriteLine("Enter your choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        acc.accept();
                        break;
                    case 2:
                        Console.WriteLine("Enter amount to be credited");
                        double x = double.Parse(Console.ReadLine());
                        acc.credit(x);
                        break;
                    case 3:
                        Console.WriteLine("Enter amount to be debitted");
                        double y = double.Parse(Console.ReadLine());
                        acc.debit(y);
                        break;
                    case 4:
                        acc.show();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }while(true);

        }
    }
}
