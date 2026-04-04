using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.roundrobinscheduling
{
    internal class RoundRobinMain
    {
        static void Main(string[] args)
        {
            RoundRobinScheduler scheduler = new RoundRobinScheduler();

            scheduler.AddProcess(1, 10, 1);
            scheduler.AddProcess(2, 5, 2);
            scheduler.AddProcess(3, 8, 1);
            scheduler.AddProcess(4, 6, 3);

            scheduler.SimulateScheduling(3);
        }
    }
}
