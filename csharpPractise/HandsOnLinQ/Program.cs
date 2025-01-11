namespace HandsOnLinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //fetch values from array
            var res=from k in a where k%2==0 select k;
            foreach(var k in res)
            {
                Console.Write(k+"\t");
            }
            Console.WriteLine();
            IEnumerable<int> x= from k in a where k % 2 == 0 select k;
            foreach (var k in x)
            {
                Console.Write(k+"\t");
            }
            Console.WriteLine();
            var r1=a.Where(k=>k%2==0);
            foreach (var k in r1)
            {
                Console.Write(k + "\t");
            }
        }
    }
}
