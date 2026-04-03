 using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Performance
{
    internal class Sorting
    {
        public static void SortingComparison()
        {
            int n = 10000;
            int[] arr1 = GenerateArray(n);
            int[] arr2 = (int[])arr1.Clone();
            int[] arr3 = (int[])arr1.Clone();

            Stopwatch sw = new Stopwatch();

            sw.Start();
            BubbleSort(arr1);
            sw.Stop();
            Console.WriteLine($"Bubble Sort: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            Array.Sort(arr2); // Quick/Intro sort
            sw.Stop();
            Console.WriteLine($"Quick Sort: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            MergeSort(arr3, 0, arr3.Length - 1);
            sw.Stop();
            Console.WriteLine($"Merge Sort: {sw.ElapsedMilliseconds} ms\n");
        }

        public static int[] GenerateArray(int n)
        {
            Random random = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = random.Next();
            return arr;
        }

        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
        }

        public static void MergeSort(int[] arr, int left, int right)
        {
            if (left >= right) return;

            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }

        public static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1];
            int i = left, j = mid + 1, k = 0;

            while (i <= mid && j <= right)
            {
                temp[k++] = arr[i] <= arr[j] ? arr[i++] : arr[j++];
            }

            while (i <= mid) temp[k++] = arr[i++];
            while (j <= right) temp[k++] = arr[j++];

            for (i = left, k = 0; i <= right; i++, k++)
            {
                arr[i] = temp[k];
            }
        }
    }
}
