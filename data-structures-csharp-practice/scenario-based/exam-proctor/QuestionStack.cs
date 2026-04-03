using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.DSA_FOLDER.scenariobased.exam_proctor
{
    internal class QuestionStack
    {
        private int[] stack;
        private int top;

        public QuestionStack(int size)
        {
            stack = new int[size];
            top = -1;
        }

        public void Push(int questionId)
        {
            if (top == stack.Length - 1)
            {
                Console.WriteLine("Navigation stack full");
                return;
            }
            stack[++top] = questionId;
        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("No previous question");
                return -1;
            }
            return stack[top--];
        }

        public int Peek()
        {
            return top == -1 ? -1 : stack[top];
        }
    }
}
