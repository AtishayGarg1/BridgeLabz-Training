using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinstring.levelone
{
    internal class PrimeCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = IsPrime(number);
            DisplayResult(number, isPrime);
        }

        // Function to display the result
        public static void DisplayResult(int number, bool isPrime)
        {
            if (isPrime)
            {
                Console.WriteLine(number + " is a Prime Number");
            }
            else
            {
                Console.WriteLine(number + " is not a Prime Number");
            }
        }

        // Function to check if a number is prime
        public static bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
