using System.IO;
namespace Handsonstreams
{
    class demo1
    {
        public static void Read(String path)
        {
            try
            {
                string content = File.ReadAllText(path);
                Console.WriteLine(content);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Write(String path)
        {
            try
            {
                string content = "Hello!!!";
                //File.WriteAllText(path, content);//Text will override
               File.AppendAllText(path, Environment.NewLine+content);//text will append

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
                try
                {
                    Console.WriteLine("Enter path");
                    String path=Console.ReadLine();
                    //demo1.Read(path);
                    demo1.Write(path);

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
        }
    }
}
