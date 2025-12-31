using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased
{
    internal class MathematicalOperations
    {
        static void Main(string[] args)
        {
            MathematicalOperations mathematicalOperations = new();
            mathematicalOperations.Factorial();
            mathematicalOperations.IsPrime();
            mathematicalOperations.Gcd();
            mathematicalOperations.Fibonacci();
        }

        void Factorial()
        {
            Console.WriteLine("Enter a Number To Find Factorial: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + n + " is: " + fact);
        }


        void IsPrime()
        {
            Console.WriteLine("Enter a Number To Check Prime: ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime && n > 1)
                Console.WriteLine(n + " is a Prime Number.");
            else
                Console.WriteLine(n + " is not a Prime Number.");
        }


        void Gcd()
        {
            Console.WriteLine("Enter First Number To Find GCD: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number To Find GCD: ");
            int b = Convert.ToInt32(Console.ReadLine());
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            Console.WriteLine("GCD is: " + a);
        }

        void Fibonacci()
        {
            Console.WriteLine("Enter Number of Terms for Fibonacci Series: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c = 0; ;
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine(n + "'th Fibonacci Number: " + c);
        }
    }
}
