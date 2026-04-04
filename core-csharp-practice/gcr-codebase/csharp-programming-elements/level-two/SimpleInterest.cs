using System;

class SimpleInterest
{
	static void Main()
	{
		//Read Principle Rate and Time to Calculate Simple Interest
		Console.WriteLine("Enter Principle, Rate Of Interest and Time to Calculate Simple Interest");
		double principal = int.Parse(Console.ReadLine());
		double rate = int.Parse(Console.ReadLine());
		double time = int.Parse(Console.ReadLine());
		// SI = (Principal * Rate * Time) / 100
		double interest = (principal * rate * time) / 100;
		Console.WriteLine("The Simple Interest is "+ interest +" for Principal " + principal + ", Rate of Interest "+ rate +" and Time " + time);
	}
}