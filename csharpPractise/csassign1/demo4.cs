using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csbasicassignment
{
    internal class demo4
    {
        static void Main()
        {
            int[] a = new int[5];
            Console.WriteLine("Enter the elements");
            for(int i = 0; i < 5; i++)
            {
                a[i]=int.Parse(Console.ReadLine());
            }
            for(int i = 0;i < 5; i++)
            {
                if(a[i]%2 == 0)
                {
                    Console.WriteLine($"{a[i]} is Even");
                }
                else
                {
                    Console.WriteLine($"{a[i]} is Odd");
                }
            }
        }
    }
}
