using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.librarymanagementsystem
{
    internal class LibraryNode
    {
        public int BookId;
        public string BookTitle;
        public string Author;
        public string Genre;
        public bool IsAvailable;

        public LibraryNode next;
        public LibraryNode prev;

        public LibraryNode(int bookId, string bookTitle, string author, string genre, bool isAvailable)
        {
            BookId = bookId;
            BookTitle = bookTitle;
            Author = author;
            Genre = genre;
            IsAvailable = isAvailable;
            next = null;
            prev = null;
        }

        public override string ToString()
        {
            return $"Book ID: {BookId}\nTitle: {BookTitle}\nAuthor: {Author}\nGenre: {Genre}\nAvailable: {IsAvailable}";
        }
    }
}
