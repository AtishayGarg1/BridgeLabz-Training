using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.BrowserBuddy
{
    internal class TabStack
    {
        private Tab[] stack;
        private int top = -1;

        public TabStack(int size)
        {
            stack = new Tab[size];
        }

        public void Push(Tab tab)
        {
            if (top == stack.Length - 1)
            {
                Console.WriteLine("Closed tab stack full");
                return;
            }
            stack[++top] = tab;
        }

        public Tab Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("No closed tabs");
                return null;
            }
            return stack[top--];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
    }

}
