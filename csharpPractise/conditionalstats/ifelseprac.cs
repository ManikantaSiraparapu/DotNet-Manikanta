using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionalstats
{
    internal class ifelseprac
    {
        static void Main()
        {
            int x = 10;
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is Even");
            }
            else
            {
                Console.WriteLine($"{x} is Odd");
            }
            int a,b;
            Console.WriteLine("Enter a,b values");
            a = int.Parse(Console.ReadLine() );
            b = int.Parse(Console.ReadLine());
            if (a > b)
                Console.WriteLine($"{a} is bigger");
            else
                Console.WriteLine($"{b} is bigger");
        }
    }
}
