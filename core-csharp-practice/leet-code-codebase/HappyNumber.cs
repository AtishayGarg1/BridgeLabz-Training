using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.leetcode
{
    internal class HappyNumber
    {
        static void Main()
        {
            //Read a Number
            Console.WriteLine("Enter a Number");
            int n = int.Parse(Console.ReadLine());
            int temp = n;

            //Loop to aviid infinite cycle
            for (int i = 0; i < 100; i++)
            {
                //Calculate sum of squares of digits
                int sum = 0;
                while (n > 0)
                {
                    int d = n % 10;
                    sum += d * d;
                    n /= 10;
                }

                if (sum == 1)
                {
                    Console.WriteLine("Happy Number");
                    return;
                }

                n = sum;
            }

            Console.WriteLine("Not a Happy Number");
        }
    }
}
