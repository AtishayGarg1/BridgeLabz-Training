using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.inheritance
{
    //Superclass Book
    internal class Book
    {
        public string Title;
        public int PublicationYear;

        public Book(string title, int year)
        {
            Title = title;
            PublicationYear = year;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Title : " + Title);
            Console.WriteLine("Year  : " + PublicationYear);
        }
    }

    //Subclass Author
    class Author : Book
    {
        public string Name;
        public string Bio;

        public Author(string title, int year, string name, string bio)
            : base(title, year)
        {
            Name = name;
            Bio = bio;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Author: " + Name);
            Console.WriteLine("Bio   : " + Bio);
        }
    }

    class Program
    {
        static void Main()
        {
            Author a1 = new Author("Clean Code", 2008, "Robert Martin", "Software Engineer");
            a1.DisplayInfo();
        }
    }
}
