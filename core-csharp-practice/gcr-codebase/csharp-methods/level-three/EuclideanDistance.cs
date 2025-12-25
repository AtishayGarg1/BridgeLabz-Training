using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.levelthree
{
    internal class EuclideanDistance
    {
        static void Main(string[] args)
        {
            //Read coordinates of two points
            Console.Write("Enter x1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Enter y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Enter x2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Enter y2: ");
            double y2 = double.Parse(Console.ReadLine());

            double distance = FindDistance(x1, y1, x2, y2);
            Console.WriteLine("Euclidean Distance = " + distance);

            double[] line = FindLineEquation(x1, y1, x2, y2);
            Console.WriteLine("Slope (m) = " + line[0]);
            Console.WriteLine("Y-Intercept (b) = " + line[1]);
            Console.WriteLine("Equation: y = " + line[0] + "x + " + line[1]);
        }

        //Function to find Euclidean Distance between two points
        static double FindDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt( Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        //Function to find Line Equation parameters (slope and y-intercept) given two points
        static double[] FindLineEquation(double x1, double y1, double x2, double y2)
        {
            double m = (y2 - y1) / (x2 - x1);
            double b = y1 - m * x1;
            return new double[] { m, b };
        }
    }
}
