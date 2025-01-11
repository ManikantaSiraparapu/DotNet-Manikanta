using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csbasicassignment
{
    internal class demo12
    {
        static void Main()
        {
            Console.WriteLine("Enter first value");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second value");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third value");
            int n3 = int.Parse(Console.ReadLine());

            if(n1>n2 && n1 > n3)
            {
                Console.WriteLine($"{n1} is Bigger");
            }
            else if(n2> n3)
            {
                Console.WriteLine($"{n2} is Bigger");
            }
            else
            {
                Console.WriteLine($"{n3} is Bigger");
            }
        }
    }
}
