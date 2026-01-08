using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.SmartHomeAutomationSystem
{
    internal class Appliance
    {
        private string ApplianceName;
        private string ApplianceState = "Off";
        private static Appliance[] ElectricalAppliance = new Appliance[100];
        private int ApplianceCount;


        public string ApplianceName1 { get => ApplianceName; set => ApplianceName = value; }
        public string ApplianceState1 { get => ApplianceState; set => ApplianceState = value; }
        public int ApplianceCount1 { get => ApplianceCount; set => ApplianceCount = value; }
        internal static Appliance[] ElectricalAppliance1 { get => ElectricalAppliance; set => ElectricalAppliance = value; }

        public override string? ToString()
        {
            return ApplianceName + " is switched " + ApplianceState;
        }
    }
}
