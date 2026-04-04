using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.LibraryManagementSystem
{
    internal class LibraryService
    {
        public static void ProcessItems(LibraryItem[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                LibraryItem item = items[i];

                item.GetItemDetails();
                Console.WriteLine($"Loan Duration: {item.GetLoanDuration()} days");

                if (item is IReservable reservable)
                {
                    Console.WriteLine($"Available: {reservable.CheckAvailability()}");
                }

                Console.WriteLine("--------------------------------");
            }
        }
    }
}
