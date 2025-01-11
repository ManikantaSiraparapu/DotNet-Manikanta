using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionalstats
{
    internal class elseifprac
    {
        static void Main()
        {
            int m1 = 70, m2 = 60, m3 = 51, m4 = 60;
            float total=m1+m2+m3+m4;
            float avg = total / 4;
            string result = "";
            if(m1>50 && m2 > 50 && m3 > 50 && m4 > 50)
            {
                if (avg >= 70)
                {
                    result = "Distinction";
                }
                else if(avg >= 60)
                {
                    result = "First class";
                }
                else if (avg >= 50)
                {
                    result = "second class";
                }
            }
            else
            {
                result = "Fail";
            }
            if (result != "Fail")
            {
                Console.WriteLine($"\n=======================\n{result}\n=======================\ntotal:  {total}\n=======================\npercentage:  {avg}\n=======================\n");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
