using System;

class AtheleteRounds
{
	static void Main()
	{	
		////Read the sides of a triangle
		Console.WriteLine("Enter The Sides of a Triangle");	
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int c = int.Parse(Console.ReadLine());
		//Convert 5 km to 5000 meters
		int distance = 5000;					
		int perimeter = a + b + c;
		double rounds = distance / perimeter;
		Console.WriteLine("The total number of rounds the athlete will run is " + rounds + " to complete 5 km");
	}
}
