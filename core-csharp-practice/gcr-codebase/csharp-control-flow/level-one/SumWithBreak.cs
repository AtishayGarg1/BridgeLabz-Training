using System;

class SumWithBreak
{
	static void Main()
	{
		double total = 0.0;
		while(true)
		{
			//Read a Number to find sum
			Console.Write("Enter a number (0 or negative to stop): ");
			double num = double.Parse(Console.ReadLine());
			//if number is zero or negative break the loop
			if(num <= 0)
			{
				break;
			}
			total += num;
		}
		Console.WriteLine("Total Sum = " + total);
	}
}
