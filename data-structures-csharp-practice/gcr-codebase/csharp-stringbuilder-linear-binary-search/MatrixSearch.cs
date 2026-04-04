using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stringbuilder_search
{
    internal class MatrixSearch
    {
        public bool Search(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int low = 0;
            int high = rows * cols - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int row = mid / cols;
                int col = mid % cols;

                if (matrix[row, col] == target)
                    return true;

                if (matrix[row, col] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return false;
        }

        public static void Main()
        {
            int[,] matrix =
            {
            { 1, 3, 5 },
            { 7, 9, 11 },
            { 13, 15, 17 }
        };

            MatrixSearch searcher = new MatrixSearch();

            Console.WriteLine(searcher.Search(matrix, 9));   
            Console.WriteLine(searcher.Search(matrix, 10));  
        }
    }
}
