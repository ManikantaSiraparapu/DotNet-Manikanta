namespace arrayprac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]a = new int[5];
            a[0] = 1;
            a[1] = 2;
            a[2] = 3;
            a[3] = 4;
            a[4] = 5;
            for(int i = 0;i < 5; i++)
            {
                Console.Write(a[i]+"\t");
            }
            Console.WriteLine();
            foreach(int k in a)
            {
                Console.Write(k+"\t");
            }
        
        }
    }
}
