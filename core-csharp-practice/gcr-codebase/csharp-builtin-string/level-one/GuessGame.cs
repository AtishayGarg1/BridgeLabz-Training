using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinstring.levelone
{
    internal class GuessGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a Number Between 1 to 100");
            Console.WriteLine("Respond with: H if my guess is Too high | L if my guess is too Low | C if my guess is correct\n");
            Console.WriteLine("Press Enter to Start");
            Console.ReadLine();
            int l = 1;
            int h = 100;
            bool isCorrect = false;

            while (!isCorrect)
            {
                int mid = generateGuess(l, h);
                Console.WriteLine("Is your number " + mid + " ?");
                char response = GenerateResponse(mid);

                int[] result = ProcessResult(response, mid, l, h);

                l = result[0];
                h = result[1];
                if (result[2] == 1)
                {
                    isCorrect = true;
                }
            }
            Console.WriteLine("Game Over");
        }
        public static int generateGuess(int low, int high)
        {
            return (low + high) / 2;
        }
        public static char GenerateResponse(int guess)
        {
            Console.WriteLine("Enter your response (H/L/C): ");
            return Char.ToUpper(Console.ReadLine()[0]);
        }
        public static int[] ProcessResult(char response, int guess, int low, int high)
        {
            int isCorrect = 0;
            if (response == 'H')
            {
                high = guess - 1;
            }
            else if (response == 'L')
            {
                low = guess + 1;
            }
            else if (response == 'C')
            {
                Console.WriteLine("Yay! I guessed your number.");
                isCorrect = 1;
            }
            else
            {
                Console.WriteLine("Invalid Input Respond With H, L or C ");
            }
            return new int[] { low, high, isCorrect };
        }
    }
}
