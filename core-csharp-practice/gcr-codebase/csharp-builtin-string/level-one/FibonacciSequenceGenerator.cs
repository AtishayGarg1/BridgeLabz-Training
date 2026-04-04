using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinstring.levelone
{
    internal class FibonacciSequenceGenerator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of terms in Fibonacci sequence");
            int n = int.Parse(Console.ReadLine());

            GenerateFibonacci(n);
        }

        // Function to generate and display Fibonacci sequence up to n terms
        public static void GenerateFibonacci(int n)
        {
            int[] fibonacci = new int[n];
            fibonacci[0] = 0;
            if (n > 1)
            {
                fibonacci[1] = 1;
                for (int i = 2; i < n; i++)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
            }
            Console.WriteLine("Fibonacci Series up to " + n + " terms:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(fibonacci[i] + " ");
            }
            return;
        }
    }
}
