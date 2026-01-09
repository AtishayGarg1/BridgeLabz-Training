using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.fitnesstracker
{
    // Utility Class to implement methods
    internal class WorkoutUtiltiyImpl : ITrackable
    {
        // Make the user array static
        protected static UserProfile[] Profile = new UserProfile[100];
        double CaloriesBurned;
        int WorkoutTime;
        static int UserCount;

        // Function to Register a new User
        public void AddUserProfile()
        {
            Profile[UserCount] = new UserProfile();
            Console.WriteLine("Enter User Details\n");
            Console.WriteLine("Enter your Name");
            Profile[UserCount].UserName1 = Console.ReadLine();
            Console.WriteLine("Enter your Gender");
            Profile[UserCount].UserGender1 = Console.ReadLine();
            Console.WriteLine("Enter your Age");
            Profile[UserCount].UserAge1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Height");
            Profile[UserCount].UserHeight1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Weight");
            Profile[UserCount].UserWeight1= int.Parse(Console.ReadLine());
            Profile[UserCount].UserId1 = ++UserCount;
        }

        // Function to display Uses and their Names
        public void DisplayUserList()
        {
            for(int i = 0; i < UserCount; i++)
            {
                Console.WriteLine(Profile[i].UserId1+". "+Profile[i].UserName1);
            }
        }

        // Function to Display User details On search by Id
        public void DisplayUserDetails()
        {
            DisplayUserList();
            Console.Write("Enter User Id: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine(Profile[index].ToString());
        }

        // Function to start workout session
        public void StartWorkout()
        {
            DisplayUserList();
            Console.Write("Enter User Id: ");
            int user = int.Parse(Console.ReadLine()) - 1;
            ITrackable fitnessTrack;
            while (true)
            {
                Console.WriteLine("Select the type of workout");
                Console.WriteLine("1. Cardio Workout");
                Console.WriteLine("2. Strength Workout");
                Console.WriteLine("3. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        fitnessTrack = new CardioWorkout(user);
                        break;
                    case 2:
                        fitnessTrack = new StrengthWorkout(user);
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Enter Valid Choice");
                        break;

                }
            }
        }
    }
}
