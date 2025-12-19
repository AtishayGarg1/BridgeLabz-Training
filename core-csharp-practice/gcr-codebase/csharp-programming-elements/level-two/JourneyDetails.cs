using System;

class JourneyDetails
{
	static void Main()
	{
        	// Read journey details
        	Console.WriteLine("Enter name:");
        	string name = Console.ReadLine();
	        Console.WriteLine("Enter from city:");
        	string fromCity = Console.ReadLine();
	        Console.WriteLine("Enter via city:");
        	string viaCity = Console.ReadLine();
	        Console.WriteLine("Enter destination city:");
        	string toCity = Console.ReadLine();
	        Console.WriteLine("Enter distance from source to via (miles):");
        	double fromToVia = double.Parse(Console.ReadLine());
	        Console.WriteLine("Enter distance from via to destination (miles):");
        	double viaToFinalCity = double.Parse(Console.ReadLine());
	        Console.WriteLine("Enter time taken (hours):");
        	double timeTaken = double.Parse(Console.ReadLine());
	        // Calculate total distance and speed
        	double totalDistance = fromToVia + viaToFinalCity;
        	double speed = totalDistance / timeTaken;
        	Console.WriteLine("The results of the trip are " + totalDistance + ", " + timeTaken + ", and " + speed);
	}
}
