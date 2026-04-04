using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.leveltwo
{
    internal class YoungestAndTallest
    {
        static void Main(string[] args)
        {
            int[] ages = new int[3];
            int[] heights = new int[3];
            //Read ages and heights of Three Friends
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter age: ");
                ages[i] = int.Parse(Console.ReadLine());

                Console.Write("Enter height: ");
                heights[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Youngest Age = " + FindYoungest(ages));
            Console.WriteLine("Tallest Height = " + FindTallest(heights));
        }

        //Function to find Youngest age
        static int FindYoungest(int[] ages)
        {
            int min = ages[0];
            for (int i = 1; i < ages.Length; i++)
            {
                if (ages[i] < min)
                {
                    min = ages[i];
                }
            }
            return min;
        }

        //Function to find Tallest height
        static int FindTallest(int[] heights)
        {
            int max = heights[0];
            for(int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > max)
                {
                    max = heights[i];
                }
            }
            return max;
        }
    }
}
