using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.fitnesstracker
{
    // Interface To Declare Methods
    internal interface ITrackable
    {
        void AddUserProfile();
        void DisplayUserList();
        void DisplayUserDetails();
        void StartWorkout();
    }
}
