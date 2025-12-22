using System;

class PositiveNegative
{
	static void Main()
	{
		Console.WriteLine("Enter a Number");
		int number = int.Parse(Console.ReadLine());
		if(number < 0)
		{
			Console.WriteLine("The Number "+number+" is Positive");
		}
		if(number > 0)
		{
			Console.WriteLine("The Number "+number+" is Negative");
		}
		if(number == 0)
		{
			Console.WriteLine("The Number "+number+" is Zero");
		}
	}
}