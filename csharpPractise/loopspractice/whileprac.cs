using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopspractice
{
    internal class whileprac
    {
        static void Main()
        {
            int n = 100;
            int i = 1;
            while (i <= n)
            {
                Console.WriteLine(i);
                i++;
                if (i == 50)
                {
                    break;
                }
            }
            int j = 0;
            do
            {
                j++;
                if (j % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(j + "\t");
            } while (j <= n);
        }
    }
}
