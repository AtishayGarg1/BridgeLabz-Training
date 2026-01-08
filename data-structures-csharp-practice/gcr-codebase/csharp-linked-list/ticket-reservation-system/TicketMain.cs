using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.ticketreservationsystem
{
    internal class TicketMain
    {
        static void Main(string[] args)
        {
            TicketReservationManager manager = new TicketReservationManager();

            manager.AddTicket(1, "Atishay", "Inception", "A1", DateTime.Now);
            manager.AddTicket(2, "Aman", "Inception", "A2", DateTime.Now);
            manager.AddTicket(3, "Akshat", "Interstellar", "B1", DateTime.Now);
            manager.AddTicket(4, "Amrit", "Avatar", "C3", DateTime.Now);

            manager.DisplayAllTickets();

            manager.SearchByCustomerName("Aman");
            manager.SearchByMovieName("Inception");

            Console.WriteLine("Total Tickets: " + manager.CountTotalTickets());

            manager.RemoveTicketById(2);
            manager.DisplayAllTickets();

            Console.WriteLine("Total Tickets: " + manager.CountTotalTickets());
        }
    }
}
