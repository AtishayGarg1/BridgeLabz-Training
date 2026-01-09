using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.fitnesstracker
{
    internal class CardioWorkout : WorkoutUtiltiyImpl
    {
        Random random = new Random();
        private int workoutTime;
        private int caloriesBurnt;
        public CardioWorkout(int user)
        {
            CalculateCalories(user);
        }

        // Function to claculate calories burnt based on workout time
        public void CalculateCalories(int user)
        {
            workoutTime = random.Next(30, 41);
            caloriesBurnt = workoutTime * random.Next(10, 16);
            Profile[user].CaloriesBurnt1 += caloriesBurnt;
            Profile[user].WorkoutTime1 += workoutTime;
            Console.WriteLine("Workout Session Time: "+workoutTime);
            Console.WriteLine("Calories Burnt in Session: "+caloriesBurnt);
        }
    }
}
