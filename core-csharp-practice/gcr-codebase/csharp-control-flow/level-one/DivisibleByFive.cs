using System;

class DivisibleByFive
{
	static void Main()
	{
		Console.WriteLine("Enter a Number");
		int number = int.Parse(Console.ReadLine());
		bool ans = (number % 5 == 0) ? true:false;
		Console.WriteLine("Is the number "+ number +" divisible by 5? " + ans);
	}
}