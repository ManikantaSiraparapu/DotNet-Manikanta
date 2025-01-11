namespace HandsonException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] a = { 1, 2, 3 };
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(a[i]);
                }
                Console.WriteLine("Hello, World!");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Error occured");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Repu Selavu");
        }
    }
}
