using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csbasicassignment
{
    internal class demo16
    {
        static void Main()
        {
            Console.WriteLine("Enter a String");
            string s = Console.ReadLine();
            for(int i = s.Length-1;i>=0;i--)
            {
                Console.Write(s[i]);
            }
            
        }
    }
}
