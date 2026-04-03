using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_scenariobased.fitness_app
{
    internal interface IUser
    {
        void AddUser();
        void AddSteps();
        void UpdateRanking();
        void DisplayResult();
    }
}
