using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.fitnesstracker
{
    internal class StrengthWorkout : WorkoutUtiltiyImpl
    {
        Random random = new Random();
        private int workoutTime;
        private int caloriesBurnt;
        public StrengthWorkout(int user)
        {
            CalculateCalories(user);
        }

        // Function to claculate calories burnt based on workout time
        public void CalculateCalories(int user)
        {
            workoutTime = random.Next(40, 81);
            caloriesBurnt = workoutTime * random.Next(2, 11);
            Profile[user].WorkoutTime1 += workoutTime;
            Profile[user].CaloriesBurnt1 += caloriesBurnt;
            Console.WriteLine("Workout Session Time: " + workoutTime);
            Console.WriteLine("Calories Burnt in Session: " + caloriesBurnt);
        }
    }
}
