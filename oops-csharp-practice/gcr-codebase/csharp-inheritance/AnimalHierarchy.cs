using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.inheritance
{
    //Superclassx
    internal class AnimalHierarchy
    {
        //Common attributes
        public string Name { get; set; }
        public int Age { get; set; }

        //Constructor
        public AnimalHierarchy(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //Virtual method
        public virtual void MakeSound()
        {
            Console.WriteLine("AnimalHierarchy makes a sound");
        }
    }

    //Subclass Dog
    class Dog : AnimalHierarchy
    {
        public Dog(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    //Subclass Cat
    class Cat : AnimalHierarchy
    {
        public Cat(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    //Subclass Bird
    class Bird : AnimalHierarchy
    {
        public Bird(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine("Bird chirps");
        }
    }

    //Main class
    class Program
    {
        static void Main()
        {
            //Polymorphism demonstration
            AnimalHierarchy animal1 = new Dog("Buddy", 3);
            AnimalHierarchy animal2 = new Cat("Whiskers", 2);
            AnimalHierarchy animal3 = new Bird("Tweety", 1);

            animal1.MakeSound();
            animal2.MakeSound();
            animal3.MakeSound();
        }
    }
}
