namespace csharpnewfeatures
{
    public class Book
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }
    }
        internal class Program
    {
        
        static void Main(string[] args)
        {
            Book book = new Book() { Id = 1 ,Name="a.net"};
            Console.WriteLine($"Id:{book.Id} Name:{book.Name} Price:{book.Price}");
            //Nullable types
            int? k = null;
            double? Price = null;
        }
    }
}
