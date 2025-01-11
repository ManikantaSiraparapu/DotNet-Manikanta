namespace conditionalstats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Mani";
            if (s == "Mani")
            {
                Console.WriteLine("Hello " + s);
            }
            string s1 = "Good morning";
            if (s1 == null)
            {
                s1 = "Hello";
            }
            Console.WriteLine(s1);
        }
    }
}
