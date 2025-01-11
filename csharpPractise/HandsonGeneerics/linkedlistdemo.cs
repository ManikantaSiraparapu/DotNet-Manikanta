using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonGeneerics
{
    internal class linkedlistdemo
    {
        static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddLast(2);
            LinkedListNode<int> node = list.Find(2);
            list.AddBefore(node, 2);
            node= list.Find(1);
            list.AddAfter(node, 2);
            foreach(int i in list)
            {
                Console.WriteLine(i);
                Console.WriteLine(list.Count());
            }

        }
    }
}
