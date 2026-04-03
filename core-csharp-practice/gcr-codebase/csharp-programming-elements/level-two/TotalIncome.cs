using System;

class TotalIncome
{
	static void Main()
	{
        	// Read salary and bonus
        	Console.WriteLine("Enter salary:");
        	int salary = int.Parse(Console.ReadLine());
	        Console.WriteLine("Enter bonus:");
        	int bonus = int.Parse(Console.ReadLine());
	        // Calculate total income
        	int totalIncome = salary + bonus;
        	Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + ". Hence Total Income is INR " + totalIncome);
	}
}
