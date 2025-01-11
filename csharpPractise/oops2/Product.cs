using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace oops2
{
    //Entity Class
    internal class Product
    {
        public int id;
        public string name;
        public int price;
    }
    class ProductRepository
    {
        public Product[] list = new Product[5];
        int count = 0;
        public void Add(Product product)
        {
            if (count < list.Length)
            {
                list[count] = product;
                count++;
            }
            else
            {
                Console.WriteLine("List is Full!!");
            }
        }
        //Search a Product by Name
        public Product SearchProduct(string name)
        {
            foreach (Product product in list)
            {
                if (product != null)
                {
                    if (product.name == name)
                    {
                        return product;
                    }
                }
            }
            return null;
        }
        //Return All the Products
        public Product[] GetProducts()
        {
            return list;
        }
        public void Update(int id, int price)
        {
            foreach (Product product in list)
            {
                if (product != null)
                {
                    if (product.id == id)
                    {
                        product.price = price;
                    }
                }
            }

        }

    }
    class Test
    {
        static void Main()
        {
            ProductRepository repository = new ProductRepository();
            do
            {
                Console.WriteLine("1.Add\n2.GetProduct\n3.GetAllProducts\n4.Update\n5.Exit");
                Console.WriteLine("Enter Option");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            //Add Product
                            Product product = new Product();
                            Console.WriteLine("Enter Id");
                            product.id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Name");
                            product.name = Console.ReadLine();
                            Console.WriteLine("Enter Price");
                            product.price = int.Parse(Console.ReadLine());
                            repository.Add(product);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter Name");
                            string name = Console.ReadLine();
                            Product product = repository.SearchProduct(name);
                            if (product != null)
                            {
                                Console.WriteLine("Price: " + product.price);
                            }
                            else
                            {
                                Console.WriteLine("Product Not Exisit!!");
                            }
                        }
                        break;
                    case 3:
                        {
                            foreach (Product product in repository.GetProducts())
                            {
                                if (product != null)
                                {
                                    Console.WriteLine($"Name:{product.name} Price:{product.price}");
                                }
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter Id");
                            int id = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Price");
                            int price = int.Parse(Console.ReadLine());
                            repository.Update(id, price);
                        }
                        break;
                    case 5:
                        {
                            Environment.Exit(0); //terminated the app
                        }
                        break;
                }
            } while (true);
        }
    }
}