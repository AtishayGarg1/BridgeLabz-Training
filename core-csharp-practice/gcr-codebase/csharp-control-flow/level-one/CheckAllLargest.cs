using System;

class CheckAllLargest
{
	static void Main()
	{
		Console.WriteLine("Enter 1'st Number");
		int n1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter 2'nd Number");
		int n2 = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter 3'rd Number");
		int n3 = int.Parse(Console.ReadLine());
		bool firstLarge = false;
		bool secondLarge = false;
		bool thirdLarge = false;
		if(n1 > n2 && n1 > n3)
		{
			firstLarge = true;
		}
		if(n2 > n1 && n2 > n3)
		{
			secondLarge = true;
		}
		if(n3 > n1 && n3 > n2)
		{
			thirdLarge = true;
		}
		Console.WriteLine("Is the first number the Largest? " + firstLarge);
		Console.WriteLine("Is the second number the smallest? " + secondLarge);
		Console.WriteLine("Is the third number the smallest? " + thirdLarge);
	}
}