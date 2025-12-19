using System;

class CalculateDistance
{
	static void Main()
	{
		Console.WriteLine("Enter Distance in Kilometers ");
		double distance = double.Parse(Console.ReadLine());			//Input distance in Kilometers
		double distance_In_Miles = 1.0/1.6 * distance;				// 1 mile = 1.6 km
		Console.WriteLine("The total miles is " + distance_In_Miles + "mile for the given " + distance + "km");
	}
}