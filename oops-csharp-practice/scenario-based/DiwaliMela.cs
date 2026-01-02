using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.DiwaliFestival
{
    internal class Game
    {
        Random rnd = new();

        static void Main(string[] args)
        {
            Game obj = new();
            obj.PlayGame();
        }

        //Function to run the game
        void PlayGame()
        {
            bool play = true;
            while (play)
            {
                Console.WriteLine("Welcome would you like to try your luck\nYes or No\n");
                string luck = Console.ReadLine();
                if (luck.ToLower() == "yes")
                {
                    //Generating number for user
                    long n = rnd.NextInt64(1, 100);
                    Console.WriteLine("\nYour Lucky Number is: " + n);
                    if (n % 3 == 0 && n % 5 == 0)
                    {
                        Console.WriteLine("\nCongratulation! You Won\n");
                    }
                    else
                    {
                        Console.WriteLine("\nBetter Luck Next Time\n");
                    }
                }
                else
                {
                    play = false;
                    Console.WriteLine("\nThank you for visiting\n");
                }
            }

        }

    }
}
