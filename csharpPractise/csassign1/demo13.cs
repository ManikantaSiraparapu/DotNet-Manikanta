using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csbasicassignment
{
    internal class demo13
    {
        static void Main()
        {
            Console.WriteLine("Enter first value");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second value");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third value");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fourth value");
            int n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fifth value");
            int n5 = int.Parse(Console.ReadLine());
            if (n1 < n2 && n1 < n3 && n1 < n4 && n1 < n5)
                Console.WriteLine($"{n1} is smaller");
            else if (n2 < n1 && n2 < n3 && n2 < n4 && n2 < n5)
                Console.WriteLine($"{n2} is smaller");
            else if (n3 < n1 && n3 < n2 && n3 < n4 && n3 < n5)
                Console.WriteLine($"{n3} is smaller");
            else if (n4 < n1 && n4 < n2 && n4 < n3 && n2 < n5)
                Console.WriteLine($"{n4} is smaller");
            else
                Console.WriteLine($"{n5} is smaller");
        }
    }
}
