using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.moviemanagementsystem
{
    internal class MovieManagement
    {
        private MovieNode head;
        private MovieNode tail;

        public MovieManagement()
        {
            head = null;
            tail = null;
        }

        public void AddAtBeginning(string movieName, string directorName, int releaseYear, double movieRating)
        {
            MovieNode node = new MovieNode(movieName, directorName, releaseYear, movieRating);

            if (head == null)
            {
                head = tail = node;
                return;
            }

            node.next = head;
            head.prev = node;
            head = node;
        }

        public void AddAtEnd(string movieName, string directorName, int releaseYear, double movieRating)
        {
            MovieNode node = new MovieNode(movieName, directorName, releaseYear, movieRating);

            if (tail == null)
            {
                head = tail = node;
                return;
            }

            tail.next = node;
            node.prev = tail;
            tail = node;
        }

        public void AddAtPosition(string movieName, string directorName, int releaseYear, double movieRating, int position)
        {
            if (position <= 1)
            {
                AddAtBeginning(movieName, directorName, releaseYear, movieRating);
                return;
            }

            MovieNode curr = head;
            int index = 1;

            while (curr != null && index < position - 1)
            {
                curr = curr.next;
                index++;
            }

            if (curr == null || curr.next == null)
            {
                AddAtEnd(movieName, directorName, releaseYear, movieRating);
                return;
            }

            MovieNode node = new MovieNode(movieName, directorName, releaseYear, movieRating);
            node.next = curr.next;
            node.prev = curr;
            curr.next.prev = node;
            curr.next = node;
        }

        public void RemoveByMovieName(string movieName)
        {
            MovieNode curr = head;

            while (curr != null)
            {
                if (curr.MovieName.Equals(movieName, StringComparison.OrdinalIgnoreCase))
                {
                    if (curr == head)
                    {
                        head = head.next;
                        if (head != null) head.prev = null;
                    }
                    else if (curr == tail)
                    {
                        tail = tail.prev;
                        tail.next = null;
                    }
                    else
                    {
                        curr.prev.next = curr.next;
                        curr.next.prev = curr.prev;
                    }
                    return;
                }
                curr = curr.next;
            }
        }

        public void SearchByDirector(string directorName)
        {
            MovieNode curr = head;

            while (curr != null)
            {
                if (curr.DirectorName.Equals(directorName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(curr);
                }
                curr = curr.next;
            }
        }

        public void SearchByRating(double rating)
        {
            MovieNode curr = head;

            while (curr != null)
            {
                if (curr.MovieRating >= rating)
                {
                    Console.WriteLine(curr);
                }
                curr = curr.next;
            }
        }

        public void UpdateRating(string movieName, double newRating)
        {
            MovieNode curr = head;

            while (curr != null)
            {
                if (curr.MovieName.Equals(movieName, StringComparison.OrdinalIgnoreCase))
                {
                    curr.MovieRating = newRating;
                    return;
                }
                curr = curr.next;
            }
        }

        public void DisplayForward()
        {
            MovieNode curr = head;

            while (curr != null)
            {
                Console.WriteLine(curr);
                curr = curr.next;
            }
        }

        public void DisplayReverse()
        {
            MovieNode curr = tail;

            while (curr != null)
            {
                Console.WriteLine(curr);
                curr = curr.prev;
            }
        }
    }
}
