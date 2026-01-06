using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.bird_sanctuary
{
    internal class Sparrow : BirdBase, IFlyable
    {
        public Sparrow(int age) : base("Sparrow", age) { }

        public void Fly()
        {
            Console.WriteLine("   -> "+ speciesName + " the Sparrow is fluttering quickly.");
        }
    }
}
