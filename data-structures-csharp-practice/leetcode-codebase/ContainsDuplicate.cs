using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.leetcode
{
    internal class ContainsDuplicate
    {
        public bool ContainsDuplicates(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return false;

            Array.Sort(nums);

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                    return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            ContainsDuplicate containsDuplicate = new ContainsDuplicate();
            containsDuplicate.ContainsDuplicates(new[] { 1, 2, 3, 4, 5, 1 });
        }
    }

}
