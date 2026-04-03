using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased
{
    internal class EduQuizSystem
    {
        static void Main(string[] args)
        {
            EduQuizSystem system = new EduQuizSystem();
            system.Execute();
        }

        // Single execution entry point
        public void Execute()
        {
            string[] correctAnswers = InitializeQuiz();

            bool running = true;
            while(running)
            {
                Console.WriteLine("\nSelect Role:");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Student");
                Console.WriteLine("3. Exit");

                int choice = ReadChoice();

                if(choice == 1)
                {
                    if(VerifyAdmin())
                    {
                        AdminMenu(correctAnswers);
                    }
                    else
                    {
                        Console.WriteLine("Admin verification failed");
                    }
                }
                else if(choice == 2)
                {
                    StudentMenu(correctAnswers);
                }
                else if(choice == 3)
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Invalid selection");
                }
            }
        }

        //Function to Verify Admin
        bool VerifyAdmin()
        {
            Console.WriteLine("\nAdmin Login");
            Console.Write("Enter Admin ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter Admin Password: ");
            string password = Console.ReadLine();

            if(id.Equals("admin") && password.Equals("admin123"))
            {
                Console.WriteLine("Admin verified successfully");
                return true;
            }
            return false;
        }

        //Function For admin to do Operations
        void AdminMenu(string[] correctAnswers)
        {
            bool adminActive = true;

            while(adminActive)
            {
                Console.WriteLine("\nAdmin Menu:");
                Console.WriteLine("1. View Correct Answers");
                Console.WriteLine("2. Update Correct Answers");
                Console.WriteLine("3. Back");

                int choice = ReadChoice();

                if(choice == 1)
                {
                    DisplayCorrectAnswers(correctAnswers);
                }
                else if(choice == 2)
                {
                    UpdateCorrectAnswers(correctAnswers);
                }
                else if(choice == 3)
                {
                    adminActive = false;
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
        }

        //Function to Display Correct Answers to Admin
        void DisplayCorrectAnswers(string[] answers)
        {
            Console.WriteLine("\nCorrect Answers:");
            for(int i = 0; i < answers.Length; i++)
            {
                Console.WriteLine("Question " + (i + 1) + ": " + answers[i]);
            }
        }

        //Function for admin to update correct answers
        void UpdateCorrectAnswers(string[] answers)
        {
            Console.WriteLine("\nEnter updated correct answers:");

            for(int i = 0; i < answers.Length; i++)
            {
                Console.Write("Question " + (i + 1) + ": ");
                answers[i] = Console.ReadLine();
            }

            Console.WriteLine("Correct answers updated successfully");
        }

        //Function to show Student Operations
        void StudentMenu(string[] correctAnswers)
        {
            string[] studentAnswers = GetStudentAnswers();
            int score = CalculateScore(correctAnswers, studentAnswers);
            DisplayResult(score, correctAnswers.Length);
        }

        //Function to Recieve answers from student
        string[] GetStudentAnswers()
        {
            string[] answers = new string[10];

            Console.WriteLine("\nEnter your answers:");

            for(int i = 0; i < answers.Length; i++)
            {
                Console.Write("Question " + (i + 1) + ": ");
                answers[i] = Console.ReadLine();
            }

            return answers;
        }

        //Function to Calculate scores
        int CalculateScore(string[] correct, string[] student)
        {
            int score = 0;

            Console.WriteLine("\nQuiz Feedback:");

            for(int i = 0; i < correct.Length; i++)
            {
                if(string.Equals(correct[i], student[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Question " + (i + 1) + ": Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Question " + (i + 1) + ": Incorrect");
                }
            }

            return score;
        }
        
        //Function to Display student result
        void DisplayResult(int score, int total)
        {
            double percentage = (score * 100.0) / total;

            Console.WriteLine();
            Console.WriteLine("Score: " + score + " / " + total);
            Console.WriteLine("Percentage: " + percentage);

            if(percentage >= 40)
            {
                Console.WriteLine("Result: PASS");
            }
            else
            {
                Console.WriteLine("Result: FAIL");
            }
        }

        //Function to Initialize Correct Answers
        string[] InitializeQuiz()
        {
            return new string[]
            {
                "A", "B", "C", "D", "A",
                "C", "B", "D", "A", "C"
            };
        }

        int ReadChoice()
        {
            int choice;
            int.TryParse(Console.ReadLine(), out choice);
            return choice;
        }
    }
}
