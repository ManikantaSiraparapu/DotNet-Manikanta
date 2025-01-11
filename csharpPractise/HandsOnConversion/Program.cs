namespace HandsOnConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long l = 123456;
            int l2 = (int)l;
            Console.WriteLine(l2);
            double d = 23.233;
            short s1=(short)d;
            Console.WriteLine(s1);
            int i = 256;
            byte b2=(byte)i;
            Console.WriteLine(b2);
            Console.WriteLine(typeof(short));
            Console.WriteLine(b2.GetType());
        }
    }
}
