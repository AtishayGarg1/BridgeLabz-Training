using System;

internal class CheckVotingAge
{

    static void Main(string[] args)
    {
        //read age of students
        int[] students = new int[10];
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine("Enter Students Age");
            students[i] = int.Parse(Console.ReadLine());

            //check voting age for each student
            if (students[i] >= 18)
            {
                Console.WriteLine("The student with the age " + students[i] + " can vote.");
            }
            else
            {
                Console.WriteLine("The student with the age " + students[i] + " cannot vote.");
            }
        }
    }
}