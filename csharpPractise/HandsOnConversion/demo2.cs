using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConversion
{
    internal class demo2
    {
        static void main()
        {
            string s = "1234";
            int i=Convert.ToInt32(s);
            short s3=Convert.ToInt16(s);
            byte b=Convert.ToByte(s);
            long l=Convert.ToInt64(s);
            double d=Convert.ToDouble(s);
            float f=Convert.ToSingle(s);
            decimal c=Convert.ToDecimal(s);
            char e=Convert.ToChar('a');
            bool bo=Convert.ToBoolean("true");
            s=Convert.ToString(123);
            s = Convert.ToString(12.34);
            s = Convert.ToString('a');
            s = Convert.ToString(true);
            int k = 100;
            short s1=Convert.ToInt16(k);
            byte s2=Convert.ToByte("AAA");//Exception
            
        }
    }
}
