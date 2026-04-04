using System;

class HarshadNumber
{
	static void Main()
	{
		//Read a Number
		Console.Write("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		int originalNumber = number;
		int sum = 0;
		//Calculate the sum of digits
		while(number != 0)
		{
			sum = sum + (number % 10);
			number = number / 10;
		}
		if(originalNumber % sum == 0)
			Console.WriteLine("Harshad Number");
		else
			Console.WriteLine("Not a Harshad Number");
	}
}
