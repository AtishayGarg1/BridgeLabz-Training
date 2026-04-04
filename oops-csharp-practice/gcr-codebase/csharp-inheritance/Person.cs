using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.inheritance
{

    // Superclass
    internal class Person
    {
        // Common attributes
        public string Name;
        public int Age;

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Virtual method
        public virtual void DisplayRole()
        {
            Console.WriteLine("Person in the school");
        }
    }

    // Teacher subclass
    class Teacher : Person
    {
        public string Subject;

        public Teacher(string name, int age, string subject)
            : base(name, age)
        {
            Subject = subject;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Role   : Teacher");
            Console.WriteLine("Name   : " + Name);
            Console.WriteLine("Age    : " + Age);
            Console.WriteLine("Subject: " + Subject);
        }
    }

    // Student subclass
    class Student : Person
    {
        public string Grade;

        public Student(string name, int age, string grade)
            : base(name, age)
        {
            Grade = grade;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Role  : Student");
            Console.WriteLine("Name  : " + Name);
            Console.WriteLine("Age   : " + Age);
            Console.WriteLine("Grade : " + Grade);
        }
    }

    // Staff subclass
    class Staff : Person
    {
        public string Department;

        public Staff(string name, int age, string department)
            : base(name, age)
        {
            Department = department;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Role       : Staff");
            Console.WriteLine("Name       : " + Name);
            Console.WriteLine("Age        : " + Age);
            Console.WriteLine("Department : " + Department);
        }
    }

    // Main class
    class Program
    {
        static void Main()
        {
            // Hierarchical inheritance demonstration
            Person p1 = new Teacher("Mr. Sharma", 40, "Mathematics");
            Person p2 = new Student("Atishay Garg", 21, "A");
            Person p3 = new Staff("Ramesh", 45, "Administration");

            p1.DisplayRole();
            Console.WriteLine();

            p2.DisplayRole();
            Console.WriteLine();

            p3.DisplayRole();
        }
    }
}
