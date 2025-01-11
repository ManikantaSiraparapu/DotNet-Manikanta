using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csbasicassignment
{
    internal class demo18
    {
        static void Main()
        {
            Console.WriteLine("Enter a String");
            string s = Console.ReadLine();
            string t = "";
            for (int i = s.Length-1; i >=0; i--)
            {
                t += s[i];
            }
            if (t == s)
            {
                Console.WriteLine($"{s} is Palindrome");
            }
            else
            {
                Console.WriteLine($"{s} is not a Palindrome");
            }

        }
    }
}
