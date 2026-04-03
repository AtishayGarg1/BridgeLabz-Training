using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.levelone
{
    internal class TrignometryFunction
    {
        static void Main(string[] args)
        {
            //Read angle in degrees
            Console.WriteLine("Enter angle in degrees: ");
            double angle = double.Parse(Console.ReadLine());

            double[] result = CalculateTrigonometricFunctions(angle);
            Console.WriteLine("Sin = " + result[0]);
            Console.WriteLine("Cos = " + result[1]);
            Console.WriteLine("Tan = " + result[2]);
        }

        //Function to calculate Sin, Cos, and Tan of an angle
        public static double[] CalculateTrigonometricFunctions(double angle)
        {
            // Convert angle from degrees to radians
            double radians = angle * Math.PI / 180;
            double sin = Math.Sin(radians);
            double cos = Math.Cos(radians);
            double tan = Math.Tan(radians);

            return new double[] { sin, cos, tan };
        }
    }
}
