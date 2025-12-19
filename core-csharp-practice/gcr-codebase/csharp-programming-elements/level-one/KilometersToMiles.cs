using System;

class KilometersToMiles
{
	static void Main()
	{
		double kilometers = 10.8;
		double miles = (1/1.6) * kilometers;
		Console.WriteLine("The distance " + kilometers + " km in miles is " + miles);
	}
}