namespace oops1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c=new Customer();
            c.name = "Mani";
            c.id = 1;
            c.address = "Hyderabad";
            c.email = "mani@123";
            c.Display();
            Customer c1= new Customer();
            c1.name = "ani";
           
            c1.address = "Hyd";
            c1.email = "mani@456";
            c1.Display();

        }
    }
}
