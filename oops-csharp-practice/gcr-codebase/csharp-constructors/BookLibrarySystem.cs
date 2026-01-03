using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructors
{
    internal class BookLibrarySystem
    {
        // Instance variables
        public int isbn;
        protected string title;
        private string author;

        // Getter for author
        public string GetAuthor()
        {
            return author;
        }

        // Setter for author
        public void SetAuthor(string author)
        {
            this.author = author;
        }

        // Constructor
        public BookLibrarySystem(int isbn, string title, string author)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
        }

        // Display book details
        public void DisplayDetails()
        {
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
        }
    }

    // Derived class
    class ebook : BookLibrarySystem
    {
        public ebook(int isbn, string title, string author)
            : base(isbn, title, author) { }
    }

    // Main execution class
    class run
    {
        static void Main(string[] args)
        {
            BookLibrarySystem obj1 = new(12345, "Harry Potter", "J.J. rowing");
            obj1.DisplayDetails();

            obj1.SetAuthor("J.K. Rowling");
            Console.WriteLine("Updated: " + obj1.GetAuthor());
            obj1.DisplayDetails();
        }
    }
}
