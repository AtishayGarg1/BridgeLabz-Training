using System;

class AreaTriangle
{
	static void Main()
	{
		Console.WriteLine("Enter Base Of Traingle");			
		double base_Cm = double.Parse(Console.ReadLine());		// Input base in cm
		Console.WriteLine("Enter Height Of Traingle");		
		double height = double.Parse(Console.ReadLine());		// Input height in cm
		double area = (1.0/2.0) * base_Cm * height;			// applying formula area  = 1/2 * base * height
		double inch = 2.54;						//1 inch = 2.54 cm
		double base_In_Inches = base_Cm / inch;
		double height_In_Inches = height / inch;
		double area_Inches = (1.0/2.0) * base_In_Inches * height_In_Inches;
		Console.WriteLine("Area Of Triangle in Square Inches = " + area_Inches);
		Console.WriteLine("Area Of Triangle in Square Centimeters = " + area);

	}
}