using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.csharp_class
{
    internal class Employee
    {
        private int employeeId;
        private string employeeName;
        private int employeeSalary;

        public Employee(int employeeId, string employeeName, int employeeSalary)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.employeeSalary = employeeSalary;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Employee Name   : " + employeeName);
            Console.WriteLine("Employee ID     : " + employeeId);
            Console.WriteLine("Employee Salary : " + employeeSalary);
        }
    }

    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Salary: ");
            int salary = int.Parse(Console.ReadLine());

            Employee employee = new Employee(id, name, salary);
            employee.DisplayEmployeeDetails();
        }
    }
}
