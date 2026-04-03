using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.levelone
{
    internal class ChocolatesDistribution
    {
        static void Main(string[] args)
        {
            //Read number of chocolates and children
            Console.WriteLine("Enter number of chocolates: ");
            int chocolates = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of children: ");
            int children = int.Parse(Console.ReadLine());

            int[] result = FindChocolates(chocolates, children);
            Console.WriteLine("Each child gets: " + result[0]);
            Console.WriteLine("Remaining chocolates: " + result[1]);
        }

        //Function to find chocolates distribution
        public static int[] FindChocolates(int chocolates, int children)
        {
            int eachGets = chocolates / children;
            int remaining = chocolates % children;

            return new int[] { eachGets, remaining };
        }
    }
}
