using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.moviemanagementsystem
{
    internal class MovieNode
    {
        public string MovieName;
        public string DirectorName;
        public int ReleaseYear;
        public double MovieRating;

        public MovieNode next;
        public MovieNode prev;

        public MovieNode(string MovieName,string DirectorName,int ReleaseYear,double MovieRating)
        {
            this.MovieName = MovieName;
            this.DirectorName = DirectorName;
            this.ReleaseYear = ReleaseYear;
            this.MovieRating = MovieRating;

            this.next = null;
            this.prev = null;
        }

        public override string? ToString()
        {
            return $"Movie Title: {MovieName}\nDirector Name: {DirectorName}\nRelease Year: {ReleaseYear}\nMovie Rating: {MovieRating}";
        }
    }
}
