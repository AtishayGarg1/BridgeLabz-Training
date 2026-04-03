using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.VehicleTrntai
{
    internal interface IRentable
    {
        double CalculateRent(int days);
        string GetDetails();
    }
}
