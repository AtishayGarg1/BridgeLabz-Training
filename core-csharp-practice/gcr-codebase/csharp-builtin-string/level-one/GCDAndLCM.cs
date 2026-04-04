using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinstring.levelone
{
    internal class GCDAndLCM
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1'st number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2'nd Number");
            int number2 = int.Parse(Console.ReadLine());

            int lcm = CalculateLCM(number1, number2);
            Console.WriteLine("LCM of " + number1 + " and " + number2 + " is: " + lcm);

            int gcd = CalculateGCD(number1, number2);
            Console.WriteLine("GCD of " + number1 + " and " + number2 + " is: " + gcd);
        }

        // Function to calculate LCM
        public static int CalculateLCM(int n1, int n2)
        {
            int max = Math.Max(n1, n2);
            int lcm = max;
            while (true)
            {
                if (lcm % n1 == 0 && lcm % n2 == 0)
                {
                    break;
                }
                lcm += max;
            }
            return lcm;
        }

        // Function to calculate GCD
        public static int CalculateGCD(int n1, int n2)
        {
            while (n2 != 0)
            {
                int temp = n2;
                n2 = n1 % n2;
                n1 = temp;
            }
            return n1;
        }
    }
}
