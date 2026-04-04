using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.bird_sanctuary
{
    internal class Penguin : BirdBase, ISwimmable
    {
        public Penguin(int lifespan) : base("Penguin", lifespan) { }

        public void Swim()
        {
            Console.WriteLine("Penguin is swimming underwater.");
        }
    }
}
