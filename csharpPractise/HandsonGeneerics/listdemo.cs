using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonGeneerics
{
    internal class listdemo
    {
        static void Main()
        {
            List<int> list = new List<int>();   
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            int k = list[2];
            Console.WriteLine(k);
            Console.WriteLine(list.Count());
            list.Remove(3);
            Console.WriteLine(list.Count());
            list.Add(3);
            list.RemoveAt(2);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            list.Sort();
            list.Reverse();
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            list.Clear();

        }
    }
}
