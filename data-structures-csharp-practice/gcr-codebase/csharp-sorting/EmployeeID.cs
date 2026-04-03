using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.sorting
{
    internal class EmployeeID
    {
        public void InsertionSort(int[] employeeIds)
        {
            for (int i = 1; i < employeeIds.Length; i++)
            {
                DisplayAll(employeeIds);
                Console.WriteLine();

                int key = employeeIds[i];
                int j = i - 1;

                while (j >= 0 && employeeIds[j] > key)
                {
                    employeeIds[j + 1] = employeeIds[j];
                    j--;
                }

                employeeIds[j + 1] = key;
            }

            DisplayAll(employeeIds);
        }

        public void DisplayAll(int[] employeeIds)
        {
            for (int i = 0; i < employeeIds.Length - 1; i++)
            {
                Console.Write(employeeIds[i] + ", ");
            }
            Console.Write(employeeIds[employeeIds.Length - 1]);
        }

        static void Main(string[] args)
        {
            EmployeeID employee = new EmployeeID();
            int[] employeeIdArray = { 105, 101, 109, 102, 108, 104, 110, 103 };
            Console.WriteLine("Before Sorting");
            employee.DisplayAll(employeeIdArray);
            Console.WriteLine("After Sorting");
            employee.InsertionSort(employeeIdArray);
        }
    }
}
