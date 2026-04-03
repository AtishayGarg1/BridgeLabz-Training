using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.csharp_class
{
    internal class BookHandling
    {
        private string title;
        private string author;
        private int price;

        public BookHandling(string title, string author, int price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public void DisplayBookDetails()
        {
            Console.WriteLine("Book Details:");
            Console.WriteLine("Title  : " + title);
            Console.WriteLine("Author : " + author);
            Console.WriteLine("Price  : " + price);
        }
    }

    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author Name: ");
            string author = Console.ReadLine();

            Console.Write("Enter Book Price: ");
            int price = int.Parse(Console.ReadLine());

            BookHandling book = new BookHandling(title, author, price);
            book.DisplayBookDetails();
        }
    }
}
