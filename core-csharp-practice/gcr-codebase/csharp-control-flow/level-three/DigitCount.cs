using System;

class DigitCount
{
	static void Main()
	{
		//Read a Number
		Console.Write("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		int count = 0;
		//Use while loop to calculate digit count
		while(number != 0)
		{
			number = number / 10;
			count++;
		}
		Console.WriteLine("Number of digits: " + count);
	}
}
