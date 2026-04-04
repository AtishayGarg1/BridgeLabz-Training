using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.levelthree
{
    internal class EmployeesBonus
    {
        static void Main(string[] args)
        {
            
            double[,] employeeData = GenerateEmployeeData(10);
            double[,] updatedData = CalculateNewSalaryAndBonus(employeeData);
            CalculateAndDisplayTotals(employeeData, updatedData);
        }

        //Function to generate employee data
        static double[,] GenerateEmployeeData(int count)
        {
            double[,] data = new double[count, 2];
            Random rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                data[i, 0] = rnd.Next(10000, 100000);
                data[i, 1] = rnd.Next(1, 11);
            }

            return data;
        }

        //Function to calculate new salary and bonus
        static double[,] CalculateNewSalaryAndBonus(double[,] data)
        {
            int count = data.GetLength(0);
            double[,] result = new double[count, 2];

            for (int i = 0; i < count; i++)
            {
                double salary = data[i, 0];
                double years = data[i, 1];
                double bonus = years > 5 ? salary * 0.05 : salary * 0.02;
                double newSalary = salary + bonus;

                result[i, 0] = newSalary;
                result[i, 1] = bonus;
            }

            return result;
        }

        //Function to calculate and display totals
        static void CalculateAndDisplayTotals(double[,] oldData, double[,] newData)
        {
            double totalOldSalary = 0;
            double totalNewSalary = 0;
            double totalBonus = 0;

            Console.WriteLine("Emp\tOldSalary\tYears\tBonus\t\tNewSalary");

            for (int i = 0; i < oldData.GetLength(0); i++)
            {
                double oldSalary = oldData[i, 0];
                double years = oldData[i, 1];
                double bonus = newData[i, 1];
                double newSalary = newData[i, 0];

                totalOldSalary += oldSalary;
                totalNewSalary += newSalary;
                totalBonus += bonus;

                Console.WriteLine(
                    (i + 1) + "\t" +
                    oldSalary + "\t" +
                    years + "\t" +
                    bonus + "\t" +
                    newSalary
                );
            }

            Console.WriteLine("\nTotal Old Salary: " + totalOldSalary);
            Console.WriteLine("Total Bonus Paid: " + totalBonus);
            Console.WriteLine("Total New Salary: " + totalNewSalary);
        }
    }
}
