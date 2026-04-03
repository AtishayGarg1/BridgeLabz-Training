using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.SmartHomeAutomationSystem
{
    internal class Program
    {
        // Function to Run Program
        static void Main(string[] args)
        {
            SmartHomeMenu smartHome = new SmartHomeMenu();
            smartHome.Menu();
        }
    }
}
