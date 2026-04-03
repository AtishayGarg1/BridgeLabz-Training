using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.DSA_FOLDER.scenariobased.exam_proctor
{
    internal class Evaluator
    {
        public static int CalculateScore( AnswerMap answers, int[] correctAnswers, int totalQuestions)
        {
            int score = 0;

            for (int i = 0; i < totalQuestions; i++)
            {
                char studentAnswer = answers.Get(i + 1);
                if (studentAnswer != '\0' &&
                    studentAnswer == (char)correctAnswers[i])
                {
                    score++;
                }
            }
            return score;
        }
    }
}
