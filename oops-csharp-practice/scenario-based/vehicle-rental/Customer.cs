using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.VehicleTrntai
{
    internal class Customer
    {
        private string name;
        private string liscenceNumber;

        public Customer(string name, string liscenceNumber)
        {
            this.name = name;
            this.liscenceNumber = liscenceNumber;
        }

        public string GetCustomerInfo()
        {
            return "Name: " + name + "Liscence Number: " + liscenceNumber;
        }
    }
}
