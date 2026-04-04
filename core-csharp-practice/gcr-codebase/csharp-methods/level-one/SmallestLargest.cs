using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.levelone
{
    internal class SmallestLargest
    {
        static void Main(string[] args)
        {
            //Read three numbers
            Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            int c = int.Parse(Console.ReadLine());

            int[] result = FindSmallestLargest(a, b, c);
            Console.WriteLine("Smallest = " + result[0]);
            Console.WriteLine("Largest = " + result[1]);
        }

        //Function to find Smallest and Largest Numbers
        public static int[] FindSmallestLargest(int number1, int number2, int number3)
        {
            int smallest = Math.Min(number1, Math.Min(number2, number3));
            int largest = Math.Max(number1, Math.Max(number2, number3));

            return new int[] { smallest, largest };
        }
    }
}
