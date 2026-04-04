using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.ticketreservationsystem
{
    internal class TicketNode
    {
        public int TicketId;
        public string CustomerName;
        public string MovieName;
        public string SeatNumber;
        public DateTime BookingTime;

        public TicketNode next;

        public TicketNode(int ticketId, string customerName, string movieName, string seatNumber, DateTime bookingTime)
        {
            TicketId = ticketId;
            CustomerName = customerName;
            MovieName = movieName;
            SeatNumber = seatNumber;
            BookingTime = bookingTime;
            next = null;
        }

        public override string ToString()
        {
            return $"Ticket ID: {TicketId}\nCustomer: {CustomerName}\nMovie: {MovieName}\nSeat: {SeatNumber}\nBooking Time: {BookingTime}";
        }
    }
}
