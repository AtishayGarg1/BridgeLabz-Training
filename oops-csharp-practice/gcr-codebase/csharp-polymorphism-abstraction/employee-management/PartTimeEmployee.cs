using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.Employee_Management
{
    internal class PartTimeEmployee : Employee, IDepartment
    {
        private int workingHours;
        private int ratePerHour;
        private string department;
        public PartTimeEmployee(int employeeId, string employeeName, int workingHours, int ratePerHour) : base(employeeId, employeeName, 0)
        {
            this.workingHours = workingHours;
            this.ratePerHour = ratePerHour;
        }

        public override double CalculateSalary()
        {
            return workingHours * ratePerHour;
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
