using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Linear_Binary_Search
{
    internal class FirstNegative
    {
        public void FindNegative()
        {
            Console.WriteLine("Enter length Of array");
            int length = int.Parse(Console.ReadLine());
            int[] numberArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter number");
                numberArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < length; i++)
            {
                if (numberArray[i] < 0)
                {
                    Console.Write("First Negative Number: " + numberArray[i]);
                    return;
                }
            }
            Console.WriteLine("Negative number Not Found");

        }
        static void Main(string[] args)
        {
            FirstNegative firstNegative = new FirstNegative();
            firstNegative.FindNegative();
        }
    }
}
