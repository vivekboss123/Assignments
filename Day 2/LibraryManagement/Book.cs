using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Book
    {
        string title;
        string author;
        string genre;
        int quantity;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public Book(string Title , string Author , string Genre , int Quantity)
        {
            this.title = Title;
            this.author = Author;
            this.genre = Genre;
            this.quantity=Quantity;
        }

        public Book Create_book()
        {
            Book b=new Book(title,author,genre,quantity);
            return b;
        }


    }
        

}
