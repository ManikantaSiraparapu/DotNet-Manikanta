using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate void multicastdelegate();
    internal class demo1
    {
        public static void task1()
        {
            Console.WriteLine("Task1");
        }
        public static void task2()
        {
            Console.WriteLine("Task2");
        }
        static void Main()
        {
            multicastdelegate obj = new multicastdelegate(task1);
            obj += task2;
            obj();
        }
    }
}
