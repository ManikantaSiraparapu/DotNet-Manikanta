using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    internal class demo2
    {
        public int Sum(int x,int y)
        {
            return x + y;
        }
        public int Add(int[] a)
        {
            int res = 0;
            foreach (int k in a)
            {
                res += k;
            }
            return res;
        }
        public int[] PrintNumbers()
        {
            int[] num= new int[3] {1,2,3};
            return num;
        }
        public bool IsEven(int n)
        {
            if(n%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string Greet(String name)
        {
            return name;
        }
        static void Main()
        {
            demo2 o = new demo2();
            int p=o.Sum(1, 2);
            Console.WriteLine(p);
            string s = o.Greet("Mani");
            Console.WriteLine(s);
            Console.WriteLine(o.Greet("Sai"));
            Console.WriteLine(o.IsEven(1) == true ? "Even" : "Odd");
            int c=o.Add(new int[]{1,2,3});
            Console.WriteLine(c);
            foreach (int k in o.PrintNumbers())
            {
                Console.Write(k+"\t");
            }
            Console.WriteLine();
            int[]a=o.PrintNumbers();
            foreach (int k in a)
            {
                Console.Write(k+"\t");
            }
        }
    }
}
