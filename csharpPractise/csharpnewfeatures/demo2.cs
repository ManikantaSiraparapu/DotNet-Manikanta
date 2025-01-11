using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpnewfeatures
{
    internal class demo2
    {
        public static void Greet(string name,string msg="Hi")//optional parameter
        {
            Console.WriteLine($"{msg} {name}");
        }
        static void Main()
        {
            Greet("Virat", "Hello");
            Greet("Sachin");
            Greet(name: "Rohith", msg: "Good evening");//named parameters
        }
    }
}
