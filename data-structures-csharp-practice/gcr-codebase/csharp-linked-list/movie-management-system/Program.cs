using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.moviemanagementsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieManagement movieManagement = new MovieManagement();

            movieManagement.AddAtEnd("Inception", "Christopher Nolan", 2010, 8.8);
            movieManagement.AddAtEnd("Interstellar", "Christopher Nolan", 2014, 8.6);
            movieManagement.AddAtEnd("Avatar", "James Cameron", 2009, 7.9);
            movieManagement.AddAtEnd("Titanic", "James Cameron", 1997, 7.8);

            movieManagement.DisplayForward();

            movieManagement.AddAtPosition("The Dark Knight", "Christopher Nolan", 2008, 9.0, 2);
            movieManagement.DisplayForward();

            movieManagement.SearchByDirector("Christopher Nolan");

            movieManagement.UpdateRating("Avatar", 8.2);
            movieManagement.DisplayForward();

            movieManagement.RemoveByMovieName("Titanic");
            movieManagement.DisplayForward();

            movieManagement.DisplayReverse();
        }
    }
}
