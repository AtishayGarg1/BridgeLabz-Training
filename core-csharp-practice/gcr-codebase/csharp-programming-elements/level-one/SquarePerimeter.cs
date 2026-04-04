using System;

class SquarePerimeter
{
	static void Main()
	{
		Console.WriteLine("Enter the Perimeter Of Square");		
		double perimeter = double.Parse(Console.ReadLine());		//Input Perimeter Of a Square
		double side = perimeter / 4.0;					//Perimeter is Sides multiplied by 4
		Console.WriteLine("The length of the side is " + side +  " whose perimeter is " + perimeter);
	}
}
