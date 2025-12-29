using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace BridgeLabzTraining.scenariobased
{
    internal class TextFormatterApp
    {
        static void Main(string[] args)
        {
            TextFormatterApp app = new TextFormatterApp();
            app.Run();
        }

        // Main application loop
        public void Run()
        {
            Console.WriteLine(" Sentence Formatter Console Application ");
            string userText = ReadParagraph();
            ShowMenu(userText);
        }

        // Read paragraph from user
        private string ReadParagraph()
        {
            Console.WriteLine("Enter a paragraph:");
            return Console.ReadLine();
        }

        // Display menu and handle user choices
        private void ShowMenu(string originalText)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Insert space after punctuation");
                Console.WriteLine("2. Remove extra spaces");
                Console.WriteLine("3. Capitalize sentence starts");
                Console.WriteLine("4. Apply all formatting");
                Console.WriteLine("5. Enter new paragraph");
                Console.WriteLine("6. Exit");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(InsertPunctuationSpaces(originalText));
                        break;

                    case 2:
                        Console.WriteLine(CleanExtraSpaces(originalText));
                        break;

                    case 3:
                        Console.WriteLine(FixCapitalization(originalText));
                        break;

                    case 4:
                        string result = InsertPunctuationSpaces(originalText);
                        result = CleanExtraSpaces(result);
                        result = FixCapitalization(result);
                        Console.WriteLine(result);
                        break;

                    case 5:
                        originalText = ReadParagraph();
                        break;

                    case 6:
                        Console.WriteLine("Application terminated.");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Please choose a valid option.");
                        break;
                }
            }
        }

        // Remove extra spaces from the input
        private string CleanExtraSpaces(string input)
        {
            StringBuilder output = new StringBuilder();
            bool previousSpace = false;

            foreach (char ch in input.Trim())
            {
                if (ch == ' ')
                {
                    if (!previousSpace)
                    {
                        output.Append(ch);
                        previousSpace = true;
                    }
                }
                else
                {
                    output.Append(ch);
                    previousSpace = false;
                }
            }
            return output.ToString();
        }

        // Capitalize the first letter of each sentence
        private string FixCapitalization(string input)
        {
            StringBuilder result = new StringBuilder(input.Length);
            bool capitalizeNext = true;

            foreach (char ch in input)
            {
                if (capitalizeNext && char.IsLetter(ch))
                {
                    result.Append(char.ToUpper(ch));
                    capitalizeNext = false;
                }
                else
                {
                    result.Append(ch);
                }

                if (ch == '.' || ch == '?' || ch == '!')
                {
                    capitalizeNext = true;
                }
            }
            return result.ToString();
        }

        // Insert space after punctuation if missing
        private string InsertPunctuationSpaces(string input)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                result.Append(current);

                if ((current == '.' || current == ',' || current == '?' || current == '!')
                    && i + 1 < input.Length
                    && input[i + 1] != ' ')
                {
                    result.Append(' ');
                }
            }
            return result.ToString();
        }
    }
}