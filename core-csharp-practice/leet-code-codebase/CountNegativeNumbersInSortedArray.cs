using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.leetcode
{
    internal class CountNegativeNumbersInSortedArray
    {
        static void Main(string[] args)
        {
            int[][] grid = new int[][]
        {
            new int[] { 4,  3,  2, -1 },
            new int[] { 3,  2,  1, -1 },
            new int[] { 1,  1, -1, -2 },
            new int[] { -1, -1, -2, -3 }
        };

            int result = CountNegatives(grid);

            Console.WriteLine("Count of negative numbers: " + result);
        }
        public static int CountNegatives(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int row = 0, col = n - 1;
            int count = 0;

            while(row < m && col >= 0)
            {
                if(grid[row][col] < 0)
                {
                    count += (m - row);
                    col--;
                }
                else
                {
                    row++;
                }
            }
            return count;
        }
    }
}
