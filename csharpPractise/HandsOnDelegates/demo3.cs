using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate int Cubedelegate(int x);
    internal class demo3
    {
        public static int cube(int x)
        {
            return x*x*x;
        }
        static void Main()
        {
            Cubedelegate c = new Cubedelegate(cube);
            int res = c(10);
            Console.WriteLine(res);
            //Lambda expresion
            Cubedelegate c1 = (x) => x * x * x;
            res = c1(13);
            Console.WriteLine(res);
        }
    }
}
