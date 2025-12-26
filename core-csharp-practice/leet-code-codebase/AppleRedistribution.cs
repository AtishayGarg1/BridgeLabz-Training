using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.leetcode
{
    internal class AppleRedistribution
    {
        static void Main(string[] args)
        {
            int[] apple = { 1, 3, 2, 4 };
            int[] capacity = { 4, 3, 1, 5, 2 };
            int result = MinimumBoxes(apple, capacity);
            Console.WriteLine("Minimum Boxes: "+result);
        }
        public static int MinimumBoxes(int[] apple, int[] capacity)
        {
            Array.Sort(capacity);
            int count = 0;
            int sum = 0;
            int sumApple = 0;
            foreach (int i in apple)
            {
                sumApple += i;
            }
            for (int i = capacity.Length - 1; i >= 0; i--)
            {
                sum += capacity[i];
                count++;
                if (sum >= sumApple)
                {
                    return count;
                }
            }
            return -1;
        }
    }
}
