using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csassign2
{
    internal class Book
    {
        public int bookId;
        public string Bname;
        public string Btitle;
        public string Bauthor;
        public int Qty;
        public double Bprice;

        public Book(int a,string b,string c,string d,int e,double f)
        {
            this.bookId = a;
            this.Bname = b;
            this.Btitle = c;
            this.Bauthor = d;
            this.Qty = e;
            this.Bprice = f;
        }
        public void Display()
        {
            Console.WriteLine("Book ID: " + bookId);
            Console.WriteLine("Book Name: " + Bname);
            Console.WriteLine("Book Title: " + Btitle);
            Console.WriteLine("Book Author: " + Bauthor);
            Console.WriteLine("Quantity of Books: " + Qty);
            Console.WriteLine("Book Price: $" + Bprice);
        }
        public void  BillAmt()
        {
            double bill=Qty*Bprice;
            Console.WriteLine($"Bill Amount is {bill}");
        }
        public static void Main()
        {
            Book b = new Book(1,"Hello","Ewwww","SSR",10,20);
            Console.WriteLine("Book details");
            b.Display();
            Console.WriteLine("Bill details");
            b.BillAmt();
        }
    }
}
