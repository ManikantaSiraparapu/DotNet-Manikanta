using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace csassign4
{
    internal class Book
    {
        
        private int ISBN {  get; set; }
        private string Bname {  get; set; }
        private string Btitle {  get; set; }
        private string Bauthor {  get; set; }
        private int qty {  get; set; }
        private double Bprice {  get; set; }

        public Book(int id,string bname,string btitle,string bauthor,int qty,double bprice)
        {
            this.ISBN = id;
            this.Bname = bname;
            this.Btitle = btitle;
            this.Bauthor = bauthor;
            this.qty = qty;
            this.Bprice = bprice;
        }
        public double billAmount()
        {
            return qty * Bprice;
        }
        public void Display()
        {
            Console.WriteLine($"Book ISBN : {ISBN}");
            Console.WriteLine($"Book name : {Bname}");
            Console.WriteLine($"Book title : {Btitle}");
            Console.WriteLine($"Book author : {Bauthor}");
            Console.WriteLine($"Book Quantity : {qty}");
            Console.WriteLine($"Book price : {Bprice}");
        }
        static void Main()
        {
            List<Book> list = new List<Book>();
            double bill = 0;
            Console.WriteLine("Enter number of books");
            int x=int.Parse(Console.ReadLine());
            for(int i = 0; i < x; i++)
            {
                Console.WriteLine($"\nEnter details for Book {i + 1}:");

                Console.Write("Enter ISBN: ");
                int isbn =int.Parse( Console.ReadLine());

                Console.Write("Enter Book Name: ");
                string bookName = Console.ReadLine();

                Console.Write("Enter Book Title: ");
                string bookTitle = Console.ReadLine();

                Console.Write("Enter Book Author: ");
                string bookAuthor = Console.ReadLine();

                Console.Write("Enter Quantity of Books: ");
                int quantity = int.Parse(Console.ReadLine());

                Console.Write("Enter Book Price: ");
                double price = double.Parse(Console.ReadLine());

                // Create a new Book object and add it to the list
                Book book = new Book(isbn, bookName, bookTitle, bookAuthor, quantity, price);
                list.Add(book);

                // Add the book's total price to the totalAmount
                bill += book.billAmount();
            }

            // Displaying details for all books and the total bill amount
            Console.WriteLine("\nBook Details:");
            foreach (Book book in list)
            {
                book.Display();
                Console.WriteLine();
            }

            // Display the total amount for all books
            Console.WriteLine($"Total Bill Amount for all books: ${bill:F2}");
        }
    }

}
