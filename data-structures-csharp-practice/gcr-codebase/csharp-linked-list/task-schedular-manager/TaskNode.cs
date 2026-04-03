using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.taskschedularmanager
{
    internal class TaskNode
    {
        public int TaskId;
        public string TaskName;
        public int Priority;
        public DateTime DueDate;

        public TaskNode next;

        public TaskNode(int taskId, string taskName, int priority, DateTime dueDate)
        {
            TaskId = taskId;
            TaskName = taskName;
            Priority = priority;
            DueDate = dueDate;
            next = null;
        }

        public override string ToString()
        {
            return $"Task ID: {TaskId}\nTask Name: {TaskName}\nPriority: {Priority}\nDue Date: {DueDate.ToShortDateString()}";
        }
    }
}
