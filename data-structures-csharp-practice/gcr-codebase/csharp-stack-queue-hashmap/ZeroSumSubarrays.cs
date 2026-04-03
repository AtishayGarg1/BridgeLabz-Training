using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stackqueuehashmap
{
    internal class ZeroSumSubarrays
    {
        static void FindZeroSumSubarrays(int[] arr)
        {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            int sum = 0;

            // Handle subarrays starting from index 0
            map[0] = new List<int> { -1 };

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (map.ContainsKey(sum))
                {
                    foreach (int startIndex in map[sum])
                    {
                        Console.WriteLine(
                            $"Zero-sum subarray: [{startIndex + 1}, {i}]"
                        );
                    }
                }

                if (!map.ContainsKey(sum))
                    map[sum] = new List<int>();

                map[sum].Add(i);
            }
        }

        static void Main()
        {
            int[] arr = { 3, 4, -7, 1, 3, -4, -2, -2 };

            FindZeroSumSubarrays(arr);
        }
    }
}
