using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csbasicassignment
{
    internal class demo6
    {
        static void Main()
        {
            Console.WriteLine("Enter the number");//class is logical representation
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int y = i * i;
                Console.Write(y+"\t");
            }
        }
    }
}
