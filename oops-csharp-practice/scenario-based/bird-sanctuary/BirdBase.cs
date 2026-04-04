using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.bird_sanctuary
{
    class BirdBase
    {
        protected string speciesName;
        protected int lifespan;

        //Constructor to take name and lifespan of a bird
        protected BirdBase(string speciesName, int lifespan)
        {
            this.speciesName = speciesName;
            this.lifespan = lifespan;
        }

        //Function to show action
        public virtual void Eat()
        {
            Console.WriteLine(speciesName + " is eating food.");
        }
        
        //Function to get details
        public string GetDetails()
        {
            return "Species: " + speciesName +
                   ", Type: " + GetType().Name +
                   ", Lifespan: " + lifespan + " years";
        }
    }
}
