using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class Item
    {
        private string name;
        private int price;
        private int quantity;
        private double totalprice;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }    
            set { quantity = value; }
        }
        public double TotalPrice
        {
            get
            {
            return totalprice;
            }
            set { totalprice = value; }
        }
        public Item(string name, int price, int quantity) 
        { 
            this.name = name;   
            this.price = price;
            this.quantity = quantity;
        }
        public double CalPrice()
        {
            totalprice = Quantity * price;
            return totalprice;

        }
        public void Display_Details()
        {
            Console.WriteLine("********** Shopping Cart Details *********");
            Console.WriteLine($"The name of the product is              :{Name}");
            Console.WriteLine($"The price of the product is             :{Price}");
            Console.WriteLine($"The quantity of the product is          :{Quantity}");
            Console.WriteLine($"The total price of the shopping cart is :{TotalPrice}");
        }
       
    }

}
