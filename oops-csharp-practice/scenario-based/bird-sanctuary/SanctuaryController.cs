using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.bird_sanctuary
{
    internal class SanctuaryController
    {
        //Array to store birds in Sanctuary
        private BirdBase[] birds;
        private int count;

        public SanctuaryController(int capacity)
        {
            birds = new BirdBase[capacity];
            count = 0;
        }

        //Function to run program
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n--- Bird Sanctuary ---");
                Console.WriteLine("1. Add Bird");
                Console.WriteLine("2. View Birds");
                Console.WriteLine("3. Perform Actions");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddBird();
                        break;
                    case 2:
                        ShowBirds();
                        break;
                    case 3:
                        PerformActions();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        //Function to add bird
        private void AddBird()
        {
            if (count == birds.Length)
            {
                Console.WriteLine("Sanctuary is full.");
                return;
            }

            Console.WriteLine("1. Eagle");
            Console.WriteLine("2. Duck");
            Console.WriteLine("3. Penguin");
            Console.WriteLine("3. Seagull");
            Console.WriteLine("3. Sparrow");
            Console.Write("Select bird type: ");

            int type = int.Parse(Console.ReadLine());

            Console.Write("Enter lifespan: ");
            int lifespan = int.Parse(Console.ReadLine());

            switch (type)
            {
                case 1:
                    birds[count++] = new Eagle(lifespan);
                    break;
                case 2:
                    birds[count++] = new Duck(lifespan);
                    break;
                case 3:
                    birds[count++] = new Penguin(lifespan);
                    break;
                case 4:
                    birds[count++] = new Seagull(lifespan);
                    break;
                case 5:
                    birds[count++] = new Sparrow(lifespan);
                    break;
                default:
                    Console.WriteLine("Invalid bird type.");
                    break;
            }
        }

        //Function to show bird
        private void ShowBirds()
        {
            if (count == 0)
            {
                Console.WriteLine("No birds available.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine((i + 1) + ". " + birds[i].GetDetails());
            }
        }

        private void PerformActions()
        {
            for (int i = 0; i < count; i++)
            {
                birds[i].Eat();

                if (birds[i] is IFlyable)
                {
                    ((IFlyable)birds[i]).Fly();
                }

                if (birds[i] is ISwimmable)
                {
                    ((ISwimmable)birds[i]).Swim();
                }

                Console.WriteLine();
            }
        }
    }
}
