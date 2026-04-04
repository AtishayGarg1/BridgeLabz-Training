using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stackqueuehashmap
{
    internal class SlidingWindowMaximum
    {
        static int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0 || k <= 0)
                return Array.Empty<int>();

            int n = nums.Length;
            int[] result = new int[n - k + 1];
            LinkedList<int> deque = new LinkedList<int>(); // stores indices

            for (int i = 0; i < n; i++)
            {
                // Remove indices out of current window
                if (deque.Count > 0 && deque.First.Value <= i - k)
                    deque.RemoveFirst();

                // Remove smaller elements from the back
                while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i])
                    deque.RemoveLast();

                // Add current index
                deque.AddLast(i);

                // Record max when window is fully formed
                if (i >= k - 1)
                    result[i - k + 1] = nums[deque.First.Value];
            }

            return result;
        }

        static void Main()
        {
            int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;

            int[] output = MaxSlidingWindow(nums, k);

            Console.WriteLine("Sliding Window Maximums:");
            foreach (int val in output)
                Console.Write(val + " ");
        }
    }
}
