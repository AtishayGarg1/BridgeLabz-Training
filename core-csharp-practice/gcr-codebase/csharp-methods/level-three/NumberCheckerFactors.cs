using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.levelthree
{
    internal class NumberCheckerFactors
    {
        static void Main(string[] args)
        {
            //Read a Number
            Console.WriteLine("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Perfect Number: " + IsPerfect(n));
        }

        //Function to check if number is Perfect
        static bool IsPerfect(int n)
        {
            int sum = 0;
            for(int i = 1; i < n; i++)
            {
                if(n % i == 0)
                {
                    sum += i;
                }
            }
            return sum == n;
        }
    }
}
