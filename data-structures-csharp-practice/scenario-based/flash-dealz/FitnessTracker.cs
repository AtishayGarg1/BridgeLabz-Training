
using System;

namespace FitnessTracker
{
    class User
    {
        public string Name;
        public int Steps;
    }

    class FitnessApp
    {
        private User[] users;
        private int count;

        public FitnessApp(int size)
        {
            users = new User[size];
            count = 0;
        }

        public void AddUser(string name, int steps)
        {
            users[count++] = new User { Name = name, Steps = steps };
        }

        public void BubbleSort()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (users[j].Steps < users[j + 1].Steps)
                    {
                        User temp = users[j];
                        users[j] = users[j + 1];
                        users[j + 1] = temp;
                    }
                }
            }
        }

        public void Display()
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine((i + 1) + ". " + users[i].Name + " - " + users[i].Steps);
        }

        static void Main()
        {
            FitnessApp app = new FitnessApp(10);
            app.AddUser("Amit", 8000);
            app.AddUser("Neha", 12000);
            app.AddUser("Rahul", 9500);

            app.BubbleSort();
            app.Display();
        }
    }
}
