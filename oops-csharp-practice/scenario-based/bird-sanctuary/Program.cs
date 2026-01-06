using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.bird_sanctuary
{
    internal class Program
    {
        static void Main()
        {
            SanctuaryController controller = new SanctuaryController(10);
            controller.Run();
        }
    }
}
