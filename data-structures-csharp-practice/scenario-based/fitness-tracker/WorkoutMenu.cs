using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.fitnesstracker
{
    sealed class WorkoutMenu
    {
        ITrackable Workout;
        
        // Function for fitness tracker menu using switch case
        public void FitnessTrackerMenu()
        {
            Workout = new WorkoutUtiltiyImpl();
            Console.WriteLine("\tWelcome To Fitness Tracker\n");
            while (true)
            {
                Console.WriteLine("1. Register a new User");
                Console.WriteLine("2. Display All Users Name and Id");
                Console.WriteLine("3. Display User Details by Id");
                Console.WriteLine("4. Start Workout Session");
                Console.WriteLine("5. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Workout.AddUserProfile();
                        break;
                    case 2:
                        Console.WriteLine();
                        Workout.DisplayUserList();
                        break;
                    case 3:
                        Console.WriteLine();
                        Workout.DisplayUserDetails(); 
                        break;
                    case 4:
                        Console.WriteLine();
                        Workout.StartWorkout();
                        break;
                    case 5:
                        Console.WriteLine();
                        Console.WriteLine("Exitting Fitness Tracker");
                        return;
                    default:
                        Console.WriteLine("Enter Valid Choice");
                        break;
                }
            }
        }

    }
}
