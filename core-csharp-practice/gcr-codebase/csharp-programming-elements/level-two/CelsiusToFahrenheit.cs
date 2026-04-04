using System;

class CelsiusToFahrenheit
{
	static void Main()
	{
        	// Take temperature in Celsius
        	Console.WriteLine("Enter temperature in Celsius:");
        	double celsius = double.Parse(Console.ReadLine());
	        // Apply conversion formula
        	double fahrenheitResult = (celsius * 9.0 / 5.0) + 32;
        	Console.WriteLine("The " + celsius + " Celsius is " + fahrenheitResult + " Fahrenheit");
	}
}
