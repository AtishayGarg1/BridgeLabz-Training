using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.Employee_Management
{
    internal class Run
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Of Employees");
            int count = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("1. Full Time");
                Console.WriteLine("1. Part Time");
                Console.WriteLine("3. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Employee Id");
                        int id = int.Parse(Console.ReadLine());

                        FullTimeEmployee emp = new FullTimeEmployee(id, name, 60000);
                        emp.AssignDepartment("IT");
                        employees[i] = emp;
                        break;
                    case 2:
                        Console.WriteLine("Enter Name");
                        string name1 = Console.ReadLine();
                        Console.WriteLine("Enter Employee Id");
                        int id1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter working hours");
                        int hours = int.Parse(Console.ReadLine());
                        PartTimeEmployee empl = new PartTimeEmployee(id1, name1, hours, 400);
                        empl.AssignDepartment("HR");
                        employees[i] = empl;
                        break;
                    case 3:
                        return;
                }
            }
            for (int i = 0; i < count; i++)
            {
                employees[i].DisplayDetails();
            }
        }
    }
}
