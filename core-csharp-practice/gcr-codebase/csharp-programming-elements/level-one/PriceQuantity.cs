using System;

class PriceQuantity
{
	static void Main()
	{
		Console.WriteLine("Enter The Quantity Of Unit");	
		int unit = int.Parse(Console.ReadLine());		//Input Number Of units
		Console.WriteLine("Enter the Price of each unit");	
		int price = int.Parse(Console.ReadLine());		//Input Price of 1 unit
		int total_Price = price * unit;
		Console.WriteLine("The total purchase price is INR " + total_Price + " if the quantity " + unit + " and unit price is INR " + price);
	}
}