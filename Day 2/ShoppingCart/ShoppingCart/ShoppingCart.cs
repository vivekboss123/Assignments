using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class ShoppingCart
    {
        List<Item> items = new List<Item>();
        private double total_price = 0;
        public void Add()
        {
            Console.WriteLine("Enter the Name of the product :");
            String name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Price of the Product :");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quatity of the Product :");
            int Quantity = Convert.ToInt32(Console.ReadLine());

            Item newitem = new Item(name,price,Quantity);
            items.Add(newitem);
            this.total_price += newitem.CalPrice(); 
            
        }
        public void Display_Items() 
        {
            foreach (Item item in items)
            {
                item.Display_Details();
            }
        }
    }
    
}
