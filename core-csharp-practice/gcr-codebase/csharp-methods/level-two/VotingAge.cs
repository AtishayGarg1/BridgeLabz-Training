using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.leveltwo
{
    internal class VotingAge
    {
        static void Main(string[] args)
        {
            //Array to Read Ages of 10 Students
            int[] ages = new int[10];
            for (int i = 0; i < ages.Length; i++)
            {
                //Read age of student
                Console.WriteLine("Enter age of student " + (i + 1) + ": ");
                ages[i] = int.Parse(Console.ReadLine());

                Console.WriteLine(CanStudentVote(ages[i]) ? "Can Vote" : "Cannot Vote");
            }
        }

        //Function to check if a student can vote based on age
        public static bool CanStudentVote(int age)
        {
            if(age < 0)
            {
                return false;
            }
            return age >= 18;
        }
    }
}
