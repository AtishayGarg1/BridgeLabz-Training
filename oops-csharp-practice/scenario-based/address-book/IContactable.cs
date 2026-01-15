using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.UCScenarioBased.AddressBook
{
    // Interface to Provide Abstraction

    internal interface IContactable
    {
        void AddContact();
        void EditDetails(string name);
        void DeleteContact(string name);
        void DisplayDetails();
        bool AlreadyExists(string firstName, string lastName);
        void SearchByStateOrCity();
        void SortAlphabetically();
    }
}
