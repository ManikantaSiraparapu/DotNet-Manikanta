using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayprac
{
    internal class _2darr
    {
        static void Main()
        {
            int[,] m =new int [3, 3];
            m[0, 0] = 1;
            m[0, 1] = 2;
            m[0, 2] = 3;

            m[1, 0] = 11;
            m[1, 1] = 12;
            m[1, 2]= 13;

            m[2, 0]= 21;
            m[2, 1]= 22;
            m[2, 2]= 23;
            
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(m[i, j]+"\t");
                }
                Console.WriteLine();
                Console.WriteLine();

            }
        }
    }
}
