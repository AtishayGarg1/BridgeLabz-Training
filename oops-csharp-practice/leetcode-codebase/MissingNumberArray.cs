using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.leetcode
{
    public class MissingNumberArray
    {
        // Method to find the missing number in the array
        public int MissingNumber(int[] nums)
        {
            int n = nums.Length;

            // Expected sum from 0 to n
            int sum = (n * (n + 1)) / 2;

            // Sum of elements in the array
            int sumFor = 0;
            for (int i = 0; i < n; i++)
            {
                sumFor += nums[i];
            }

            // Missing number
            return sum - sumFor;
        }

        // Main method similar to Happy Number style
        static void Main()
        {
            Console.WriteLine("Enter number of elements:");
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Solution sol = new Solution();
            int result = sol.MissingNumber(nums);

            Console.WriteLine("Missing Number is: " + result);
        }
    }

}
