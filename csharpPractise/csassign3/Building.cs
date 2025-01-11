using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csassign3
{
    internal class Building
    {
        public string type;
        public string capacity;
        public string dimension;
        public string DOC;
       
        public Building(string type,string capacity,string dimension,string DOC)
        {
            this.type = type;
            this.capacity = capacity;
            this.dimension = dimension;
            this.DOC = DOC;
        }
        public void Display()
        {
            Console.WriteLine($"Building Type : {type}");
            Console.WriteLine($"Capacity : {capacity}");
            Console.WriteLine($"Dimension : {dimension}");
            Console.WriteLine($"Date Of Completion : {DOC}");
        }
        static void Main()
        {
            Building flat = new Building("Flat", "3BHK", "floor 5","23-08-2002");
            flat.Display();
            Building villa = new Building("Villa", "4BHK", "60x70","23-08-2002");
            villa.Display();
        }
       
    }
}
