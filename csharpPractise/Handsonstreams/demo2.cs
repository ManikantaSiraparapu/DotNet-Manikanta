using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handsonstreams
{
    internal class demo2
    {
        public static void Read(string path)
        {
            try
            {
                //using block dispose streamReader object automatically once code executed
                using(StreamReader sr=new StreamReader(path))
                {
                    string content = sr.ReadToEnd();//Read all lines of text
                    Console.WriteLine(content);

                }
            }
            catch(Exception)
            {
                throw;
            }
        }
        public static void Write(string path)
        {
            try
            {
                //using block dispose streamReader object automatically once code executed
                using (StreamWriter sw = new StreamWriter(path,true))//without true the text will override
                {
                    string content = "Hello world!!";
                    sw.WriteLine(Environment.NewLine+content);

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter path");
                String path = Console.ReadLine();
                //demo2.Read(path);
                demo2.Write(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
