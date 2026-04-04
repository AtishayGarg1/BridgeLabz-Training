using System;

internal class PercentageCalculationOneDimensional
{
    static void Main(string[] args)
    {
        //read number of students
        Console.WriteLine("Enter Number Of Students");
        int number = int.Parse(Console.ReadLine());

        //create one dimensional arrays to store marks and percentage
        double[] chemistry = new double[number];
        double[] physics = new double[number];
        double[] maths = new double[number];
        double[] percentage = new double[number];
        String[] grades = new String[number];

        //calculate percentage and grade for each student
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Enter marks of Chemistry ");
            chemistry[i] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter marks of Physics ");
            physics[i] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter marks of Maths");
            maths[i] = double.Parse(Console.ReadLine());

            percentage[i] = ((chemistry[i] + physics[i] + maths[i]) / 3);

            //determine grade
            if (percentage[i] >= 80)
            {
                grades[i] = "A";
            }
            else if (percentage[i] < 80 && percentage[i] >= 70)
            {
                grades[i] = "B";
            }
            else if (percentage[i] < 70 && percentage[i] >= 60)
            {
                grades[i] = "C";
            }
            else if (percentage[i] < 60 && percentage[i] >= 50)
            {
                grades[i] = "D";
            }
            else if (percentage[i] < 50 && percentage[i] >= 40)
            {
                grades[i] = "E";
            }
            else
            {
                grades[i] = "R";
            }
            Console.WriteLine("Marks in Chemistry: " + chemistry[i] + "\nMarks in Physics: " + physics[i] + "\nMarks in Maths: " + maths[i] + "\nPercentage is: " + percentage[i] + "%" + "\nGrade Of Student is: " + grades[i]);
        }
    }
}