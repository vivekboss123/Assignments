using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Linq;

namespace OnlineStoreApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int choice = 0;
            Store store = new Store();
        

            do
            {
                Console.WriteLine("_____________MENU_____________");
                Console.WriteLine("Press 1 to Add Product");
                Console.WriteLine("Press 2 to Display Product");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        Console.WriteLine("Enter the name of product");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the price of the product");
                        int price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the quantity in stock of the prouduct");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the category of the product");
                        string category = Console.ReadLine();
                        Product product1 = new Product();
                        Product p1 = product1.CreateProduct(name, price, quantity, category);
                        store.AddProduct(p1);








                        break;
                    case 2:
                        Console.WriteLine("The detail of the product is");
                        
                        store.Display_Product();
                        break;
                    case 3:
                        Console.WriteLine("Total value of products are: ");
                        Console.WriteLine(store.TotalPrice());
                        break;
                    default:
                        break;



                }
            }
            while(choice != 0);
        }
    }
}