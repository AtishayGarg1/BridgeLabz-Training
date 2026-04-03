using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stackqueuehashmap
{
    internal class LongestConsecutiveSequence
    {
        static int FindLongestConsecutive(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            HashSet<int> set = new HashSet<int>(nums);
            int longest = 0;

            foreach (int num in set)
            {
                if (!set.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentStreak = 1;

                    while (set.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentStreak++;
                    }

                    longest = Math.Max(longest, currentStreak);
                }
            }

            return longest;
        }

        static void Main()
        {
            int[] nums = { 100, 4, 200, 1, 3, 2 };
            Console.WriteLine(FindLongestConsecutive(nums)); // Output: 4
        }
    }
}
