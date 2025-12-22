using System;

class Calculator
{
	static void Main()
	{
		//Read First Number
		Console.Write("Enter first number: ");
		double first = double.Parse(Console.ReadLine());
		//Read Second Number
		Console.Write("Enter second number: ");
		double second = double.Parse(Console.ReadLine());
		//Read An Operator
		Console.Write("Enter operator (+, -, *, /): ");
		string op = Console.ReadLine();
		//Use Switch Case to Perform Operations
		switch (op)
		{
			case "+":
				Console.WriteLine("Result: " + (first + second));
				break;

			case "-":
				Console.WriteLine("Result: " + (first - second));
				break;

			case "*":
				Console.WriteLine("Result: " + (first * second));
				break;

			case "/":
				if (second != 0)
					Console.WriteLine("Result: " + (first / second));
				else
					Console.WriteLine("Division by zero not allowed");
				break;

			default:
				Console.WriteLine("Invalid Operator");
				break;
		}
	}
}
