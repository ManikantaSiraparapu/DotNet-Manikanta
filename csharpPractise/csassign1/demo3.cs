using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csbasicassignment
{
    internal class demo3
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int x=int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is Even");
            }
            else
            {
                Console.WriteLine($"{x} is Odd");
            }
        }
    }
}
