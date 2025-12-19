using System;

class HeightConversion
{
	static void Main()
	{
        	Console.WriteLine("Enter your height in centimeters:");
        	double height_In_Cm = double.Parse(Console.ReadLine());			//Input height in cm
        	double total_Inches = height_In_Cm / 2.54;				// i inch = 2.54 cm
        	int feet = (int)(total_Inches / 12);					// 1 foot = 12 inches
        	double inches = total_Inches % 12;
        	Console.WriteLine("Your height in cm is " + height_In_Cm + " while in feet is " + feet + " and inches is " + inches);
	}
}
