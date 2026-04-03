using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased
{
    internal class LibraryManagementSystem
    {
        static void Main(string[] args)
        {
            LibraryManagementSystem obj = new();
            obj.Run();
        }

        void Run()
        {
            if (!VerifyAdmin())
            {
                Console.WriteLine("Admin verification failed. Exiting program.");
                return;
            }
            int n = NumberOfBooks();
            string[,] books = new string[n, 3];
            books = InputBooks(books);
            string getBookName = GetBookName();
            string[] bookDetails = GetBookDetails(books, getBookName, n);

            books = CheckOutBook(bookDetails, books, n);
            DisplayAll(books);

        }

        bool VerifyAdmin()
        {
            Console.WriteLine("Admin Login");
            Console.WriteLine("Enter Admin ID:");
            string id = Console.ReadLine();

            Console.WriteLine("Enter Admin Password:");
            string password = Console.ReadLine();

            if (id.Equals("admin") && password.Equals("admin123"))
            {
                Console.WriteLine("Admin verified successfully\n");
                return true;
            }
            return false;
        }

        void DisplayAll(string[,] books)
        {
            for (int i = 0; i < books.GetLength(0); i++)
            {
                Console.WriteLine("\n\n" + (i + 1) + " book details");
                Console.WriteLine("title: " + books[i, 0]);
                Console.WriteLine("author: " + books[i, 1]);
                Console.WriteLine("Availability: " + books[i, 2]);
            }
        }

        bool IsAvailable(string name, string[,] books)
        {
            bool ans = false;
            for (int i = 0; i < books.GetLength(0); i++)
            {
                if (books[i, 0].Equals(name))
                {
                    ans = books[i, 2].Equals("true");
                    if (ans)
                    {
                        return ans;
                    }
                }
            }
            return ans;
        }
        string[,] CheckOutBook(string[] bookDetails, string[,] books, int n)
        {
            DisplayBookDetails(bookDetails, books, n);
            Console.WriteLine("Do You Want to Borrow a book true or false ");
            bool borrow = bool.Parse(Console.ReadLine());
            while (borrow)
            {
                Console.WriteLine("Enter Book Name");
                string bookName = Console.ReadLine();


                bool isAvailable = IsAvailable(bookName, books);
                if (isAvailable)
                {
                    Console.WriteLine("The Book is issued to you\n\n");
                    books = ChangeAvailability(bookName, books);
                    DisplayAll(books);
                }
                else
                {
                    Console.WriteLine("Book Is not Available");
                }
                Console.WriteLine("Do you want to borrow more Books \nEnter true or false");
                borrow = bool.Parse(Console.ReadLine());
            }
            return books;
        }

        string[,] ChangeAvailability(string name, string[,] books)
        {
            for (int i = 0; i < books.GetLength(0); i++)
            {
                if (books[i, 0].Contains(name))
                {
                    books[i, 2] = "false";
                }
            }
            return books;
        }

        void DisplayBookDetails(string[] bookdetails, string[,] books, int number)
        {
            for (int j = 0; j < bookdetails.Length; j++)
            {
                for (int i = 0; i < number; i++)
                {
                    if (bookdetails[j] == null)
                    {
                        continue;
                    }
                    if (books[i, 0].Contains(bookdetails[j]) && bookdetails[j] != null) ;
                    {
                        Console.WriteLine("\n\nTitle: " + books[j, 0]);
                        Console.WriteLine("Author: " + books[j, 1]);
                        Console.WriteLine("Availability: " + books[j, 2]);
                        break;
                    }
                }
            }
        }

        string[] GetBookDetails(string[,] books, string getBookName, int number)
        {
            string[] bookDetails = new string[number];
            int count = 0;
            for (int i = 0; i < number; i++)
            {
                if (books[i, 0].Contains(getBookName))
                {
                    bookDetails[i] = books[i, 0];
                    count++;
                }
                if (i == number - 1 && count == 0)
                {
                    Console.WriteLine("No Book Found");
                    return bookDetails;
                }
            }
            return bookDetails;
        }

        string GetBookName()
        {
            Console.WriteLine("Enter a Title to Search book");
            string str = Console.ReadLine();
            return str;
        }

        string[,] InputBooks(string[,] books)
        {
            for (int i = 0; i < books.GetLength(0); i++)
            {
                Console.WriteLine("\n\nEnter " + (i + 1) + " book's details");
                Console.WriteLine("Enter " + (i + 1) + " book's title");
                books[i, 0] = Console.ReadLine();
                Console.WriteLine("Enter " + (i + 1) + " book's author");
                books[i, 1] = Console.ReadLine();
                books[i, 2] = "true";
            }
            return books;
        }

        int NumberOfBooks()
        {
            Console.WriteLine("Enter Number Of Books");
            int Number = int.Parse(Console.ReadLine());
            return Number;
        }
    }
}
