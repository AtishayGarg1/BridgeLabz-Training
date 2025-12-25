using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.leveltwo
{
    internal class Factors
    {
        static void Main(string[] args)
        {
            //Read a number
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            int[] factors = FindFactors(number);
            Console.WriteLine("Factors:");
            foreach(int f in factors)
            {
                Console.Write(f + " ");
            }

            Console.WriteLine("/nSum = " + FindSum(factors));
            Console.WriteLine("Sum of Squares = " + FindSumOfSquares(factors));
            Console.WriteLine("Product = " + FindProduct(factors));
        }

        //Function to find Factors of a number
        static int[] FindFactors(int number)
        {
            int count = 0;
            for(int i = 1; i <= number; i++)
            {
                if(number % i == 0)
                {
                    count++;
                }
            }

            int[] factors = new int[count];
            int index = 0;

            for(int i = 1; i <= number; i++)
                if(number % i == 0)
                {
                    factors[index++] = i;
                }

            return factors;
        }

        //Function to find Sum of factors
        static int FindSum(int[] factors)
        {
            int sum = 0;
            foreach(int f in factors)
            {
                sum += f;
            }
            return sum;
        }

        //Function to find Sum of Squares of factors
        static double FindSumOfSquares(int[] factors)
        {
            double sum = 0;
            foreach(int f in factors)
            {
                sum += Math.Pow(f, 2);
            }
            return sum;
        }

        //Function to find Product of factors
        static long FindProduct(int[] factors)
        {
            long product = 1;
            foreach(int f in factors)
            {
                product *= f;
            }
            return product;
        }
    }
}
