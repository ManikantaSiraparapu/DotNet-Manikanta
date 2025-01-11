using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace oops2
{
    class Point
    {
        private int x, y;
        //ctor
        public Point()
        {
            x = 10;
            y = 20;
        }
        public Point(int a,int b)
        {
            x = a;
            y = b;
        }
        public void show()
        {
            Console.WriteLine(x + " " + y);
        }
    }
    internal class demo1
    {
        static void Main()
        {
            Point p = new Point();
            p.show();
            Point p2 = new Point(1,2);
            p2.show();

        }
    }
}
