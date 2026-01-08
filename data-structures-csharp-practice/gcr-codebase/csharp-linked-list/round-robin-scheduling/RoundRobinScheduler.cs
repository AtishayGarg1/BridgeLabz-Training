using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.roundrobinscheduling
{
    internal class RoundRobinScheduler
    {
        private ProcessNode head;

        public RoundRobinScheduler()
        {
            head = null;
        }

        public void AddProcess(int processId, int burstTime, int priority)
        {
            ProcessNode node = new ProcessNode(processId, burstTime, priority);

            if (head == null)
            {
                head = node;
                node.next = head;
                return;
            }

            ProcessNode temp = head;
            while (temp.next != head)
            {
                temp = temp.next;
            }

            temp.next = node;
            node.next = head;
        }

        public void RemoveProcess(int processId)
        {
            if (head == null)
                return;

            ProcessNode temp = head;
            ProcessNode prev = null;

            do
            {
                if (temp.ProcessId == processId)
                {
                    if (temp == head)
                    {
                        if (head.next == head)
                        {
                            head = null;
                            return;
                        }

                        ProcessNode last = head;
                        while (last.next != head)
                        {
                            last = last.next;
                        }

                        head = head.next;
                        last.next = head;
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

        public void SimulateScheduling(int timeQuantum)
        {
            if (head == null)
                return;

            int currentTime = 0;
            ProcessNode temp = head;

            while (head != null)
            {
                if (temp.RemainingTime > 0)
                {
                    int executedTime = Math.Min(timeQuantum, temp.RemainingTime);
                    temp.RemainingTime -= executedTime;
                    currentTime += executedTime;

                    ProcessNode t = head;
                    do
                    {
                        if (t != temp && t.RemainingTime > 0)
                        {
                            t.WaitingTime += executedTime;
                        }
                        t = t.next;
                    } while (t != head);

                    if (temp.RemainingTime == 0)
                    {
                        temp.TurnAroundTime = currentTime;
                        int completedPid = temp.ProcessId;
                        temp = temp.next;
                        RemoveProcess(completedPid);
                        DisplayProcesses();
                        continue;
                    }
                }

                temp = temp.next;
                DisplayProcesses();
            }

            DisplayAverageTimes();
        }

        public void DisplayProcesses()
        {
            if (head == null)
            {
                Console.WriteLine("Queue Empty");
                return;
            }

            ProcessNode temp = head;
            do
            {
                Console.WriteLine(temp);
                temp = temp.next;
            } while (temp != head);

            Console.WriteLine();
        }

        private void DisplayAverageTimes()
        {
            double totalWaiting = 0;
            double totalTurnaround = 0;
            int count = 0;

            ProcessNode temp = head;
            if (temp == null)
                return;

            do
            {
                totalWaiting += temp.WaitingTime;
                totalTurnaround += temp.TurnAroundTime;
                count++;
                temp = temp.next;
            } while (temp != head);

            Console.WriteLine("Average Waiting Time: " + (totalWaiting / count));
            Console.WriteLine("Average Turnaround Time: " + (totalTurnaround / count));
        }
    }
}
