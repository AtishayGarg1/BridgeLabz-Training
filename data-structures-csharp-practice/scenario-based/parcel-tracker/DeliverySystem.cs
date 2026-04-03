using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.DSA_FOLDER.scenariobased.parcelTracker
{
    internal class DeliverySystem
    {
        private ParcelNode Head;

        public DeliverySystem()
        {
            Head = null;
        }

        public void AddParcel(string parcelId, ParcelTrackerUtilityImpl tracker)
        {
            ParcelNode newNode = new ParcelNode(parcelId, tracker);

            if (Head == null)
            {
                Head = newNode;
                return;
            }
            ParcelNode temp = Head;
            while (temp.Next1 != null)
            {
                temp = temp.Next1;
            }
            temp.Next1 = newNode;
        }
        public ParcelTrackerUtilityImpl GetParcel(string parcelId)
        {
            ParcelNode temp = Head;

            while (temp != null)
            {
                if (temp.ParcelId1 == parcelId)
                {
                    return temp.Tracker1;
                }
                temp = temp.Next1;
            }

            return null;
        }

        public void TrackParcel(string parcelId)
        {
            ParcelTrackerUtilityImpl tracker = GetParcel(parcelId);

            if (tracker == null)
            {
                Console.WriteLine("Parcel not found.");
                return;
            }

            tracker.TrackForward();
            Console.WriteLine("Current Stage: " + tracker.GetCurrentStage());
        }

        public void MarkParcelLost(string parcelId)
        {
            ParcelTrackerUtilityImpl tracker = GetParcel(parcelId);

            if (tracker == null)
            {
                Console.WriteLine("Parcel not found.");
                return;
            }

            tracker.MarkLost(tracker.GetCurrentStage());
        }

        public void DisplayAllParcels()
        {
            ParcelNode temp = Head;

            if (temp == null)
            {
                Console.WriteLine("No parcels in system.");
                return;
            }

            while (temp != null)
            {
                Console.WriteLine($"Parcel ID: {temp.ParcelId1}, Stage: {temp.Tracker1.GetCurrentStage()}");
                temp = temp.Next1;
            }
        }
    }
}
