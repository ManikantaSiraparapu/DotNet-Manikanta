using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csassignonLinq
{
    internal class demo1
    {
        static void Main()
        {
            List<string> a = new List<string>() { "ab","bc","cd","de","ef","gh"};
            List<string> b = new List<string>();
            for (int i =0;i<=a.Count()/2;i++)
            {
                b.Add(a[i]);
                a.Remove(a[i]);
            }
            var v = from i in a
                    where i != b[0]
                    select (i, b[0]);
           Console.WriteLine(v);
            
           
            
            
                  
                  

        }
    }
}
