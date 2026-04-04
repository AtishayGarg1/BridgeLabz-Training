using System;

class SumUntilZero
{
	static void Main()
	{
		double total = 0.0;
		double number;
		//Read a Number
		Console.Write("Enter a number (0 to stop): ");
		number = double.Parse(Console.ReadLine());
		//Run loop to find sum until stopped by entering 0
		while(number != 0)
		{
			total += number;
			Console.Write("Enter a number (0 to stop): ");
			number = double.Parse(Console.ReadLine());
		}
		Console.WriteLine("Total Sum = " + total);
	}
}
