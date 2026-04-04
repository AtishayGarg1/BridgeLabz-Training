using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.DSA_FOLDER.scenariobased.exam_proctor
{
    internal class ExamProctor
    {
        static void Main(string[] args)
        {
            QuestionStack navigation = new QuestionStack(10);
            AnswerMap answers = new AnswerMap(10);

            // Correct answers
            int[] correct = { 'A', 'C', 'B', 'D', 'A' };

            // Student navigates questions
            navigation.Push(1);
            navigation.Push(2);
            navigation.Push(3);

            // Student answers
            answers.Put(1, 'A');
            answers.Put(2, 'C');
            answers.Put(3, 'B');
            answers.Put(4, 'D');

            // Student goes back
            Console.WriteLine("Last visited question: " + navigation.Pop());

            // Submit exam
            int score = Evaluator.CalculateScore(answers, correct, 5);
            Console.WriteLine("Final Score: " + score + "/5");
        }
    }
}
