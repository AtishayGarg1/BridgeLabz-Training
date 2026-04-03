using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.BookBuddy
{
    internal class BookShelf
    {
        private string bookName;
        private string bookAuthor;

        public string BookName { get => bookName; set => bookName = value; }
        public string BookAuthor { get => bookAuthor; set => bookAuthor = value; }

        public override string? ToString()
        {
            return "Book Title: " + bookName + "\nAuthor: " + bookAuthor+"\n";
        }
    }
}
