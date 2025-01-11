using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConversion
{
    internal class demo3
    {
        static void Main()
        {
            object o = 12;
            object o1 = 1.23;
            object o2 = 'A';
            object o3 = "Mani";
            object o4 = true;
            //Conversion with object type
            //boxing process of converting VALUE TYPE to OBJECT
            int k = 123;
            double d = 1.23;
            char ch= 'A';
            string s = "AAA";// it is not boxing
            object oo = k;
            object oo1 = d;
            object oo3 = s;
            object oo4 = ch;
            Console.WriteLine(oo);
            //Unboxing  convert OBJECT to VALUE TYPE
            int kk=(int)o;
            kk=Convert.ToInt32(o);
            double dd=(double)o1;
            char cc=(char)o2;
            bool bb=(bool)o4;
            //Console.WriteLine(kk);
            //Console.WriteLine(dd);
            //Console.WriteLine(cc);
        }
    }
}
