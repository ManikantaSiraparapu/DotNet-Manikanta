using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonGeneerics
{
    internal class demo2
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>(); 
            //add items
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }
            stack.Pop();
            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(stack.Peek());
            stack.Clear();
        }
    }
}
