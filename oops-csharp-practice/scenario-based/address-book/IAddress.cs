using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.UCScenarioBased.AddressBook
{
    // Interface to Provide Abstraction
    internal interface IAddress
    {
        void CreateAddressBook();
        AddressBook SelectAddressBook();
        void DisplayAddressBooks();
        void DisplayAllContacts();
        void SearchByStateOrCity();
        void ViewPersonsByCity();
        void ViewPersonsByState();


    }
}
