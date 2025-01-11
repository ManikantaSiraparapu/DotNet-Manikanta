using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    interface Ix
    {
        void m1();
        void m();
    }
    interface Iy
    {
        void m2();
        void m();
    }
    internal class demo1 : Ix, Iy
    {
        public void m1()
        {
            throw new NotImplementedException();
        }
        public void m2()
        {
            throw new NotImplementedException();
        }
        void Ix.m()
        {
            Console.WriteLine("Ix m() method");
        }
        void Iy.m()
        {
            Console.WriteLine("Iy m() method");
        }
        static void Main()
        {
            Ix ix = new demo1();
            ix.m();
            Iy iy=new demo1 ();
            iy.m();
        }
    }
}


    