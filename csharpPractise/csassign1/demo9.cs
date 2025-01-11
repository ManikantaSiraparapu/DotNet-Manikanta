using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csbasicassignment
{
    internal class demo9
    {
        static void Main()
        {
            Console.WriteLine("Enter n value");
            int n=int.Parse(Console.ReadLine());
            int s = 0;
            int r;
            while (n != 0){
                r = n % 10;
                s = s + r * r * r;
                n = n / 10;
            }
            Console.WriteLine(s);

        }
    }
}
