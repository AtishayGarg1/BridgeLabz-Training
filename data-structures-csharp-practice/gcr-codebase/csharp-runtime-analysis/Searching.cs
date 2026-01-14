using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Performance
{
    internal class Searching
    {
        public static void SearchComparison()
        {
            int n = 1000000;
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = i;
            }

            int target = n - 1;
            Stopwatch sw = new Stopwatch();

            sw.Start();
            LinearSearch(arr, target);
            sw.Stop();
            Console.WriteLine($"Linear Search: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            Array.BinarySearch(arr, target);
            sw.Stop();
            Console.WriteLine($"Binary Search: {sw.ElapsedMilliseconds} ms\n");
        }

        public static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
