using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_scenariobased.fitness_app
{
    sealed class FitnessMenu
    {
        private IUser User;
        public void Menu()
        {
            User = new UserUtilityImpl();
            while (true)
            {
                Console.WriteLine("Welcome to Fitness Tracker App");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Add Steps");
                Console.WriteLine("3. Display LeaderBoard");
                Console.WriteLine("4. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        User.AddUser();
                        break;
                    case 2:
                        User.AddSteps();
                        break;
                    case 3:
                        User.DisplayResult();
                        break;
                    case 4:
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
