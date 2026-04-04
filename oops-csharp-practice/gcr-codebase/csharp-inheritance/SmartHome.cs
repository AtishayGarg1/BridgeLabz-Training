using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgeLabzTraining.inheritance
{
    //Base class SmartHome
    internal class SmartHome
    {
        public int SmartHomeId;
        public string Status;

        public SmartHome(int id, string status)
        {
            SmartHomeId = id;
            Status = status;
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine("SmartHome ID: " + SmartHomeId);
            Console.WriteLine("Status   : " + Status);
        }
    }

    //Subclass Thermostat
    class Thermostat : SmartHome
    {
        public int TemperatureSetting;

        public Thermostat(int id, string status, int temp) : base(id, status)
        {
            TemperatureSetting = temp;
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine("Temperature: " + TemperatureSetting);
        }
    }

    class Program
    {
        static void Main()
        {
            Thermostat t1 = new Thermostat(1, "ON", 24);
            t1.DisplayStatus();
        }
    }
}
