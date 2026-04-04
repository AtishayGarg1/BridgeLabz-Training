using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.thisstatic
{
    internal class UniversityStudentManagement
    {
        // Static variable
        public static string universityName = "XYZ University";

        // Static variable to count total students
        private static int totalStudents = 0;

        // Readonly variable 
        public readonly int rollNumber;

        // Instance variables
        public string name;
        public char grade;

        // Constructor using this keyword
        public UniversityStudentManagement(int rollNumber, string name, char grade)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.grade = grade;
            totalStudents++;
        }

        // Static method to display total students
        public static void DisplayTotalStudents()
        {
            Console.WriteLine("Total Students: " + totalStudents);
        }

        // Display student details using is operator
        public void DisplayDetails(object obj)
        {
            if (obj is UniversityStudentManagement)
            {
                Console.WriteLine("University : " + universityName);
                Console.WriteLine("Roll No    : " + rollNumber);
                Console.WriteLine("Name       : " + name);
                Console.WriteLine("Grade      : " + grade);
            }
            else
            {
                Console.WriteLine("Invalid student object");
            }
        }
    }

    class run
    {
        static void Main(string[] args)
        {
            // Create student object
            UniversityStudentManagement s1 =
                new UniversityStudentManagement(101, "Atishay Garg", 'A');

            s1.DisplayDetails(s1);
            Console.WriteLine();

            UniversityStudentManagement.DisplayTotalStudents();
        }
    }
}
