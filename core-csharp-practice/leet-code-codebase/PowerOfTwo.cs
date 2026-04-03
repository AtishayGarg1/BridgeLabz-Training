using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.leetcode
{
    internal class PowerOfTwo
    {
        public bool IsPowerOfTwo(int n)
        {
            return n > 0 && BitOperations.PopCount((uint)n) == 1;
        }

        static void Main(string[] args)
        {
            PowerOfTwo solution = new();

            Console.WriteLine("Enter a Number");
            int n = int.Parse(Console.ReadLine());
            bool result = solution.IsPowerOfTwo(n);

            Console.WriteLine(result);
        }
    }
}
