using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.LibraryManagementSystem
{
    internal abstract class LibraryItem
    {
        protected int itemId;
        protected string title;
        protected string author;

        private string borrowerName;
        private bool isBorrowed;

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        protected void SetBorrower(string name)
        {
            borrowerName = name;
            isBorrowed = true;
        }

        protected bool IsBorrowed()
        {
            return isBorrowed;
        }

        public abstract int GetLoanDuration();

        public void GetItemDetails()
        {
            Console.WriteLine($"ID: {ItemId}, Title: {Title}, Author: {Author}");
        }
    }
}
