using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.LibraryManagementSystem
{
    internal interface IReservable
    {
        void ReserveItem(string borrowerName);
        bool CheckAvailability();
    }
}
