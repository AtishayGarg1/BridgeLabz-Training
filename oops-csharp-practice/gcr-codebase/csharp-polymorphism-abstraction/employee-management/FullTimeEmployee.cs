using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.Employee_Management
{
    internal class FullTimeEmployee : Employee, IDepartment
    {
        private string department;
        public FullTimeEmployee(int employeeId, string employeeName, int salary) : base(employeeId, employeeName, salary)
        {
        }

        public override double CalculateSalary()
        {
            return salary;
        }

        public void AssignDepartment(string departmentName)
        {
            department = departmentName;
        }

        public string GetDepartment()
        {
            return department;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine(GetDepartment());
        }
    }
}
