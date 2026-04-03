using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.roundrobinscheduling
{
    nternal class ProcessNode
    {
        public int ProcessId;
        public int BurstTime;
        public int RemainingTime;
        public int Priority;

        public int WaitingTime;
        public int TurnAroundTime;

        public ProcessNode next;

        public ProcessNode(int processId, int burstTime, int priority)
        {
            ProcessId = processId;
            BurstTime = burstTime;
            RemainingTime = burstTime;
            Priority = priority;
            WaitingTime = 0;
            TurnAroundTime = 0;
            next = null;
        }

        public override string ToString()
        {
            return $"PID: {ProcessId}, Remaining Time: {RemainingTime}, Priority: {Priority}";
        }
    }
}
