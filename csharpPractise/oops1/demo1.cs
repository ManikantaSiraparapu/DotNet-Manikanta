using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    internal class demo1
    {
        private int a, b;
        public void set(int n,int m)
        {
            a = n;
            b = m;
        }
        public void display()
        {
            Console.WriteLine($"a is {a} b is {b}");
        }
        public static void Main()
        {
            demo1 d1 = new demo1();
            d1.set(1,2);
            d1.display();
            demo1 d2 = new demo1();
            d2.set(3,4);
            d2.display();
        }
    }
}
