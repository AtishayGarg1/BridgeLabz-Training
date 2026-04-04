using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.RideHailingApplication
{
    internal interface IGPS
    {
        void UpdateLocation(string location);
        string GetCurrentLocation();
    }
}
