using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayprac
{
    internal class arr1
    {
        static void Main()
        {
            string[] a = new string[4];
            for(int i = 0; i < 4; i++)
            {
                Console.Write($"Enter city {i+1} :");
                a[i] = Console.ReadLine();
            }
            foreach(String k in a)
            {
                Console.WriteLine(k);
            }
        }
    }
}
