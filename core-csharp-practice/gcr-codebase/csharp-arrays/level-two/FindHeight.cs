using System;

internal class FindHeight
{
    static void Main(string[] args)
    {
        //create arrays to store names, age and height of 3 friends
        String[] names = { "Amar", "Akbar", "Anthony" };
        int[] age = new int[3];
        int[] height = new int[3];
        int youngestIndex = 0;
        int tallestIndex = 0;

        //read age and height for each friend
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine("Enter Age");
            age[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter height");
            height[i] = int.Parse(Console.ReadLine());
        }

        //find youngest and tallest friend
        for (int i = 1; i < age.Length; i++)
        {
            if (age[i] < age[youngestIndex])
            {
                youngestIndex = i;
            }
            if (height[i] > height[tallestIndex])
            {
                tallestIndex = i;
            }
        }
        Console.WriteLine("Tallest friend: " + height[tallestIndex]);
        Console.WriteLine("Youngest friend: " + age[youngestIndex]);
    }
}