using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.SmartHomeAutomationSystem
{
    internal class ACUtilityImpl : Appliance, IControllable
    {
        public ACUtilityImpl()
        {
            ApplianceName1 = "AC";
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
            if (ApplianceState1.ToLower().Equals("off"))
                TurnOn();
            else
                TurnOff();
        }
    }
}
