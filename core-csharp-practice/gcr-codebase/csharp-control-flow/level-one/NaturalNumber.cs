using System;

class NaturalNumber
{
	static void Main()
	{
		Console.WriteLine("Enter a Number");
		int number = int.Parse(Console.ReadLine());
		if(number < 0)
		{
			Console.WriteLine("The number "+number+"is not a natural number");
		}
		else
		{
			int sum = (number *(number+1))/2;
			Console.WriteLine("The sum of "+number+"natural numbers is "+sum);
		}
	}
}