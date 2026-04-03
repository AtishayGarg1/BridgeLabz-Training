using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.VehicleTrntai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleControler vehicleControler = new VehicleControler(10);
            vehicleControler.Run();
        }
    }
}
