namespace ShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            ShoppingCart cart = new ShoppingCart();
            do
            { 
                Console.WriteLine("Enter 1 to enter the cart ");
                Console.WriteLine("Enter 2 to display the cart");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) 
                {
                    case 1:
                        cart.Add();

                        break;

                        case 2:
                        cart.Display_Items();
                        break;  

                        default: Console.WriteLine("This is a wrong input ");
                        break;
                
                }


            } while (choice != 0);
        }
    }
}