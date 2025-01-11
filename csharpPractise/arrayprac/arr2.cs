using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayprac
{
    internal class arr2
    {
        static void Main()
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine("Enter a value");
            int n=int.Parse(Console.ReadLine());
            string result = null;
            for(int i = 0; i < num.Length; i++)
            {
                if (n == num[i])
                {
                    result = "WINNER";
                    break;
                }
            }
            if (result == null)
            {
                result = "LOOSER";
            }
            Console.WriteLine(result);
        }
    }
}
