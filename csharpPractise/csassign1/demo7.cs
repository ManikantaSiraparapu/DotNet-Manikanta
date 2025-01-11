using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csbasicassignment
{
    internal class demo7
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int n=int.Parse(Console.ReadLine());
            int f = 1;
            for(int i = 1; i <=n; i++)
            {
                f = f * i;

            }
            Console.WriteLine(f);
        }
    }
}
