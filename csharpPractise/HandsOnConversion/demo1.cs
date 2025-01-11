using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConversion
{
    internal class demo1
    {
        static void Main()
        {
            //Converting string(reference datatype) to int(Valued datatype)
            string a = "21";
            int k=int.Parse(a);
            Console.WriteLine(k);
            byte b=byte.Parse(a);
            Console.WriteLine(k);
            double d = double.Parse(a);            
            Console.WriteLine(k);
            short s = short.Parse(a);
            Console.WriteLine(k);
            float f = float.Parse(a);
            Console.WriteLine(k);
            decimal g = decimal.Parse(a);
            Console.WriteLine(k);
            string x = "AAA";
            //int i = int.Parse(x);//runtime error occured

            Console.WriteLine("k={0} d={1}",k,d);//Printing data

            Console.WriteLine($"k={k} d={d}");//Printing data
        }
    }
}
