using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.fitnesstracker
{
    // Main class to execute Program
    internal class FitnessTrackerMain
    {
        static void Main(string[] args)
        {
            WorkoutMenu workoutMenu = new WorkoutMenu();
            workoutMenu.FitnessTrackerMenu();
        }
    }
}
