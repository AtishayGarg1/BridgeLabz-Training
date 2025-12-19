using System;

class VolumeOfEarth
{
	static void Main()
	{
		int earths_Radius = 6378;										// Earth's Radius = 6378 km
		double volume_In_Kilometers = (4.0/3.0) * earths_Radius * earths_Radius * earths_Radius * Math.PI;	//Volume = 4/3*PI*r^3
		double earths_Radius_In_Miles = (1.0/1.6) * earths_Radius;						//1 mile = 1.6km
		double volume_In_Miles = (4.0/3.0) * earths_Radius_In_Miles * earths_Radius_In_Miles * earths_Radius_In_Miles * Math.PI;
		Console.WriteLine("The volume of earth in cubic kilometers is " + volume_In_Kilometers + "and cubic miles is " + volume_In_Miles);
	}
}