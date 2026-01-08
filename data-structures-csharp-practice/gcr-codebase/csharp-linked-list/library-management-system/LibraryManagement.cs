using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.librarymanagementsystem
{
    internal class LibraryManagement
    {
        private LibraryNode head;
        private LibraryNode tail;

        public LibraryManagement()
        {
            head = null;
            tail = null;
        }

        public void AddAtBeginning(int bookId, string title, string author, string genre, bool isAvailable)
        {
            LibraryNode node = new LibraryNode(bookId, title, author, genre, isAvailable);

            if (head == null)
            {
                head = tail = node;
                return;
            }

            node.next = head;
            head.prev = node;
            head = node;
        }

        public void AddAtEnd(int bookId, string title, string author, string genre, bool isAvailable)
        {
            LibraryNode node = new LibraryNode(bookId, title, author, genre, isAvailable);

            if (tail == null)
            {
                head = tail = node;
                return;
            }

            tail.next = node;
            node.prev = tail;
            tail = node;
        }

        public void AddAtPosition(int bookId, string title, string author, string genre, bool isAvailable, int position)
        {
            if (position <= 1)
            {
                AddAtBeginning(bookId, title, author, genre, isAvailable);
                return;
            }

            LibraryNode temp = head;
            int count = 1;

            while (temp != null && count < position - 1)
            {
                temp = temp.next;
                count++;
            }

            if (temp == null || temp.next == null)
            {
                AddAtEnd(bookId, title, author, genre, isAvailable);
                return;
            }

            LibraryNode node = new LibraryNode(bookId, title, author, genre, isAvailable);
            node.next = temp.next;
            node.prev = temp;
            temp.next.prev = node;
            temp.next = node;
        }

        public void RemoveByBookId(int bookId)
        {
            LibraryNode temp = head;

            while (temp != null)
            {
                if (temp.BookId == bookId)
                {
                    if (temp == head)
                    {
                        head = head.next;
                        if (head != null) head.prev = null;
                    }
                    else if (temp == tail)
                    {
                        tail = tail.prev;
                        tail.next = null;
                    }
                    else
                    {
                        temp.prev.next = temp.next;
                        temp.next.prev = temp.prev;
                    }
                    return;
                }
                temp = temp.next;
            }
        }

        public void SearchByTitle(string title)
        {
            LibraryNode temp = head;

            while (temp != null)
            {
                if (temp.BookTitle.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(temp);
                    return;
                }
                temp = temp.next;
            }
        }

        public void SearchByAuthor(string author)
        {
            LibraryNode temp = head;

            while (temp != null)
            {
                if (temp.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(temp);
                }
                temp = temp.next;
            }
        }

        public void UpdateAvailability(int bookId, bool status)
        {
            LibraryNode temp = head;

            while (temp != null)
            {
                if (temp.BookId == bookId)
                {
                    temp.IsAvailable = status;
                    return;
                }
                temp = temp.next;
            }
        }

        public void DisplayForward()
        {
            LibraryNode temp = head;

            while (temp != null)
            {
                Console.WriteLine(temp);
                temp = temp.next;
            }
        }

        public void DisplayReverse()
        {
            LibraryNode temp = tail;

            while (temp != null)
            {
                Console.WriteLine(temp);
                temp = temp.prev;
            }
        }

        public int CountBooks()
        {
            int count = 0;
            LibraryNode temp = head;

            while (temp != null)
            {
                count++;
                temp = temp.next;
            }

            return count;
        }
    }
}
