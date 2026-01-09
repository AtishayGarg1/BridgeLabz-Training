using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.fitnesstracker
{
    internal class UserProfile
    {
        private string UserName;
        private string UserGender;
        private int UserAge;
        private int UserId;
        private int UserHeight;
        private int UserWeight;
        private int WorkoutTime;
        private int CaloriesBurnt;

        public string UserName1 { get => UserName; set => UserName = value; }
        public string UserGender1 { get => UserGender; set => UserGender = value; }
        public int UserAge1 { get => UserAge; set => UserAge = value; }
        public int UserId1 { get => UserId; set => UserId = value; }
        public int UserHeight1 { get => UserHeight; set => UserHeight = value; }
        public int UserWeight1 { get => UserWeight; set => UserWeight = value; }
        public int WorkoutTime1 { get => WorkoutTime; set => WorkoutTime = value; }
        public int CaloriesBurnt1 { get => CaloriesBurnt; set => CaloriesBurnt = value; }

        public override string? ToString()
        {
            return $"Name: {UserName}\nId: {UserId}\nGender: {UserGender}\nAge: {UserAge}\nHeight: {UserHeight}\nWeight: {UserWeight}\nTotal Workout Time: {WorkoutTime} minutes\nTotal Calories Burnt: {CaloriesBurnt} cal\n";
        }
    }
}
