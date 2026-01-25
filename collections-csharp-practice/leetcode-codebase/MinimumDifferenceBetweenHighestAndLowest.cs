using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.leetcode
{
    internal class MinimumDifferenceBetweenHighestAndLowest
    {
        public int MinimumDifference(int[] nums, int k)
        {
            if (k == 1)
            {
                return 0;
            }
            Array.Sort(nums);
            int min = int.MaxValue;
            for (int i = 0; i <= nums.Length - k; i++)
            {
                min = Math.Min(min, nums[i - 1 + k] - nums[i]);
            }
            return min;
        }
    }
}
