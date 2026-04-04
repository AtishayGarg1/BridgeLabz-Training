using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinstring.levelone
{
    internal class BasicCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1'st Number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2'nd Number");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Select Operation: +, -, *, /");
            char operation = Console.ReadLine()[0];

            int result = 0;

            switch (operation)
            {
                case '+':
                    result = Add(number1, number2);
                    break;
                case '-':
                    result = Subtract(number1, number2);
                    break;
                case '*':
                    result = Multiply(number1, number2);
                    break;
                case '/':
                    result = Divide(number1, number2);
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    return;
            }

            Console.WriteLine("Result after operation is: " + result);
        }

        // Function to add two numbers
        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        // Function to subtract two numbers
        public static int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }

        // Function to multiply two numbers
        public static int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }

        // Function to divide two numbers
        public static int Divide(int n1, int n2)
        {
            if (n2 == 0)
            {
                Console.WriteLine("Error: Division by zero");
                return 0;
            }
            return n1 / n2;
        }
    }
}
