using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.leveltwo
{
    internal class PositiveNegativeZero
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for(int i = 0; i < numbers.Length; i++)
            {
                //Read a Number
                Console.WriteLine("Enter number: ");
                numbers[i] = int.Parse(Console.ReadLine());

                if(IsPositive(numbers[i]))
                {
                    Console.WriteLine(IsEven(numbers[i]) ? "Positive Even" : "Positive Odd");
                }
                else
                {
                    Console.WriteLine("Negative");
                }
            }

            int result = Compare(numbers[0], numbers[4]);
            Console.WriteLine(result == 1 ? "First > Last" : result == 0 ? "First = Last" : "First < Last");
        }

        //Function to check if number is Positive
        static bool IsPositive(int n)
        {
            return n >= 0;
        }

        //Function to check if number is Negative
        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        //Function to compare two numbers
        static int Compare(int a, int b)
        {
            if (a > b)
            {
                return 1;
            }
            if (a == b)
            {
                return 0;
            } 
            return -1;
        }
    }
}
