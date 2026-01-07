using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.EmployeeEx
{
    sealed class EmployeeMenu
    {
        private IEmployee EmployeeUtil;
        public void EmployeeChoice()
        {
            Console.WriteLine("\tWelcome to Employee Management System");
            int count = 0;
            IEmployeeDetails[] employee = new EmployeeImpl[5];
            EmployeeUtil = new EmployeeUtilityImpl();
            // Switch case for menu
            while(true)
            {

                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. View All Employees");
                Console.WriteLine("3. View Employee Details");
                Console.WriteLine("4. Check Employe Attendance");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        IEmployeeDetails emp = EmployeeUtil.AddEmployee();
                        employee[count++] = emp;
                        break;
                    case 2:
                        for(int i = 0; i < count; i++)
                        {
                            EmployeeUtil.GetEmployeeName(employee[i],i);
                        }
                        break;
                    case 3:
                        for (int i = 0; i < count; i++)
                        {
                            EmployeeUtil.GetEmployeeName(employee[i], i);
                        }
                        int c = int.Parse(Console.ReadLine())-1;
                        EmployeeUtil.GetDetails(employee[c]);
                        break;
                    case 4:
                        for (int i = 0; i < count; i++)
                        {
                            EmployeeUtil.GetEmployeeName(employee[i], i);
                        }
                        Console.WriteLine("Enter index: ");
                        int idx = int.Parse(Console.ReadLine())-1;
                        EmployeeUtil.CheckAttendance(employee[idx]);
                        break;
                    case 5:
                        Console.WriteLine("Exitting Employee Management System");
                        return;
                    default:
                        break;
                }
            }
        }

    }
}
