using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructors
{
    internal class Circle
    {
        // Radius of the circle
        public int radius;

        // Parameterized constructor
        public Circle(int radius)
        {
            this.radius = radius;
        }

        // Default constructor
        public Circle()
        {
            radius = 7;
        }

        // Method to calculate and display area
        public void Display()
        {
            double ans = 3.14 * radius * radius;
            Console.WriteLine("Area Of Circle of radius: " + radius + " is: " + ans);
        }
    }

    // Main execution class
    public class run
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.WriteLine("Default");
            circle.Display();

            Console.WriteLine("\nParameterized");
            Circle ans = new Circle(8);
            ans.Display();
        }
    }
}
