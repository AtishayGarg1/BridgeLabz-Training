using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.inheritance
{   
    //Base class
    internal class Employee
    {
        //Common attributes
        public string Name;
        public int Id;
        public double Salary;

        //Constructor
        public Employee(string name, int id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        //Virtual method
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Name   : " + Name);
            Console.WriteLine("ID     : " + Id);
            Console.WriteLine("Salary : " + Salary);
        }
    }

    //Manager subclass
    class Manager : Employee
    {
        public int TeamSize;

        public Manager(string name, int id, double salary, int teamSize)
            : base(name, id, salary)
        {
            TeamSize = teamSize;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Team Size: " + TeamSize);
        }
    }

    //Developer subclass
    class Developer : Employee
    {
        public string ProgrammingLanguage;

        public Developer(string name, int id, double salary, string language)
            : base(name, id, salary)
        {
            ProgrammingLanguage = language;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Language: " + ProgrammingLanguage);
        }
    }

    //Intern subclass
    class Intern : Employee
    {
        public string InternshipDuration;

        public Intern(string name, int id, double salary, string duration)
            : base(name, id, salary)
        {
            InternshipDuration = duration;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Duration: " + InternshipDuration);
        }
    }

    class Program
    {
        static void Main()
        {
            Employee e1 = new Manager("Atishay", 101, 80000, 5);
            Employee e2 = new Developer("Rohit", 102, 70000, "C#");
            Employee e3 = new Intern("Amit", 103, 15000, "6 Months");

            e1.DisplayDetails();
            Console.WriteLine();

            e2.DisplayDetails();
            Console.WriteLine();

            e3.DisplayDetails();
        }
    }
}
