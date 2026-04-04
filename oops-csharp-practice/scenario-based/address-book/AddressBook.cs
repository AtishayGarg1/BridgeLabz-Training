using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.UCScenarioBased.AddressBook
{
    internal class AddressBook
    {
        private string name;
        private int count;
        private ContactsInfo[] contacts;

        

        public string Name { get => name; set => name = value; }
        public int Count { get => count; set => count = value; }
        internal ContactsInfo[] Contacts { get => contacts; set => contacts = value; }
    }
}
