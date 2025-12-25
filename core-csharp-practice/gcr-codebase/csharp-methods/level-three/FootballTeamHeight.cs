using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.levelthree
{
    internal class FootballTeamHeight
    {
        static void Main(string[] args)
        {
            //Array to store heights of 11 players
            int[] heights = new int[11];
            Random rnd = new Random();

            for(int i = 0; i < heights.Length; i++)
            {
                heights[i] = rnd.Next(150, 251);
            }

            Console.WriteLine("Heights: ");
            foreach(int h in heights)
            {
                Console.Write(h + " ");
            }

            Console.WriteLine("\nShortest = " + FindShortest(heights));
            Console.WriteLine("Tallest = " + FindTallest(heights));
            Console.WriteLine("Mean Height = " + FindMean(heights));
        }

        //Function to find Sum of heights
        static int FindSum(int[] heights)
        {
            int sum = 0;
            foreach(int h in heights)
            {
                sum += h;
            }
            return sum;
        }

        //Function to find Mean of heights
        static double FindMean(int[] heights)
        {
            return (double)FindSum(heights) / heights.Length;
        }

        //Function to find Shortest height
        static int FindShortest(int[] heights)
        {
            int min = heights[0];
            foreach(int h in heights)
            {
                min = Math.Min(min, h);
            }
            return min;
        }

        //Function to find Tallest height
        static int FindTallest(int[] heights)
        {
            int max = heights[0];
            foreach(int h in heights)
            {
                max = Math.Max(max, h);
            }
            return max;
        }
    }
}
