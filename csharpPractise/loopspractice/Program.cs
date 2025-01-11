namespace loopspractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n value");
            int n=int.Parse(Console.ReadLine());
            /*  for(int i = 0; i <= n; i++)
              {
                  Console.Write(i+"\t");
              }*/
            for (int i = 0; i <= n; i++)
            {
                if(i%2==0) 
                Console.Write(i + "\t");
            }
            Console.WriteLine("\n=====================================\n");
            //Factorial
            int f = 1;
            for(int i = n; i > 0; i--)
            {
                f = f * i;
            }
            Console.WriteLine($"Factorial of {n} is {f}");

        }
    }
}
