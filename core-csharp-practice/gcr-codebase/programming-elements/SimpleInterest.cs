using System;

class SimpleInterest
{
	static void Main()
	{
		double r = 10.0;
		double t = 3.0;
		double prin = 5000;
		double si = (prin * r * t)/100;
		Console.WriteLine(si);
	}
}