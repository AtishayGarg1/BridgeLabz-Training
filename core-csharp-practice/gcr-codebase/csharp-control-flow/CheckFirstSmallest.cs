using System;

class CheckFirstSmallest
{
	static void Main()
	{
		Console.WriteLine("Enter 1'st Number");
		int n1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter 2'nd Number");
		int n2 = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter 3'rd Number");
		int n3 = int.Parse(Console.ReadLine());
		bool ans = false;
		if(n1 < n2 && n1 < n3)
		{
			ans = true;
		}
			Console.WriteLine("Is the first number the smallest? " + ans);
	}
}