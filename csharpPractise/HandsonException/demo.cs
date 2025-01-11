using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonException
{
    internal class demo
    {
        public static void Div(string n1, string n2)
        {
            try
            {
                byte a, b;
                a = byte.Parse(n1);
                b = byte.Parse(n2);
                int c = a / b;
                if (b == 0)
                {
                    throw new DivideByZeroException("B should not be zero");
                }
                Console.WriteLine(c);

            }
            catch (DivideByZeroException D)
            {
                Console.WriteLine(D.Message);
            }
            catch (FormatException E)
            {
                Console.WriteLine(E.Message);
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter a,b values");
            string a=Console.ReadLine();
            string b=Console.ReadLine();    
            Div(a, b);
        }
            
    }
}
