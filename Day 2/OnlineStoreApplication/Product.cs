using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreApplication
{
    internal class Product
    {
        string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        string Category { get; set; }
        
        public Product CreateProduct(string name, int price, int quantity, string category)
        {
            Product product = new Product() { Name = name, Price = price, Quantity = quantity, Category = category };
            
            return product;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name} Price: {Price} Quantity: {Quantity} Category: {Category}");
        }
        


    }
}
