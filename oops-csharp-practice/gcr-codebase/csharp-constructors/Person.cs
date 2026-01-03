using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructors
{
    internal class Person
    {
        // Instance variables
        int age;
        int weight;
        int height;

        // Parameterized constructor
        public Person(int age, int weight, int height)
        {
            this.age = age;
            this.weight = weight;
            this.height = height;
        }

        // Copy constructor
        public Person(Person person)
        {
            age = person.age;
            weight = person.weight;
            height = person.height;
        }

        // Display person details
        public void Display()
        {
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Weight: " + height);
            Console.WriteLine("Height: " + weight);
        }
    }

    // Main execution class
    class run
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parameterized");
            Person person1 = new Person(21, 88, 170);
            person1.Display();

            Console.WriteLine("\nCopy");
            Person person2 = new Person(person1);
            person2.Display();
        }
    }
}
