namespace interfaces
{
    public interface Ishape
    {
        void Area();
        int sides { get; }
    }
    public class Rectangle : Ishape
    {
        public void Area()
        {
            Console.WriteLine("Area of rectangle find here");
        }
        public int sides { get { return 4; } }
    }
    public class Triangle : Ishape
    {
        public void Area()
        {
            Console.WriteLine("Area of triangle find here");
        }
        public int sides { get { return 3; } }
        public void Message()
        {
            Console.WriteLine("Hello");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ishape o1 = new Rectangle();
            o1.Area();
            Console.WriteLine(o1.sides);
            Ishape o2= new Triangle();
            o2.Area();
            Console.WriteLine(o1.sides);
            Triangle triangle = new Triangle();
            triangle.Message();
        }
    }
}
