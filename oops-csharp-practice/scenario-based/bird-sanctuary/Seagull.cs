using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.bird_sanctuary
{
    internal class Seagull : BirdBase, IFlyable, ISwimmable
    {
        public Seagull(int age) : base("Seagull", age) { }

        public void Fly()
        {
            Console.WriteLine("   -> "+speciesName+" the Seagull is gliding over the ocean.");
        }

        public void Swim()
        {
            Console.WriteLine("   -> "+ speciesName + " the Seagull is floating on the waves.");
        }
    }
}
