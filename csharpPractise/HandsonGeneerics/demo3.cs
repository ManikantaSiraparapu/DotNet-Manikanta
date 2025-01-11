using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonGeneerics
{
    internal class demo3
    {
        static void Main()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Lilly");
            queue.Enqueue("Jasmine");
            queue.Enqueue("Tulips");
            
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(queue.Peek());
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(queue.Peek());
            queue.Clear();
        }
    }
}
