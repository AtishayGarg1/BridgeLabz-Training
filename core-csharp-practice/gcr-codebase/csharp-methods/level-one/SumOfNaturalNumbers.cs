using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.levelone
{
    internal class SumOfNaturalNumbers
    {
        static void Main(string[] args)
        {
            //Read a number
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum = " + FindSum(n));
        }

        //Function to find sum of first n natural numbers
        static int FindSum(int n)
        {
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
