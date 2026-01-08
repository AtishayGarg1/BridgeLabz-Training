using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.SmartHomeAutomationSystem
{
    // Claas to Manage Functions
    internal class SmartHomeController
    {
        private IControllable[] appliances = new IControllable[10];
        private int applianceCount = 0;

        // Function to add Light appliance
        public void AddLight()
        {
            if (applianceCount < appliances.Length)
            {
                appliances[applianceCount++] = new LightUtilityImpl();
                Console.WriteLine("Light added");
            }
            else
            {
                Console.WriteLine("Appliance limit reached");
            }
        }

        // Function to add Fan appliance
        public void AddFan()
        {
            if (applianceCount < appliances.Length)
            {
                appliances[applianceCount++] = new FanUtilityImpl();
                Console.WriteLine("Fan added");
            }
            else
            {
                Console.WriteLine("Appliance limit reached");
            }
        }

        // Function to add AC appliance
        public void AddAC()
        {
            if (applianceCount < appliances.Length)
            {
                appliances[applianceCount++] = new ACUtilityImpl();
                Console.WriteLine("AC added");
            }
            else
            {
                Console.WriteLine("Appliance limit reached");
            }
        }

        // Function to Toggle Appliance
        public void ToggleAppliance()
        {
            if (applianceCount == 0)
            {
                Console.WriteLine("No appliances available");
                return;
            }

            Console.WriteLine("Select appliance number:");
            for (int i = 0; i < applianceCount; i++)
            {
                Console.WriteLine($"{i + 1}. {appliances[i]}");
            }

            if (int.TryParse(Console.ReadLine(), out int index) &&
                index >= 1 && index <= applianceCount)
            {
                appliances[index - 1].Toggle();
            }
            else
            {
                Console.WriteLine("Invalid selection");
            }
        }

        //Function to Display All Appliances
        public void DisplayAll()
        {
            if (applianceCount == 0)
            {
                Console.WriteLine("No appliances added");
                return;
            }

            for (int i = 0; i < applianceCount; i++)
            {
                Console.WriteLine($"{i + 1}. {appliances[i]}");
            }
        }
    }
}
