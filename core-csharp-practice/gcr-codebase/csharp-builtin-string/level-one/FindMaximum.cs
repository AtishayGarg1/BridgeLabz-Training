using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinstring.levelone
{
    internal class FindMaximum
    {
        static void Main(string[] args)
        {
            int[] numbers = InputNumber();
            int n1 = numbers[0];
            int n2 = numbers[1];
            int n3 = numbers[2];

            int max = FindMax(n1, n2, n3);

            Console.WriteLine("Highest among Three Numbers is: " + max);
        }

        // Function to find maximum among three numbers
        public static int FindMax(int n1, int n2, int n3)
        {
            int max = Math.Max(n1, Math.Max(n2, n3));
            return max;
        }

        // Function to take input of three numbers
        public static int[] InputNumber()
        {
            int[] numbers = new int[3];
            Console.WriteLine("Enter 1'st Number");
            numbers[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2'nd Number");

            numbers[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3'rd Number");
            numbers[2] = int.Parse(Console.ReadLine());

            return numbers;
        }
    }
}
