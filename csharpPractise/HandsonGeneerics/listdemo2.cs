using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonGeneerics
{
    class Movie
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Actor { get; set; }
        public int Year { get; set; }
    }

    internal class listdemo2
    {
        static void Main()
        {

            Movie m1 = new Movie() {Id= 1, Name="RRR", Actor="NTR",Year= 2020 };
            List<Movie> l = new List<Movie>()
            {
                new Movie() {Id= 2, Name="RRR1", Actor="NTR",Year= 2021 },
                new Movie() {Id= 3, Name="RRR2", Actor="NTR",Year= 2022 },
                new Movie() {Id= 4, Name="RRR3", Actor="NTR",Year= 2023 }
            };
            l.Add(m1);
            l.Add(new Movie() { Id = 5, Name = "Pushpa", Actor = "AA", Year = 2024 });
            Movie m = l[3];
            Console.WriteLine(m);
            foreach(Movie m2 in l)
            {
                Console.WriteLine(m2.Name);
            }
            l.RemoveAt(1);
            foreach (Movie m2 in l)
            {
                Console.WriteLine(m2.Name);
            }


        }
    }
}
