using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructors
{
    internal class Employee
    {
        // Instance variables
        public int employeeID;
        protected string department;
        private int salary;

        // Getter for salary
        public int GetSalary()
        {
            return salary;
        }

        // Setter for salary
        public void SetSalary(int salary)
        {
            this.salary = salary;
        }

        // Constructor
        public Employee(int employeeID, string department, int salary)
        {
            this.employeeID = employeeID;
            this.department = department;
            this.salary = salary;
        }

        // Display employee details
        public void DisplayDetails()
        {
            Console.WriteLine("Employee ID: " + employeeID);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Salary: " + salary);
        }
    }

    // Derived class
    class Manager : Employee
    {
        public Manager(int employeeID, string department, int salary)
            : base(employeeID, department, salary) { }
    }

    // Main execution class
    class run
    {
        static void Main(string[] args)
        {
            Employee emp1 = new(101, "IT", 50000);
            emp1.DisplayDetails();

            emp1.SetSalary(55000);
            Console.WriteLine("Updated Salary: " + emp1.GetSalary());
            emp1.DisplayDetails();
        }
    }
}
