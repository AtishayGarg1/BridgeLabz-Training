using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.SmartHomeAutomationSystem
{
    // Light Appliance
    internal class LightUtilityImpl : Appliance, IControllable
    {
        public LightUtilityImpl()
        {
            ApplianceName1 = "Light";
            ApplianceState1 = "Off";
        }

        public void TurnOn()
        {
            ApplianceState1 = "On";
            Console.WriteLine(ToString());
        }

        public void TurnOff()
        {
            ApplianceState1 = "Off";
            Console.WriteLine(ToString());
        }

        public void Toggle()
        {
            if (ApplianceState1.Equals("Off"))
                TurnOn();
            else
                TurnOff();
        }
    }
}
