using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayprac
{
    internal class jarr
    {
        static void Main()
        {
            int[][] jarr = new int[3][];
            jarr[0] = new int[3] { 1, 2, 3 };
            jarr[1] = new int[3] { 2, 3, 4 };
            jarr[2] = new int[3] { 3, 4, 5 };
            Console.WriteLine(jarr[0][0]);
            foreach (int i in jarr[2])
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                foreach (int j in jarr[i])
                {
                    Console.Write(j + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
