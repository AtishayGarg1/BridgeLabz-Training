using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.levelone
{
    internal class CalculateRounds
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sides of triangle in Meters ");

            //Read Sides of Triangle
            int side1 = int.Parse(Console.ReadLine());
            int side2 = int.Parse(Console.ReadLine());
            int side3 = int.Parse(Console.ReadLine());
            int rounds = RoundsCalculation(side1,side2,side3);

            Console.WriteLine("The total round are " + rounds);

        }
        //Function to calculate number of rounds
        public static int RoundsCalculation(int n1, int n2, int n3)
        {
            int rounds = 5000/(n1+n2+n3);                
            return rounds;
        }
    }
}
