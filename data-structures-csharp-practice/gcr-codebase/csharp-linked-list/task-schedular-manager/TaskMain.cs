using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.taskschedularmanager
{
    internal class TaskMain
    {
        static void Main(string[] args)
        {
            TaskScheduler taskScheduler = new TaskScheduler();

            taskScheduler.AddAtEnd(1, "Design Module", 1, new DateTime(2026, 1, 15));
            taskScheduler.AddAtEnd(2, "Implement Logic", 2, new DateTime(2026, 1, 20));
            taskScheduler.AddAtEnd(3, "Testing", 3, new DateTime(2026, 1, 25));

            taskScheduler.DisplayAllTasks();

            taskScheduler.AddAtPosition(4, "Code Review", 2, new DateTime(2026, 1, 18), 2);
            taskScheduler.DisplayAllTasks();

            taskScheduler.ViewCurrentAndMoveNext();
            taskScheduler.ViewCurrentAndMoveNext();

            taskScheduler.SearchByPriority(2);

            taskScheduler.RemoveByTaskId(1);
            taskScheduler.DisplayAllTasks();
        }
    }
}
