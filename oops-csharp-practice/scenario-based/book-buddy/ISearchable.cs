using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.BookBuddy
{
    internal interface ISearchable
    {
        void AddBook(string bookName, string bookAuthor);
        void SortBooksAlphabetically();
        void SearchByAuthor(string bookAuthor);
        void InitializeBook();
        void DisplayAllBooks();


    }
}
