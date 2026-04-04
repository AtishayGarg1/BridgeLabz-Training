using System;

class WeightConversion
{
	static void Main()
	{
		//Read Weight in pounds
		Console.WriteLine("Enter the Weight in Pounds");
		double weightPounds = double.Parse(Console.ReadLine());
		// 1 kg = 2.2 pounds
		double weightInKilograms = weightPounds / 2.2;
		Console.WriteLine("The weight of the person in pounds is "+ weightPounds +" and in kg is " + weightInKilograms);
	}
}