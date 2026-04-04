using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.bird_sanctuary
{
    internal class Eagle : BirdBase, IFlyable
    {
        public Eagle(int lifespan) : base("Eagle", lifespan) { }

        public void Fly()
        {
            Console.WriteLine("Eagle is flying high in the sky.");
        }
    }
}
