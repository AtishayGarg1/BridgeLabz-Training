using System;

class CelciusToFahrenheit
{
	static void Main()
	{
		double cel = 20.0;
		double fah = (cel * 9/5) + 32;
		Console.WriteLine("Temperature In Fahrenheit is: " + fah);
	}
}