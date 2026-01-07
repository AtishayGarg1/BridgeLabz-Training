using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.LibraryManagementSystem
{
    internal class DVD : LibraryItem, IReservable
    {
        public override int GetLoanDuration()
        {
            return 3; // 3 days
        }

        public void ReserveItem(string borrowerName)
        {
            if (!IsBorrowed())
            {
                SetBorrower(borrowerName);
                Console.WriteLine("DVD reserved successfully.");
            }
        }

        public bool CheckAvailability()
        {
            return !IsBorrowed();
        }
    }
}
