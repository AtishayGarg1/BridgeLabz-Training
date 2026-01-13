using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stringbuilder_search
{
    internal class SearchOccurance
    {
        public bool SearchInMatrix(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int low = 0;
            int high = rows * cols - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int r = mid / cols;
                int c = mid % cols;

                if (matrix[r, c] == target)
                    return true;

                if (matrix[r, c] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return false;
        }

        public int FindFirstOccurrence(int[] arr, int target)
        {
            int low = 0, high = arr.Length - 1;
            int index = -1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] == target)
                {
                    index = mid;
                    high = mid - 1;
                }
                else if (arr[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return index;
        }

        public int FindLastOccurrence(int[] arr, int target)
        {
            int low = 0, high = arr.Length - 1;
            int index = -1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] == target)
                {
                    index = mid;
                    low = mid + 1;
                }
                else if (arr[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return index;
        }

        static void Main()
        {
            SearchOccurance obj = new SearchOccurance();

            int[,] matrix =
            {
            { 1, 3, 5 },
            { 7, 9, 11 },
            { 13, 15, 17 }
        };

            Console.WriteLine("Matrix Search (9): " + obj.SearchInMatrix(matrix, 9));
            Console.WriteLine("Matrix Search (10): " + obj.SearchInMatrix(matrix, 10));

            int[] arr = { 2, 4, 4, 4, 6, 8 };

            Console.WriteLine("First Occurrence of 4: " + obj.FindFirstOccurrence(arr, 4));
            Console.WriteLine("Last Occurrence of 4: " + obj.FindLastOccurrence(arr, 4));
        }
    }
}
