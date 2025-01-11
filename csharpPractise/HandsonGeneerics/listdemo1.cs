using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonGeneerics
{
    internal class listdemo1
    {
        static void Main()
        {
            List<string> list = new List<string>() { "Apple", "Mango", "Banana" };
            List<bool> list2 = new List<bool>() { true, false };
            list2.Add(true);
            list2.Add(false);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==================");
            list2.Insert(0, true);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
