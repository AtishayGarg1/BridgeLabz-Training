using System;

class CountDownFor
{
	static void Main()
	{
		//Read Input for Rocket Launch
		Console.Write("Enter countdown start number: ");
		int n = int.Parse(Console.ReadLine());
		//Run Loop for Counter
		for(int i = n; i >= 1; i--)
		{
			Console.WriteLine(i);
		}
	}
}
