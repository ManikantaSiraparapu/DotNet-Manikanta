using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops2
{
    class Circle
    {
        private double r;
        public double Radius
        {
            get { return r; }
            set { r = value; }
        }
        public double Area
        {
            get
            {
                return Math.PI * r * r;
            }
        }
    }
    internal class demo3
    {
        static void Main()
        {
            Circle c=new Circle();
            c.Radius = 10;
            Console.WriteLine(c.Area);
        }
    }
}
