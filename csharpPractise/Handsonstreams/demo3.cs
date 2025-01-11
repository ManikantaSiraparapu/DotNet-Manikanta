using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handsonstreams
{
    internal class demo3
    {
        static void Main()
        {
            Console.WriteLine("Enter path");
            string path=Console.ReadLine();
            //read data in bytes from by using filestream
            using(FileStream fs=new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[]content=new byte[fs.Length];
                fs.Read(content, 0, content.Length);//read text from first character and returns in byte
                foreach(byte b in content)
                   Console.Write(b+" ");
                string output=UTF32Encoding.UTF8.GetString(content);
                Console.WriteLine(output);
            }
        }
    }
}
