using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.ticketreservationsystem
{
    internal class TicketReservationManager
    {
        private TicketNode head;

        public TicketReservationManager()
        {
            head = null;
        }

        public void AddTicket(int ticketId, string customerName, string movieName, string seatNumber, DateTime bookingTime)
        {
            TicketNode node = new TicketNode(ticketId, customerName, movieName, seatNumber, bookingTime);

            if (head == null)
            {
                head = node;
                node.next = head;
                return;
            }

            TicketNode temp = head;
            while (temp.next != head)
            {
                temp = temp.next;
            }

            temp.next = node;
            node.next = head;
        }

        public void RemoveTicketById(int ticketId)
        {
            if (head == null)
                return;

            TicketNode temp = head;
            TicketNode prev = null;

            do
            {
                if (temp.TicketId == ticketId)
                {
                    if (temp == head)
                    {
                        if (head.next == head)
                        {
                            head = null;
                            return;
                        }

                        TicketNode last = head;
                        while (last.next != head)
                        {
                            last = last.next;
                        }

                        head = head.next;
                        last.next = head;
                    }
                    else
                    {
                        prev.next = temp.next;
                    }
                    return;
                }

                prev = temp;
                temp = temp.next;

            } while (temp != head);
        }

        public void DisplayAllTickets()
        {
            if (head == null)
                return;

            TicketNode temp = head;
            do
            {
                Console.WriteLine(temp);
                temp = temp.next;
            } while (temp != head);
        }

        public void SearchByCustomerName(string customerName)
        {
            if (head == null)
                return;

            TicketNode temp = head;
            do
            {
                if (temp.CustomerName.Equals(customerName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(temp);
                }
                temp = temp.next;
            } while (temp != head);
        }

        public void SearchByMovieName(string movieName)
        {
            if (head == null)
                return;

            TicketNode temp = head;
            do
            {
                if (temp.MovieName.Equals(movieName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(temp);
                }
                temp = temp.next;
            } while (temp != head);
        }

        public int CountTotalTickets()
        {
            if (head == null)
                return 0;

            int count = 0;
            TicketNode temp = head;

            do
            {
                count++;
                temp = temp.next;
            } while (temp != head);

            return count;
        }
    }
}
