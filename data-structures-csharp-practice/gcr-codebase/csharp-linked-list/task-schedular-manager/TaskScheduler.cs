using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.taskschedularmanager
{
    internal class TaskScheduler
    {
        private TaskNode head;
        private TaskNode current;

        public TaskScheduler()
        {
            head = null;
            current = null;
        }

        public void AddAtBeginning(int taskId, string taskName, int priority, DateTime dueDate)
        {
            TaskNode node = new TaskNode(taskId, taskName, priority, dueDate);

            if (head == null)
            {
                head = node;
                node.next = head;
                current = head;
                return;
            }

            TaskNode temp = head;
            while (temp.next != head)
            {
                temp = temp.next;
            }

            node.next = head;
            temp.next = node;
            head = node;
        }

        public void AddAtEnd(int taskId, string taskName, int priority, DateTime dueDate)
        {
            TaskNode node = new TaskNode(taskId, taskName, priority, dueDate);

            if (head == null)
            {
                head = node;
                node.next = head;
                current = head;
                return;
            }

            TaskNode temp = head;
            while (temp.next != head)
            {
                temp = temp.next;
            }

            temp.next = node;
            node.next = head;
        }

        public void AddAtPosition(int taskId, string taskName, int priority, DateTime dueDate, int position)
        {
            if (position <= 1)
            {
                AddAtBeginning(taskId, taskName, priority, dueDate);
                return;
            }

            TaskNode node = new TaskNode(taskId, taskName, priority, dueDate);
            TaskNode temp = head;
            int count = 1;

            while (temp.next != head && count < position - 1)
            {
                temp = temp.next;
                count++;
            }

            node.next = temp.next;
            temp.next = node;
        }

        public void RemoveByTaskId(int taskId)
        {
            if (head == null)
                return;

            TaskNode temp = head;
            TaskNode prev = null;

            do
            {
                if (temp.TaskId == taskId)
                {
                    if (temp == head)
                    {
                        if (head.next == head)
                        {
                            head = null;
                            current = null;
                            return;
                        }

                        TaskNode last = head;
                        while (last.next != head)
                        {
                            last = last.next;
                        }

                        head = head.next;
                        last.next = head;
                        current = head;
                    }
                    else
                    {
                        prev.next = temp.next;
                    }
                    return;
                }

                prev = temp;
                temp = temp.next;

            } while (temp != head);
        }

        public void ViewCurrentAndMoveNext()
        {
            if (current == null)
                return;

            Console.WriteLine(current);
            current = current.next;
        }

        public void DisplayAllTasks()
        {
            if (head == null)
                return;

            TaskNode temp = head;
            do
            {
                Console.WriteLine(temp);
                temp = temp.next;
            } while (temp != head);
        }

        public void SearchByPriority(int priority)
        {
            if (head == null)
                return;

            TaskNode temp = head;
            do
            {
                if (temp.Priority == priority)
                {
                    Console.WriteLine(temp);
                }
                temp = temp.next;
            } while (temp != head);
        }
    }
}
