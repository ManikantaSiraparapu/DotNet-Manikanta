using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpnewfeatures
{
    internal class demo6
    {
        static void Main()
        {
            int a = 5;
            Console.WriteLine(a.square());
            if (a.IsEven())
                Console.WriteLine($"{a} is even");
            else
                Console.WriteLine($"{a} is Odd");
            string s = null;
            if (a.IsNull())
                Console.WriteLine("null");
            else
                Console.WriteLine("not null");
            int n = 152;
            if (n.IsPalindrome())
            {
                Console.WriteLine("not Palindrome");
            }
            else
            {
                Console.WriteLine(" palindrome");
            }
        }
    }
}
