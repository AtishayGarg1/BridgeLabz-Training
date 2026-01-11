using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.sorting
{
    internal class StudentAges
    {
        public void CountingSort(int[] ages)
        {
            int minAge = 10;
            int maxAge = 18;
            int range = maxAge - minAge + 1;

            int[] count = new int[range];
            int[] output = new int[ages.Length];

            // Step 1: Count frequency of each age
            for (int i = 0; i < ages.Length; i++)
            {
                count[ages[i] - minAge]++;
            }

            // Step 2: Cumulative count
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            // Step 3: Build output array (stable sort)
            for (int i = ages.Length - 1; i >= 0; i--)
            {
                int age = ages[i];
                int position = count[age - minAge] - 1;
                output[position] = age;
                count[age - minAge]--;
            }

            // Step 4: Copy back to original array
            for (int i = 0; i < ages.Length; i++)
            {
                ages[i] = output[i];
            }
        }

        public void DisplayAll(int[] ages)
        {
            for (int i = 0; i < ages.Length - 1; i++)
            {
                Console.Write(ages[i] + ", ");
            }
            Console.Write(ages[ages.Length - 1]);
        }

        static void Main(string[] args)
        {
            StudentAges studentAges = new StudentAges();
            int[] ageArray = { 12, 15, 10, 14, 18, 13, 11, 16, 12, 14 };

            Console.WriteLine("Before Sorting:");
            studentAges.DisplayAll(ageArray);

            studentAges.CountingSort(ageArray);

            Console.WriteLine("\n\nAfter Sorting:");
            studentAges.DisplayAll(ageArray);
        }
    }
}
