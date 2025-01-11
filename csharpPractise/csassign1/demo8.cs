using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csbasicassignment
{
    internal class demo8
    {
        static void Main()
        {
            int n = 40;
            int a = 0;
            int b = 1;
            int c = a + b;
            Console.Write(a +"\t");
           Console.Write(b +"\t");
            for(int i = 2; i < n; i++)
            {
                Console.Write(c+"\t");
                a = b;
                b = c;
                c = a + b;
            }
        }
    }
}
