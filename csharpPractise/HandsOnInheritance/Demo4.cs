﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    class XXX
    {
       protected int i;
       protected int j;

        public XXX(int i, int j)
        {
            this.i = i;
            this.j = j;
        }
    }
    class YYY:XXX
    {
        public YYY():base(12,20) //base keyword invokes Class X parameter constructor
        {

        }
        public YYY(int a, int b):base(a,b) 
        {

        }
        
        public void Show()
        {
            Console.WriteLine($"i={i} j={j}");
        }
    }

    class Demo4
    {
        static void Main()
        {
           YYY ob= new YYY();
            ob.Show();
            YYY ob1=new YYY(12,89);
            ob1.Show();
            YYY ob2 = null;
            ob2.Show();

        }
    }
}
