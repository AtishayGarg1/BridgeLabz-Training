using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinstring.levelone
{
    internal class FactorialUsingRecursion
    {
        static void Main(string[] args)
        {
            int number = InputNumber();
            long factorial = CalculateFactorial(number);
            DisplayResult(number, factorial);
        }

        // Function to take input number from user
        public static int InputNumber()
        {
            Console.WriteLine("Enter a Number to calculate Factorial:");
            int input = int.Parse(Console.ReadLine());
            return input;
        }

        // Function to calculate factorial using recursion
        public static long CalculateFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * CalculateFactorial(n - 1);
        }

        // Function to display the result
        public static void DisplayResult(int number, long factorial)
        {
            Console.WriteLine("Factorial of " + number + " is: " + factorial);
        }
    }
}
