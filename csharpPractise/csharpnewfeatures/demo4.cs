using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpnewfeatures
{
    internal class demo4
    {
        //dynamic variable are accepting any runtime value
        dynamic val1;
        dynamic val2;
        static void Main()
        {
            //create variable using dynamic keyword
            dynamic a = 10;
            int b = 20;
            var c = 30;
            var d = 'a';
            a = 12.3;
            object o1 = 12;
            double d1 = a;
            double d2=(double)o1;
        }
    }
}
