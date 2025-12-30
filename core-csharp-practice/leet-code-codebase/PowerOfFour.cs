using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.leetcode
{
    internal class PowerOfFour
    {
        //Function to Calculate the power of Four
        public bool IsPowerOfFour(int n)
        {
            return n > 0
                && BitOperations.PopCount((uint)n) == 1
                && (n - 1) % 3 == 0;
        }

        public static void Main(string[] args)
        {
            PowerOfFour sol = new();

            int[] testCases = { 1, 4, 16, 64, 5, 8, 12 };

            foreach (int n in testCases)
            {
                Console.WriteLine(n+" -> "+ sol.IsPowerOfFour(n));
            }
        }
    }
}
