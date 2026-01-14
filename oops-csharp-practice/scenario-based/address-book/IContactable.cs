using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.UCScenarioBased.AddressBook
{
    internal interface IContactable
    {
        void AddContact();

        void EditDetails(string name);
    }
}
