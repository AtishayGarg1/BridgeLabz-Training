using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stackqueuehashmap
{
    internal class PairWithGivenSum
    {
        static bool HasPairWithSum(int[] arr, int target)
        {
            HashSet<int> seen = new HashSet<int>();

            foreach (int num in arr)
            {
                int complement = target - num;

                if (seen.Contains(complement))
                    return true;

                seen.Add(num);
            }

            return false;
        }

        static void Main()
        {
            int[] arr = { 8, 7, 2, 5, 3, 1 };
            int target = 10;

            Console.WriteLine(
                HasPairWithSum(arr, target)
                ? "Pair exists"
                : "No such pair"
            );
        }
    }
}
