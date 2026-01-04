using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgeLabzTraining.thisstatic
{
    internal class EmployeeManagementSystem
    {
        public static string companyName = "BridgeLabz";
        private static int totalEmployees = 0;

        public readonly int id;
        public string name;
        public string designation;

        public EmployeeManagementSystem(int id, string name, string designation)
        {
            this.id = id;
            this.name = name;
            this.designation = designation;
            totalEmployees++;
        }

        public static int DisplayTotalEmployees()
        {
            return totalEmployees;
        }

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
            EmployeeManagementSystem e1 = new(1, "Atishay Garg", "Developer");
            e1.DisplayDetails(e1);

            Console.WriteLine("Total Employees: " + EmployeeManagementSystem.DisplayTotalEmployees());
        }
    }
}

