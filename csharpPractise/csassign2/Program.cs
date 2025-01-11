namespace csassign1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter principle amount");
            double p=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a monthly payment");
            double x=double.Parse(Console.ReadLine());
            double a = x;
            double b=0 ;
            for (double i = p; i > 0; i-=x)
            {
                 p = p - x + (p * 0.015);
                 Console.WriteLine($"Balance: {p} total payments{a}");
                 a +=x;
                 b = p;  
            }
            p = 0;
            Console.WriteLine($"Balance: {p} total payments{b}");
        }
    }
}
