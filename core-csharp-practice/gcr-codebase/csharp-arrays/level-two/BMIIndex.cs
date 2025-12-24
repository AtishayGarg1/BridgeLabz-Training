using System;

internal class BMIIndex
{
    static void Main(string[] args)
    {
        //read number of people
        Console.WriteLine("Enter Number Of People");
        int numberOfPeople = int.Parse(Console.ReadLine());

        //calculate BMI index for each persona/
        for (int i = 0; i < numberOfPeople; i++)
        {
            Console.WriteLine("Enter weight in Kilograms");
            double weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Height in Centimeters");
            double height = int.Parse(Console.ReadLine());
            height /= 100;

            double bmiIndex = weight / (height * height);

            Console.WriteLine("BMI Index: " + bmiIndex);
        }
    }
}