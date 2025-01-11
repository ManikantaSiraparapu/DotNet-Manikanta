using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinQ
{
    internal class demo3
    {
        static void Main()
        {
            int[] n = { 5, 6, 7, 8, 9 };
            var res = from i in n
                      where i * i * i > 100
                      select i * i * i;
            var r = from i in n
                    let m = i * i * i
                    where m > 100
                    select m;
            foreach ( var i in res )
            {
                Console.Write( i +"\t");
            }
            Console.WriteLine();
            foreach (var i in r)
            {
                Console.Write(i + "\t");
            }
        }
    }
}
