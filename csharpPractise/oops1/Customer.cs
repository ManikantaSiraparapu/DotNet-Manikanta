using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    internal class Customer
    {
        public string name;
        public int id;
        public string address;
        public string email;
        public void Display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Address : " + address);
            Console.WriteLine("Email : " + email);
        }
    }
}
