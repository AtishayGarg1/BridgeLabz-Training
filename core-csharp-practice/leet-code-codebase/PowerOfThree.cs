using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.leetcode
{
    internal class PowerOfThree
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());

            PowerOfThree solution = new();
            bool result = solution.IsPowerOfThree(n);

            Console.WriteLine(result);
        }

        public bool IsPowerOfThree(int n)
        {
            if (n > 0 && (int)Math.Pow(3, 19) % n == 0)
            {
                return true;
            }
            return false;
        }
    }
}
