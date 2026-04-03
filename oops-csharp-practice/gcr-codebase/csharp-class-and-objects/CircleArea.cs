using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.csharp_class
{
    internal class CircleArea
    {
        private double radius;
        private double area;
        private double perimeter;

        public CircleArea(double radius)
        {
            this.radius = radius;
        }

        public void CalculatePerimeter()
        {
            perimeter = 2 * Math.PI * radius;
        }

        public void CalculateArea()
        {
            area = Math.PI * radius * radius;
        }

        public void DisplayResult()
        {
            Console.WriteLine("Perimeter of the circle : " + perimeter);
            Console.WriteLine("Area of the circle : " + area);
        }
    }

    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            CircleArea circle = new(radius);
            circle.CalculatePerimeter();
            circle.CalculateArea();
            circle.DisplayResult();
        }
    }
}
