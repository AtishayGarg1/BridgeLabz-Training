using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.inheritance
{
    // Interface for multiple behavior
    interface Worker
    {
        void PerformDuties();
    }

    // Base class
    class Restraunt
    {
        public string Name;
        public int Id;

        public Restraunt(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }

    // Chef class using inheritance + interface
    class Chef : Restraunt, Worker
    {
        public Chef(string name, int id) : base(name, id) { }

        public void PerformDuties()
        {
            Console.WriteLine("Chef cooks food");
        }
    }

    // Waiter class using inheritance + interface
    class Waiter : Restraunt, Worker
    {
        public Waiter(string name, int id) : base(name, id) { }

        public void PerformDuties()
        {
            Console.WriteLine("Waiter serves food");
        }
    }
}
