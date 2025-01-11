using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionalstats
{
    internal class switchprac
    {
        static void Main()
        {
            Console.WriteLine("Enter a character");
            char ch=char.Parse(Console.ReadLine());
            do
            {
                switch (ch)
                {
                    case 'r':
                        Console.WriteLine("Red");
                        break;
                    case 'b':
                    case 'B':
                        Console.WriteLine("Blue");
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (true);
        }
    }
}
