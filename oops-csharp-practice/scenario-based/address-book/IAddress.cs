using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.UCScenarioBased.AddressBook
{
    internal interface IAddress
    {
        void CreateAddressBook();
        AddressBook SelectAddressBook();
        void DisplayAddressBooks();
        void DisplayAllContacts();
    }
}
