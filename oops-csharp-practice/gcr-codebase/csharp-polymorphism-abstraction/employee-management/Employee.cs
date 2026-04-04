using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.Employee_Management
{
    internal abstract class Employee
    {
        protected int employeeId;
        protected string employeeName;
        protected int salary;

        public Employee(int employeeId, string employeeName, int salary)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.salary = salary;
        }

        public abstract double CalculateSalary();

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Name: " + employeeName);
            Console.WriteLine("Employee Id: " + employeeId);
            Console.WriteLine("Employee Type: " + this.GetType().Name);
            Console.WriteLine("Salary: " + CalculateSalary());
        }

    }
}
