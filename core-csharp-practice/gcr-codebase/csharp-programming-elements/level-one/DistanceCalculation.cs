using System;

class DistanceCalculation
{
	static void Main()
	{
		Console.WriteLine("Enter Distance in Feet");
		double distance = double.Parse(Console.ReadLine());		//Input distance in feet
		double distance_Yard = distance / 3.0;				// 1 yard is 3 feet 
		double distance_Miles = distance_Yard / 1760.0;			// 1 mile is 1760 yard
		Console.WriteLine("Distance Of " + distance + " Feet in Yard is " + distance_Yard + " and in Miles is " + distance_Miles);
	}
}