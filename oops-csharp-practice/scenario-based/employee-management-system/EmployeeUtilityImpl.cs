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

        // Method to add employee 
        public IEmployeeDetails AddEmployee()
        {
            Employee = new EmployeeImpl();
            Console.WriteLine("Give Employee Details");
            Console.WriteLine("Give Employee Name");
            Employee.EmployeeName1 = Console.ReadLine();
            Console.WriteLine("Give Employee Id");
            Employee.EmployeeId1 = int.Parse(Console.ReadLine());
            EmployeeType(Employee);
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
                employee.EmployeeWorkingDays1++;
                Console.WriteLine("Employee '"+employee.EmployeeName1+"' is Present");
            }
            else
            {
                Console.WriteLine("Employee '"+employee.EmployeeName1+"' is Absent");
            }
        }

        // UC-2 Calculate salary based on work hours
        public void CalculateWage(IEmployeeDetails employee)
        {
            employee.EmployeeSalary1 = 100 * employee.EmployeeWorkHours1 * Employee.EmployeeWorkingDays1;
        }

        // UC-3 Part Type Employee And Wage
        public void EmployeeType(IEmployeeDetails employee)
        {
            Console.WriteLine("Enter Employee Type");
            Console.WriteLine("1. Full Time");
            Console.WriteLine("2. Part Time");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    employee.EmployeeType1 = "Full Time";
                    Console.WriteLine("Enter salary");
                    Employee.EmployeeSalary1 = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    employee.EmployeeType1 = "Part Time";
                    Console.WriteLine("Give Work Hours");
                    Employee.EmployeeWorkHours1 = int.Parse(Console.ReadLine());
                    CalculateMonthAttendance(Employee);
                    CalculateWage(Employee);
                    break;

            }

        }

        // UC-5 Calculate Month Wage
        public void CalculateMonthAttendance(IEmployeeDetails employee)
        {
            for(int i = 0; i < 30; i++)
            {
                CheckAttendance2(employee);
            }
        }

        // Method to Check Working Days in a month
        public void CheckAttendance2(IEmployeeDetails employee)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 2);
            if(random == 1)
            {
                employee.EmployeeWorkingDays1++;
            }
        }


    }
}
