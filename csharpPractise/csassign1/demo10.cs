using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csbasicassignment
{
    internal class demo10
    {
        static void Main()
        {
            Console.WriteLine("Enter n value");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{n} * {i} = {i*n}");
            }
        }
    }
}
