using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonGeneerics
{
    internal class dictdemo
    {
        static void Main()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "A");
            dict.Add(2, "B");
            dict.Add(3, "C");
            dict.Add(4, "D");
            string s = dict[1];
            Console.WriteLine(s);
            dict.Remove(2);
            foreach (int i in dict.Keys)
            {
                Console.WriteLine(dict[i]);
            }
        }
        
    }
}
