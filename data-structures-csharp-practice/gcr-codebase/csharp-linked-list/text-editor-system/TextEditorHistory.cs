using BridgeLabzTraining.linkedlist.onlineticketreversationsystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.texteditorsystem
{
    internal class TextEditorHistory
    {
        private TextStateNode head;
        private TextStateNode tail;
        private TextStateNode current;
        private int size;
        private readonly int maxSize;

        public TextEditorHistory(int maxSize = 10)
        {
            head = null;
            tail = null;
            current = null;
            size = 0;
            this.maxSize = maxSize;
        }

        public void AddState(string content)
        {
            TextStateNode node = new TextStateNode(content);

            if (head == null)
            {
                head = tail = current = node;
                size = 1;
                return;
            }

            if (current != tail)
            {
                current.next = null;
                tail = current;
            }

            tail.next = node;
            node.prev = tail;
            tail = node;
            current = node;
            size++;

            if (size > maxSize)
            {
                head = head.next;
                head.prev = null;
                size--;
            }
        }

        public void Undo()
        {
            if (current != null && current.prev != null)
            {
                current = current.prev;
            }
        }

        public void Redo()
        {
            if (current != null && current.next != null)
            {
                current = current.next;
            }
        }

        public void DisplayCurrentState()
        {
            if (current == null)
            {
                Console.WriteLine("No Content");
                return;
            }

            Console.WriteLine(current);
        }
    }
}
