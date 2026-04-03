using System;

class ChocolatesDistribution
{
	static void Main()
	{
		//Read Number Of Children and Number Of Chocolates
		Console.WriteLine("Enter the number of Children");
		int numberOfChildren = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter the number of Chocolates");
		int numberOfChocolates = int.Parse(Console.ReadLine());
		//Chocolates Distributed
		int chocolatesDistributed = numberOfChocolates / numberOfChildren;
		//Remaining Chocolates
		int notDistributed = numberOfChocolates % numberOfChildren;
		Console.WriteLine("The number of chocolates each child gets is " + chocolatesDistributed + 
		"and the number of remaining chocolates is " + notDistributed);
	}
}
