using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Linear_Binary_Search
{
    internal class RotationPointFinder
    {
        static int FindRotationPoint(int[] arr)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low < high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] > arr[high])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }

            return low; // index of smallest element
        }

        static void Main()
        {
            int[] arr = { 4, 5, 6, 7, 0, 1, 2 };

            int rotationIndex = FindRotationPoint(arr);

            Console.WriteLine("Rotation Point Index: " + rotationIndex);
            Console.WriteLine("Smallest Element: " + arr[rotationIndex]);
        }
    }
}
