using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace BridgeLabzTraining.scenariobased
{

    class SnakeLadder
    {
        static void Main()
        {
            SnakeLadder obj = new SnakeLadder();

            obj.Execution();
        }

        void Execution()
        {

            Console.WriteLine("Snake & Ladder Game");

            int playerCount = GetPlayerCount();

            string[] players = new string[playerCount];
            int[] positions = new int[playerCount];

            for (int i = 0; i < playerCount; i++)
            {
                Console.Write("Enter name for Player " + (i + 1) + ": ");
                players[i] = Console.ReadLine();
                positions[i] = 0;
            }

            int[] board = BoardPosition();
            Random rndm = new Random();

            bool gameWon = false;
            int turn = 0;

            while (!gameWon)
            {
                int currentPlayer = turn % playerCount;

                Console.WriteLine("\n " + players[currentPlayer] + "'s turn. Press Enter to roll dice ");
                Console.ReadLine();

                int diceValue = rndm.Next(1, 7);
                int oldPosition = positions[currentPlayer];

                Console.WriteLine("Dice Rolled: " + diceValue);

                if (oldPosition + diceValue <= 100)
                {
                    positions[currentPlayer] += diceValue;

                    if (board[positions[currentPlayer]] != 0)
                    {
                        int finalPosition = board[positions[currentPlayer]];

                        if (finalPosition > positions[currentPlayer])
                            Console.WriteLine("Ladder! Moving up.");
                        else
                            Console.WriteLine("Snake! Sliding down.");

                        positions[currentPlayer] = finalPosition;
                    }
                }
                else
                {
                    Console.WriteLine("Move exceeds 100. Turn skipped.");
                }

                Console.WriteLine(players[currentPlayer] + ": " + oldPosition + " -> " + positions[currentPlayer]);

                if (positions[currentPlayer] == 100)
                {
                    Console.WriteLine("\n " + players[currentPlayer] + " WINS THE GAME!");
                    gameWon = true;
                }
                turn++;
            }
        }

        int GetPlayerCount()
        {
            Console.Write("Enter number of players (2–4): ");
            int count = int.Parse(Console.ReadLine());
            return count;
        }

        int[] BoardPosition()
        {
            int[] board = new int[101]; // index 0–100

            // Ladders
            board[4] = 14;
            board[9] = 31;
            board[20] = 38;
            board[28] = 84;
            board[40] = 59;
            board[63] = 81;

            // Snakes
            board[17] = 7;
            board[54] = 34;
            board[62] = 19;
            board[64] = 60;
            board[87] = 36;
            board[93] = 73;
            board[95] = 75;
            board[99] = 78;

            return board;
        }
    }

}
