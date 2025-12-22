using System;

class EmployeeBonus
{
	static void Main()
	{
		//Read salary of an employee
		Console.Write("Enter salary: ");
		double salary = double.Parse(Console.ReadLine());
		//Read the years of service
		Console.Write("Enter years of service: ");
		int years = int.Parse(Console.ReadLine());
		//Calculate bonus
		if(years > 5)
		{
			double bonus = salary * 0.05;
			Console.WriteLine("Bonus Amount = " + bonus);
		}
		else
		{
			Console.WriteLine("No bonus applicable.");
		}
	}
}
