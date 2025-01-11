namespace csassignonLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = {5,6,7,3,4,10,12,15};
            var r = from i in a
                    let x = i * i * i
                    where x > 100 && x < 1000
                    select x;
            foreach (var x in r)
            {
                Console.WriteLine(x);
            }
           
        }
    }
}
