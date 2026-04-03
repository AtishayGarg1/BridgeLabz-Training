using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.LibraryManagementSystem
{
    internal class Program
    {
        static void Main()
        {
            Book book = new Book();
            book.ItemId = 1;
            book.Title = "Clean Code";
            book.Author = "Robert C. Martin";

            Magazine magazine = new Magazine();
            magazine.ItemId = 2;
            magazine.Title = "Time";
            magazine.Author = "Time Editors";

            DVD dvd = new DVD();
            dvd.ItemId = 3;
            dvd.Title = "Inception";
            dvd.Author = "Christopher Nolan";

            LibraryItem[] items = new LibraryItem[3];
            items[0] = book;
            items[1] = magazine;
            items[2] = dvd;

            LibraryService.ProcessItems(items);

            book.ReserveItem("Atishay");
        }
    }
}
