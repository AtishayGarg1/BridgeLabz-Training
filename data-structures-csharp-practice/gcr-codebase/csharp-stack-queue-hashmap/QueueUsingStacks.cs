using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stackqueuehashmap
{
    internal class QueueUsingStacks
    {
        private Stack<int> stackEnqueue = new Stack<int>();
        private Stack<int> stackDequeue = new Stack<int>();

        // Enqueue operation
        public void Enqueue(int value)
        {
            stackEnqueue.Push(value);
        }

        // Dequeue operation
        public int Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            if (stackDequeue.Count == 0)
            {
                while (stackEnqueue.Count > 0)
                {
                    stackDequeue.Push(stackEnqueue.Pop());
                }
            }

            return stackDequeue.Pop();
        }

        // Peek front element
        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            if (stackDequeue.Count == 0)
            {
                while (stackEnqueue.Count > 0)
                {
                    stackDequeue.Push(stackEnqueue.Pop());
                }
            }

            return stackDequeue.Peek();
        }

        // Check if queue is empty
        public bool IsEmpty()
        {
            return stackEnqueue.Count == 0 && stackDequeue.Count == 0;
        }

        static void Main()
        {
            QueueUsingStacks queue = new QueueUsingStacks();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }
}
