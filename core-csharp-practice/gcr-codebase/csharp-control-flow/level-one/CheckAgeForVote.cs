using System;

class CheckAgeForVote
{
	static void Main()
	{
		Console.WriteLine("Enter your Age");
		int number = int.Parse(Console.ReadLine());
		if(number < 18)
		{
			Console.WriteLine("The person's age is "+number+" and cannot vote.");
		}
		else
		{
			Console.WriteLine("The person's age is "+number+"and can vote.");
		}
	}
}