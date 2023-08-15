using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OnlineStoreApplication
{
    internal class Store
    {
        List<Product> productList = new List<Product>();
        int total=1;
        public  void AddProduct(Product product)
        {
            productList.Add(product);

        }




        public void Display_Product()
        {
            foreach (var item in productList)
            {
                item.Print();
                Console.WriteLine(this.total);
            }

        }
        public int TotalPrice()
        {
            foreach(var item in productList)
            {
                total = item.Price * item.Quantity;
            }
            return total;
        }
    }
}
