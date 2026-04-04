using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructors
{
    public class UniversityManagement
    {
        // Instance variables
        public int rollNumber;
        protected string name;
        private double cgpa;

        // Parameterized constructor
        public UniversityManagement(int rollNumber, string name, double cgpa)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.cgpa = cgpa;
        }

        // Getter for CGPA
        public double GetCGPA()
        {
            return cgpa;
        }

        // Setter for CGPA with validation
        public void SetCGPA(double cgpa)
        {
            if (cgpa < 10.0 && cgpa > 0.0)
            {
                this.cgpa = cgpa;
            }
            else
            {
                Console.WriteLine("Invalid CGPA. Must Be between 0 and 10.");
            }
        }

        // Display student details
        public void DisplayDetails()
        {
            Console.WriteLine("Student Roll Number: " + rollNumber);
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student CGPA: " + cgpa);
        }
    }

    // Derived class
    public class DerivedUniversityManagement : UniversityManagement
    {
        public DerivedUniversityManagement(int rollNumber, string name, double cgpa)
            : base(rollNumber, name, cgpa) { }
    }

    // Main execution class
    class run
    {
        static void Main(string[] args)
        {
            UniversityManagement obj1 = new(29, "Atishay", 7.95);
            obj1.DisplayDetails();

            obj1.SetCGPA(8.1);
            Console.WriteLine("Updated CGPA: " + obj1.GetCGPA());

            obj1.DisplayDetails();
        }
    }
}
