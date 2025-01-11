using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonGeneerics
{
    class Test<K, V>
    {
        public K a;
        public V b;
        public void show()
        {
            Console.WriteLine($"a={a} b={b}");
        }
    }
    internal class demo1
    {
        static void Main()
        {
            Test<int,double> t = new Test<int,double>();
            t.a = 1;
            t.b = 2.00;
            t.show();
            Test<char,bool> t1 = new Test<char,bool>();
            t1.a = 'a';
            t1.b = true;
            t1.show();
        }
    }
}
