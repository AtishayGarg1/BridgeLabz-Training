using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.leveltwo
{
    internal class FindRootsQuadraticEquation
    {
        static void Main(string[] args)
        {
            //Read coefficients a, b and c
            Console.WriteLine("Enter a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter c: ");
            double c = double.Parse(Console.ReadLine());
            double[] roots = FindRoots(a, b, c);

            if(roots.Length == 0)
            {
                Console.WriteLine("No real roots");
            }
            else
            {
                foreach(double r in roots)
                {
                    Console.WriteLine("Root = " + r);
                }
            }
        }

        //Function to find Roots of Quadratic Equation
        static double[] FindRoots(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            if(delta < 0)
            {
                return new double[0];
            }
            if(delta == 0)
            {
                return new double[] { -b / (2 * a) };
            }

            double sqrt = Math.Sqrt(delta);
            return new double[] { (-b + sqrt)/(2 * a), (-b - sqrt)/(2 * a) };
        }
    }
}
