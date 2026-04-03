using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.leveltwo
{
    internal class SumNaturalNumbers
    {
        static void Main(string[] args)
        {
            //Read a natural number
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            //Return for Invalid input
            if(n <= 0)
            {
                Console.WriteLine("Not a natural number");
                return;
            }

            //Calculate sums using both methods Recursion and Formula
            int recSum = SumRecursive(n);
            int formulaSum = SumFormula(n);

            Console.WriteLine("Recursive Sum = " + recSum);
            Console.WriteLine("Formula Sum = " + formulaSum);
            Console.WriteLine(recSum == formulaSum ? "Results are equal":"Results differ");
        }

        //Function to find sum of first n natural numbers using Recursion
        static int SumRecursive(int n)
        {
            if(n == 0)
            {
                return 0;
            } 
            return n + SumRecursive(n - 1);
        }


        //Function to find sum of first n natural numbers using Formula
        static int SumFormula(int n)
        {
            return (n * (n + 1)) / 2;
        }

    }
}
