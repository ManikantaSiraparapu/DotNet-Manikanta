using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpnewfeatures
{
    public class A { }
    public class B : A { }
    public class C : B { }
    public delegate A Mydelegate(B obj);
    internal class demo5
    {
        public A M1(B obj)
        {
            return null;
        }
        public B M2(A obj)
        {
            return null;
        }
        public C M3(A obj)
        {
            return null;
        }
        static void main()
        {
            demo5 d5 = new demo5();
            Mydelegate Md = new Mydelegate(d5.M1);
            Mydelegate Md1= new Mydelegate(d5.M2);
            Mydelegate Md2= new Mydelegate(d5.M3);
        }
    }
}
