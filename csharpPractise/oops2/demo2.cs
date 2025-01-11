using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops2
{
    class Rectangle
    {
        private int len, wid;
        public Rectangle(int x,int y)
        {
            this.len = x;
            this.wid = y;
        }
        public Rectangle(Rectangle r)
        {
            len = r.len;
            wid = r.wid;
        }
        public void Area()
        {
            Console.WriteLine($"Area is {len*wid}");
        }
    }
    internal class demo2
    {
        static void Main()
        {
            Rectangle r1=new Rectangle(10,10);
            r1.Area();
            Rectangle r = new Rectangle(r1);
            r.Area();
            
        }
    }
}
