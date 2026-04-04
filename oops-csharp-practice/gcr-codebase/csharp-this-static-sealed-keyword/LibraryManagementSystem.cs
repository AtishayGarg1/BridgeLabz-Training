using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.thisstatic
{
    internal class EmployeeManagementSystem
    {
        // Static variable shared by all employees
        public static string companyName = "BridgeLabz";

        // Static variable to count total employees
        private static int totalEmployees = 0;

        // Readonly variable for employee ID
        public readonly int id;

        // Instance variables
        public string name;
        public string designation;

        // Constructor using this keyword
        public EmployeeManagementSystem(int id, string name, string designation)
        {
            this.id = id;
            this.name = name;
            this.designation = designation;
            totalEmployees++;
        }

        // Static method to display total employees
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine("Total Employees: " + totalEmployees);
        }

        // Display details using is operator
        public void DisplayDetails(object obj)
        {
            if (obj is EmployeeManagementSystem)
            {
                Console.WriteLine("Company     : " + companyName);
                Console.WriteLine("ID          : " + id);
                Console.WriteLine("Name        : " + name);
                Console.WriteLine("Designation : " + designation);
            }
            else
            {
                Console.WriteLine("Invalid employee object");
            }
        }
    }

    class run
    {
        static void Main(string[] args)
        {
            EmployeeManagementSystem e1 =
                new EmployeeManagementSystem(101, "Atishay Garg", "Developer");

            e1.DisplayDetails(e1);
            Console.WriteLine();

            EmployeeManagementSystem.DisplayTotalEmployees();
        }
    }
}
