using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csbasicassignment
{
    internal class demo17
    {
        static void Main()
        {
            Console.WriteLine("Enter a String");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter a String");
            string s2 = Console.ReadLine();
            if(s1 == s2)
            {
                Console.WriteLine("Both are same");
            }
            else
            {
                Console.WriteLine("Both are not same");
            }
        }
    }
}
