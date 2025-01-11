namespace HandsOnDelegates
{
    //create a delegate
    public delegate void mydelegate();
    public delegate void greetdelegate(string s);
    internal class Program
    {
        public void Message()
        {
            Console.WriteLine("Hello !!!");
        }
        public static void greet(string s)
        {
            Console.WriteLine("Welcome "+s);
        }
        
        static void Main(string[] args)
        {
            Program obj= new Program();
            obj.Message();
            //create object to delegate
            mydelegate md = new mydelegate(obj.Message);
            //invoking delegate
            md();
            greetdelegate d1=new greetdelegate(greet);
            d1("Mani");
            d1("Sai");

            
        }
    }
}
