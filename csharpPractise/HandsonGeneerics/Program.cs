namespace HandsonGeneerics
{
    //Generic class
    class Sample<T>
    {
        //generic variable
        public T i;
        public T j;
        public void m(T a, T b)
        {
            i = a;
            j = b;
        }
        public T m1(T a)
        {
            return a;
        }
        public void show()
        {
            Console.WriteLine($"i={i} j={j}");
        }
    }
        internal class Program
        {
        
        static void Main(string[] args)
        {
                Sample<int> s = new Sample<int>();
                s.m(1, 2);
                s.m1(100);
                s.show();
                
                Sample<string> s2 = new Sample<string>();
                s2.m("Hi", "Hello");
                s2.m1("Mani");
                s2.show();
        }
    }
}
