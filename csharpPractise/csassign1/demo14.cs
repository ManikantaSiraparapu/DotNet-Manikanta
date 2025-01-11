using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csbasicassignment
{
    internal class demo14
    {
        static void Main()
        {
            int[] m = new int[10];
             m[0] = 96;
             m[1] = 48;
             m[2] = 32;
             m[3] = 40;
             m[4] = 56;
             m[5] = 61;
             m[6] = 39;
             m[7] = 89;
             m[8] = 36;
             m[9] = 80;
            int total = 0;
            int t ;
            for(int i = 0; i < 10; i++)
            {
                total += m[i];
            }
            double avg = total / 10;
            for(int i = 0;i < 10;i++)
            {
                for(int j = 0;j < 10; j++)
                {
                    if (m[i] < m[j])
                    {
                        t = m[j];
                        m[j] = m[i];
                        m[i] = t;
                    }
                }
            }
            Console.WriteLine($"Total is {total}");
            Console.WriteLine($"Average is {avg}");
            Console.WriteLine($"Minimum marks is {m[0]}");
            Console.WriteLine($"Maximum marks is {m[9]}");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(m[i]+"\t");
            }
            Console.WriteLine();
            for(int i = 9; i >= 0; i--)
            {
                Console.Write(m[i]+"\t");
            }
            


        }
    }
}
