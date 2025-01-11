using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate void callbackdelegate();
    internal class demo2
    {
        public void M()
        {
            Console.WriteLine("Hello world!!");
        }
        public void callback(callbackdelegate callback)
        {
            callback();
        }
        static void Main()
        {
            demo2 demo = new demo2();
            demo.callback(demo.M);//Passing method m as a parameter to callback metghod using delegate
            
        }
    }
}
