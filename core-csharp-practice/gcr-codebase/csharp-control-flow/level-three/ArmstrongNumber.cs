using System;

class ArmstrongNumber
{
	static void Main()
	{
		//Read a Number
		Console.Write("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		int originalNumber = number;
		int sum = 0;
		//Calculate the sum of cubes of digits 
		while(originalNumber != 0)
		{
			int remainder = originalNumber % 10;
			sum = sum + (remainder * remainder * remainder);
			originalNumber = originalNumber / 10;
		}
		if(sum == number)
			Console.WriteLine("Armstrong Number");
		else
			Console.WriteLine("Not an Armstrong Number");
	}
}
