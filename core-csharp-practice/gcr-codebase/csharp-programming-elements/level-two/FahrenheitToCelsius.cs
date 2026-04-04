using System;

class FahrenheitToCelsius
{
	static void Main()
	{
        	// Take temperature in Fahrenheit
        	Console.WriteLine("Enter temperature in Fahrenheit:");
        	double fahrenheit = double.Parse(Console.ReadLine());
	        // Apply conversion formula
        	double celsiusResult = (fahrenheit - 32) * 5.0 / 9.0;
        	Console.WriteLine("The " + fahrenheit + " Fahrenheit is " + celsiusResult + " Celsius");
	}
}
