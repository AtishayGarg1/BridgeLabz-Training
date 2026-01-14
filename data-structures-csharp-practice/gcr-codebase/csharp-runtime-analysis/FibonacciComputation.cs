using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Performance
{
    internal class FibonacciComputation
    {
        // Method to Execute program
        public static void FibonacciComparison()
        {
            int n = 40;
            Stopwatch sw = new Stopwatch();

            sw.Start();
            FibonacciRecursive(n);
            sw.Stop();
            Console.WriteLine($"Recursive Fibonacci: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            FibonacciIterative(n);
            sw.Stop();
            Console.WriteLine($"Iterative Fibonacci: {sw.ElapsedMilliseconds} ms");
            Console.WriteLine();
        }

        // Method to find fibonacci numbers using recursive approach
        public static int FibonacciRecursive(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        // Method to find fibonacci numbers using iterative approach
        public static int FibonacciIterative(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            int a = 0;
            int b = 1;

            for (int i = 2; i <= n; i++)
            {
                int sum = a + b;
                a = b;
                b = sum;
            }

            return b;
        }
    }
}
