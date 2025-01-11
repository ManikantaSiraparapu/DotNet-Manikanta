using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpnewfeatures
{
    internal class demo1
    {
        static void Main()
        {
            var a = 10;
            var b = "Hi";
            var c = 1.23;
            int[] a1 = { 1, 2, 3, 4, 5, 6, 7 };
            foreach (var x in a1)
            {
                Console.Write(x);
            }
            string[] a2 = { "Rose", "Lilly" };
            foreach (var x in a2)
            {
                Console.WriteLine(x);
            }
        }
    }
}
