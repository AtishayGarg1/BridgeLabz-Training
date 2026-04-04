using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.BookBuddy
{
    internal class BookUtilityImpl : ISearchable
    {
        private BookShelf BookShelf;
        private BookShelf[] BookShelves = new BookShelf[10];
        private int count = 0;

        public void AddBook(string bookName,string bookAuthor)
        {
            BookShelf = new BookShelf();
            BookShelf.BookName = bookName;
            BookShelf.BookAuthor = bookAuthor;
            BookShelves[count++] = BookShelf;
        }

        public void InitializeBook()
        {
            Console.WriteLine("Enter Book Name and Author Seperated by hyphen");
            string bookDetail = Console.ReadLine();
            string bookName = bookDetail.Split("-")[0];
            string bookAuthor= bookDetail.Split("-")[1];
            AddBook(bookName,bookAuthor);
        }
        public void SortBooksAlphabetically()
        {
            if(count < 2)
            {
                return;
            }
            for(int i = 0;i < count; i++)
            {
                for(int j = i + 1; j < count; j++)
                {
                    if (string.Compare(BookShelves[i].BookName,BookShelves[j].BookName) > 0)
                    {
                        BookShelf temp = BookShelves[i];
                        BookShelves[i] = BookShelves[j];
                        BookShelves[j] = temp;
                    }
                }
            }
            DisplayAllBooks();
        }
        public void SearchByAuthor(string bookName)
        {
            for(int i = 0; i < count; i++)
            {
                if (BookShelves[i].BookAuthor.ToLower().Contains(bookName.ToLower()))
                {
                    Console.WriteLine(BookShelves[i].ToString());
                }
            }
        }

        public void DisplayAllBooks()
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(BookShelves[i].ToString());
            }
        }

    }
}
