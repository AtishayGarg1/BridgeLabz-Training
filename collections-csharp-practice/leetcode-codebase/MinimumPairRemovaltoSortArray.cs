using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.leetcode
{
    public class Solution
    {
        public int MinimumPairRemoval(int[] nums)
        {
            List<int> arr = new List<int>(nums);
            int operations = 0;

            while (!IsNonDecreasing(arr))
            {
                int minSum = int.MaxValue;
                int index = 0;

                // find adjacent pair with minimum sum
                for (int i = 0; i < arr.Count - 1; i++)
                {
                    int sum = arr[i] + arr[i + 1];
                    if (sum < minSum)
                    {
                        minSum = sum;
                        index = i;
                    }
                }

                // replace the pair with their sum
                arr[index] = arr[index] + arr[index + 1];
                arr.RemoveAt(index + 1);

                operations++;
            }

            return operations;
        }

        private bool IsNonDecreasing(List<int> arr)
        {
            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] < arr[i - 1])
                    return false;
            }
            return true;
        }
    }
}
