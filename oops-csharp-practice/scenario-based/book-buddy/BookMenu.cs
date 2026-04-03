using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.BookBuddy
{
    internal class BookMenu
    {
        private ISearchable bookUtility;
        public void Menu()
        {
            bookUtility = new BookUtilityImpl();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===== 📚 BookBuddy Menu =====");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Display All Books");
                Console.WriteLine("3. Sort Books Alphabetically");
                Console.WriteLine("4. Search Book by Author");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                bool isValid = int.TryParse(Console.ReadLine(), out choice);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        bookUtility.InitializeBook();
                        break;

                    case 2:
                        bookUtility.DisplayAllBooks();
                        break;

                    case 3:
                        bookUtility.SortBooksAlphabetically();
                        Console.WriteLine("Books sorted successfully.");
                        break;

                    case 4:
                        Console.Write("Enter author name to search: ");
                        string author = Console.ReadLine();
                        bookUtility.SearchByAuthor(author);
                        break;

                    case 5:
                        exit = true;
                        Console.WriteLine("Exiting BookBuddy. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
