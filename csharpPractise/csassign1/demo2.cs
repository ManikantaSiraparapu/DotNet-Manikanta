using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace csbasicassignment
{
    internal class demo2
    {
        static void Main()
        {
            Console.WriteLine("Enter first number");
            int x=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y=int.Parse(Console.ReadLine());
            for(int i = x+1; i < y; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
