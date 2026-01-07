using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.LibraryManagementSystem
{
    internal class Magazine : LibraryItem, IReservable
    {
        public override int GetLoanDuration()
        {
            return 7; // 7 days
        }

        public void ReserveItem(string borrowerName)
        {
            if (!IsBorrowed())
            {
                SetBorrower(borrowerName);
                Console.WriteLine("Magazine reserved successfully.");
            }
        }

        public bool CheckAvailability()
        {
            return !IsBorrowed();
        }
    }
}
