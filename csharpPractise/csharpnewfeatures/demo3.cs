using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpnewfeatures
{
    internal class demo3
    {
        static void Main()
        {
            var obj = new { Id = 1, Name = "Rohan", Age = 10, std = 3 };
            Console.WriteLine($"Id :{obj.Id} Name :{obj.Name}");
        }
    }
}
