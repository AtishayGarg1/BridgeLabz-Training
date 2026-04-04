using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.librarymanagementsystem
{
    internal class LibrarayMain
    {
        static void Main(string[] args)
        {
            LibraryManagement library = new LibraryManagement();

            library.AddAtEnd(1, "Clean Code", "Robert Martin", "Programming", true);
            library.AddAtEnd(2, "The Hobbit", "J.R.R. Tolkien", "Fantasy", true);
            library.AddAtEnd(3, "1984", "George Orwell", "Dystopian", false);

            library.DisplayForward();

            library.AddAtPosition(4, "The Pragmatic Programmer", "Andrew Hunt", "Programming", true, 2);
            library.DisplayForward();

            library.SearchByTitle("1984");
            library.SearchByAuthor("Robert Martin");

            library.UpdateAvailability(3, true);
            library.DisplayForward();

            library.DisplayReverse();

            Console.WriteLine("Total Books: " + library.CountBooks());

            library.RemoveByBookId(1);
            library.DisplayForward();
        }
    }
}
