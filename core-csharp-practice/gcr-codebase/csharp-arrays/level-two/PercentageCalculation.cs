using System;

internal class PercentageCalculation
{
    static void Main(string[] args)
    {
        //read number of students
        Console.WriteLine("Enter Number Of Students");
        int number = int.Parse(Console.ReadLine());

        //create a two dimensional array to store marks and percentage
        double[,] arr = new double[number, 4];
        String[] grades = new String[number];

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Enter marks of Chemistry ");
            arr[i, 0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter marks of Physics ");
            arr[i, 1] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter marks of Maths");
            arr[i, 2] = double.Parse(Console.ReadLine());

            arr[i, 3] = ((arr[i, 0] + arr[i, 1] + arr[i, 2]) / 3);

            //determine grade
            if (arr[i, 3] >= 80)
            {
                grades[i] = "A";
            }
            else if (arr[i, 3] < 80 && arr[i, 3] >= 70)
            {
                grades[i] = "B";
            }
            else if (arr[i, 3] < 70 && arr[i, 3] >= 60)
            {
                grades[i] = "C";
            }
            else if (arr[i, 3] < 60 && arr[i, 3] >= 50)
            {
                grades[i] = "D";
            }
            else if (arr[i, 3] < 50 && arr[i, 3] >= 40)
            {
                grades[i] = "E";
            }
            else
            {
                grades[i] = "R";
            }
            Console.WriteLine("Marks in Chemistry: " + arr[i, 0] + "\nMarks in Physics: " + arr[i, 1] + "\nMarks in Maths: " + arr[i, 2] + "\nPercentage is: " + "%" + arr[i, 3] + "\nGrade Of Student is: " + grades[i]);
        }
    }
}