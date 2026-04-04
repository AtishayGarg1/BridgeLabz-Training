using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_scenariobased.fitness_app
{
    internal class User
    {
        private string UserName;
        private int UserSteps;

        public int UserSteps1 { get => UserSteps; set => UserSteps = value; }
        public string UserName1 { get => UserName; set => UserName = value; }

        public override string? ToString()
        {
            return $"{UserName}\nSteps: {UserSteps}\n";
        }
    }
}
