using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Library
    {
        List<Book> books = new List<Book>();
        public void Add_Books(Book book)
        {
            books.Add(book);
            
        }
        public void Display_Books()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"Book Title : {book.Title} \t Book author : {book.Author} \n Book Genre :{book.Genre} \t Quantity : {book.Quantity}");
            }

        }
        public void SearchbyTitle(string Title)
        {
            foreach(Book book in books)
            {
                if(book.Title == Title)
                {
                    Console.WriteLine($"{book.Title} is present in this library");
                    return;
                }
            }
            Console.WriteLine($"{Title} is not present in this libary");

        }
    }
}
