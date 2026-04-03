using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.bird_sanctuary
{
    internal class Duck : BirdBase, ISwimmable
    {
        public Duck(int lifespan) : base("Duck", lifespan) { }

        public void Swim()
        {
            Console.WriteLine("Duck is swimming on the water.");
        }
    }
}
