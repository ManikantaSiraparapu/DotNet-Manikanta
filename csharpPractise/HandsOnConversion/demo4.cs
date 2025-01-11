using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConversion
{
    internal class demo4
    {
        static void Main()
        {
            Console.WriteLine("Enter Name");
            string name=Console.ReadLine();
            // Console.WriteLine("Hello "+name);
            Console.WriteLine("Enter Age ");
            byte age=Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Gender");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Name: {name} Age: {age} Gender: {ch}");
        }
    }
}
