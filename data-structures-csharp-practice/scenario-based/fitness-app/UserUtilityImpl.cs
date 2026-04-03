using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_scenariobased.fitness_app
{
    internal class UserUtilityImpl : IUser
    {
        private User[] Users;
        private int Capacity = 20;
        private int Count = 0;

        public UserUtilityImpl()
        {
            Users = new User[Capacity];
        }

        public void AddUser()
        {
            User singleUser = new User();
            Console.WriteLine("Enter User Name");
            singleUser.UserName1 = Console.ReadLine();
            singleUser.UserSteps1 = 0;

            Users[Count++] = singleUser;
        }

        public void AddSteps()
        {

            User singleUser = new User();

            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Number Of Steps");
            int steps = int.Parse(Console.ReadLine());

            for(int i = 0; i < Users.Length; i++)
            {
                if (Users[i] == null)
                {
                    continue;
                }
                if(Users[i].UserName1 == name)
                {
                    Users[i].UserSteps1 += steps;
                }
            }

            UpdateRanking();
        }

        public void UpdateRanking()
        {

            for (int i = 0; i < Count - 1; i++)
            {
                for(int j = i + 1; j < Count; j++)
                {
                    if (Users[j].UserSteps1 > Users[i].UserSteps1)
                    {
                        User temp = Users[i];
                        Users[i] = Users[j];
                        Users[j] = temp;
                    }
                }
            }
        }

        public void DisplayResult()
        {
            UpdateRanking();
            for(int i = 0; i < Users.Length; i++)
            {
                if (Users[i] == null)
                {
                    continue;
                }
                Console.Write((i + 1)+". "+Users[i].ToString());
            }
        }



    }
}
