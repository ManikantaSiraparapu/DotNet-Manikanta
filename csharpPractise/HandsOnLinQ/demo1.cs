using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinQ
{
    internal class demo1
    {
        static void Main()
        {
           int[] a= { 1, 2, 3, 3, 2, 6, 8, 8, 9, 10, 11, 12, 15, 14, 15, 16, 17, 18};
            var r1=(from i in a select i).Distinct();
            var r2=a.Select(i => i).Distinct();
            var r3 = from i in a
                     where i % 2 == 0 && i > 6
                     select i;
            var r4 = a.Where(k => k % 2 == 0 && k > 6);
            var r5 = from i in a
                     where i > 6
                     orderby i ascending
                     select i;
            var r6 = a.Where(i => i % 2 == 0 && i > 6).OrderBy(i => i);
            foreach( var i in r1)
            {
                Console.Write(i+"\t");
            }
            Console.WriteLine();
            foreach (var i in r2)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            foreach (var i in r3)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            foreach (var i in r4)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            foreach (var i in r5)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            foreach (var i in r6)
            {
                Console.Write(i + "\t");
            
            }
        }
    }
}
