using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructors
{
    internal class LibraryBookSystem
    {
        // Instance variables
        public string title;
        public string author;
        public int price;
        public string availability;

        // Parameterized constructor
        public LibraryBookSystem(string title, string author, int price, string availability)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.availability = availability;
        }

        // Default constructor
        public LibraryBookSystem()
        {
            title = "Harry Potter and the philosopher's stone";
            author = "J.K. Rowling";
            price = 1399;
            availability = "true";
        }

        // Method to check availability and borrow book
        public void BorrowBook()
        {
            if (availability.ToLower() == "true")
            {
                Console.WriteLine("Title: " + title);
                Console.WriteLine("Author: " + author);
                Console.WriteLine("Price: " + price);
            }
            else
            {
                Console.WriteLine("Sorry The Book Is not Available\n");
            }
        }
    }

    // Main execution class
    class run
    {
        static void Main(string[] args)
        {
            LibraryBookSystem libraryBookSystem = new("The Alchemist", "Paulo Coelho", 999, "false");
            libraryBookSystem.BorrowBook();

            LibraryBookSystem libraryBookSystem2 = new();
            libraryBookSystem2.BorrowBook();
        }
    }
}
