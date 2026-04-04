using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.sorting
{
    internal class JobApplicationSalary
    {
        public void HeapSort(int[] salaries)
        {
            int n = salaries.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(salaries, n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                int temp = salaries[0];
                salaries[0] = salaries[i];
                salaries[i] = temp;

                Heapify(salaries, i, 0);
            }
        }

        private void Heapify(int[] salaries, int heapSize, int root)
        {
            int largest = root;
            int left = 2 * root + 1;
            int right = 2 * root + 2;

            if (left < heapSize && salaries[left] > salaries[largest])
            {
                largest = left;
            }

            if (right < heapSize && salaries[right] > salaries[largest])
            {
                largest = right;
            }

            if (largest != root)
            {
                int swap = salaries[root];
                salaries[root] = salaries[largest];
                salaries[largest] = swap;

                Heapify(salaries, heapSize, largest);
            }
        }

        public void DisplayAll(int[] salaries)
        {
            for (int i = 0; i < salaries.Length - 1; i++)
            {
                Console.Write(salaries[i] + ", ");
            }
            Console.Write(salaries[salaries.Length - 1]);
        }

        static void Main(string[] args)
        {
            JobApplicationSalary jobSalary = new JobApplicationSalary();
            int[] salaryArray = { 45000, 60000, 35000, 80000, 50000, 70000 };

            Console.WriteLine("Before Sorting:");
            jobSalary.DisplayAll(salaryArray);

            jobSalary.HeapSort(salaryArray);

            Console.WriteLine("\n\nAfter Sorting:");
            jobSalary.DisplayAll(salaryArray);
        }
    }
}
