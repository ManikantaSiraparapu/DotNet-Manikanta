using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinQ
{
    internal class demo2
    {
        static void Main()
        {
            string[] f = { "Rose", "Lilly", "Bally", "Cally", "Dilly", "Pilly" };
            var res=from s in f
                    where s.Length>4
                    select s;
            var r=f.Where(s => s.Length>4);
            foreach (var s in r)
            {
                Console.Write(s+"\t");
            }
            Console.WriteLine();
            foreach (var s in res)
            {
                Console.Write(s+"\t");
            }
            Console.WriteLine();

            var rest =from s in f
                     where s.StartsWith("D")
                     select s;
            foreach (var s in rest)
            {
                Console.Write(s+"\t");
            }
            Console.WriteLine();
            var r1=f.Where (s=>s.StartsWith("D"));
            foreach (var s in r1)
            {
                Console.Write(s + "\t");
            }
            

        }
    }
}
