namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Book book;
            int choice;
            do
            {
                Console.WriteLine("_______________MENU____________________________________________________");
                Console.WriteLine("Press 1 to Add Books");
                Console.WriteLine("Press 2 to Display book");
                Console.WriteLine("Press 3 to Search Books by title");
                choice=Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Title of the book");
                        string Title = Console.ReadLine().ToLower();
                        Console.WriteLine("Enter the name of Author");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Enter the name of Genre");
                        string Genre = Console.ReadLine();
                        Console.WriteLine("Enter the Quantity");
                        int Quantity = Convert.ToInt32(Console.ReadLine());
                        book = new Book(Title, Name, Genre, Quantity);
                        library.Add_Books(book);
                        break;
                    case 2:
                        library.Display_Books();
                        break;
                    case 3:
                        Console.WriteLine("Enter the Title of the book");
                        string Titles = Console.ReadLine().ToLower();
                        
                        library.SearchbyTitle(Titles);
                        break;
                    default:
                        break;

                }

            }
            while (choice != 0);
 
        }
    }
}