using System;

internal class EmployeeSalary
{
    static void Main(string[] args)
    {
        //create arrays to store salary, years of service, bonus and new salary for employees
        int size = 10;
        double[] salary = new double[size];
        double[] years = new double[size];
        double[] bonus = new double[size];
        double[] newSalary = new double[size];

        double totalBonus = 0;
        double totalOldSalary = 0;
        double totalNewSalary = 0;

        //read salary and years of service for each employee
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Employee " + (i + 1));

            Console.WriteLine("Enter Salary of Employee");
            salary[i] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Years of Service");
            years[i] = double.Parse(Console.ReadLine());

            if (salary[i] <= 0 || years[i] <= 0)
            {
                Console.WriteLine("Invalid Input. Enter Valid Values. ");
                i--;
                continue;
            }
        }

        //calculate bonus and new salary for each employee
        for (int i = 0; i < size; i++)
        {
            if (years[i] > 5)
            {
                bonus[i] = salary[i] * 0.05;
            }
            else
            {
                bonus[i] = salary[i] * 0.02;
            }
            newSalary[i] = salary[i] + bonus[i];

            totalBonus += bonus[i];
            totalOldSalary += salary[i];
            totalNewSalary += newSalary[i];
        }

        Console.WriteLine("Total Old Salary: " + totalOldSalary);
        Console.WriteLine("Total Bonus: " + totalBonus);
        Console.WriteLine("Total New Salary: " + totalNewSalary);
    }
}