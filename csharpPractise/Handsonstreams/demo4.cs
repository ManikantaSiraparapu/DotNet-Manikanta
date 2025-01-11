using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handsonstreams
{
    internal class demo4
    {
        static void Main()
        {
            //to create a directory
            //Directory.CreateDirectory("D://dirprac");
            string[]directories=Directory.GetDirectories("D:\\");//get sub directories
            foreach (string dir in directories)
            {
                Console.WriteLine(dir);
            }
            string[] files = Directory.GetFiles("D:\\javanotes");//get files in directory
            foreach(string file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
