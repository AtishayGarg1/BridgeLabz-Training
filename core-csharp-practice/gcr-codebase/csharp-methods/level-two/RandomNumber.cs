using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.leveltwo
{
    internal class RandomNumber
    {
        static void Main(string[] args)
        {
            //Generate array of 5 random 4-digit numbers
            int[] numbers = Generate4DigitRandomArray(5);
            foreach(int n in numbers)
            {
                Console.WriteLine(n);
            }

            double[] result = FindAverageMinMax(numbers);
            Console.WriteLine("Average = " + result[0]);
            Console.WriteLine("Min = " + result[1]);
            Console.WriteLine("Max = " + result[2]);
        }

        //Function to generate array of random 4-digit numbers
        static int[] Generate4DigitRandomArray(int size)
        {
            int[] arr = new int[size];
            Random rnd = new Random();

            for(int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(1000, 10000);
            }

            return arr;
        }

        //Function to find Average, Min and Max from an array
        static double[] FindAverageMinMax(int[] numbers)
        {
            int min = numbers[0], max = numbers[0], sum = 0;

            foreach(int n in numbers)
            {
                sum += n;
                min = Math.Min(min, n);
                max = Math.Max(max, n);
            }

            return new double[] { (double)sum / numbers.Length, min, max };
        }
    }
}
