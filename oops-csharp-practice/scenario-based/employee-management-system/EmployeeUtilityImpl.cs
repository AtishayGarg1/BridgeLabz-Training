using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.EmployeeEx
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        private IEmployeeDetails Employee;

        public IEmployeeDetails AddEmployee()
        {
            Employee = new EmployeeImpl();
            Console.WriteLine("Give Employee Details");
            Console.WriteLine("Give Employee Name");
            Employee.EmployeeName1 = Console.ReadLine();
            Console.WriteLine("Give Employee Id");
            Employee.EmployeeId1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give Salary");
            Employee.EmployeeSalary1 = double.Parse(Console.ReadLine());
            return Employee;
        }

        // Method to get employee name
        public void GetEmployeeName(IEmployeeDetails employee,int i)
        {
            Console.WriteLine((i+1)+". "+employee.EmployeeName1);
        }

        //Method to get employee details
        public void GetDetails(IEmployeeDetails employee)
        {
            Console.WriteLine(employee.ToString());
        }

        // UC-1 Check Whether The Employee is present or absent
        public void CheckAttendance(IEmployeeDetails employee)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 2);
            if(random == 1)
            {
                Console.WriteLine("Employee '"+employee.EmployeeName1+"' is Present");
            }
            else
            {
                Console.WriteLine("Employee '"+employee.EmployeeName1+"' is Absent");
            }
        }



    }
}
