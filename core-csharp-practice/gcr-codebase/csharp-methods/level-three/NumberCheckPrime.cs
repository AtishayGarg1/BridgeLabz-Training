using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.levelthree
{
    internal class NumberCheckPrime
    {
        static void Main(string[] args)
        {
            //Read a Number
            Console.WriteLine("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime: " + IsPrime(n));
            Console.WriteLine("Neon: " + IsNeon(n));
        }

        //Function to check if number is Prime
        static bool IsPrime(int n)
        {
            if(n <= 1)
            {
                return false;
            }
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //Function to check if number is Neon
        static bool IsNeon(int n)
        {
            int sq = n * n, sum = 0;
            while(sq > 0) 
            {
                sum += sq % 10; sq /= 10;
            }
            return sum == n;
        }
    }
}
