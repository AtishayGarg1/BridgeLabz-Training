using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BridgeLabzTraining.SmartHomeAutomationSystem
{
    // Menu Class
    sealed class SmartHomeMenu
    {
        public void Menu()
        {
            SmartHomeController controller = new SmartHomeController();

            while (true)
            {
                Console.WriteLine("\n\tSmart Home Automation ");
                Console.WriteLine("1. Add Light");
                Console.WriteLine("2. Add Fan");
                Console.WriteLine("3. Add AC");
                Console.WriteLine("4. Toggle Appliance");
                Console.WriteLine("5. Display All Appliances");
                Console.WriteLine("6. Exit");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        controller.AddLight();
                        break;
                    case 2:
                        controller.AddFan();
                        break;
                    case 3:
                        controller.AddAC();
                        break;
                    case 4:
                        controller.ToggleAppliance();
                        break;
                    case 5:
                        controller.DisplayAll();
                        break;
                    case 6:
                        Console.WriteLine("Exiting Smart Home Automation System");
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
