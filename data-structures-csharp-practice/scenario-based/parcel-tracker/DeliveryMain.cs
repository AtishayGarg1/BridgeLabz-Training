using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.DSA_FOLDER.scenariobased.parcelTracker
{
    internal class DeliveryMain
    {
        static void Main(string[] args)
        {
            ParcelTrackerUtilityImpl tracker1 = new ParcelTrackerUtilityImpl();
            tracker1.AddStage("Warehouse");
            tracker1.AddStage("Hub");
            tracker1.AddStage("Out for Delivery");

            ParcelTrackerUtilityImpl tracker2 = new ParcelTrackerUtilityImpl();
            tracker2.AddStage("Warehouse");
            tracker2.AddStage("Airport");
            tracker2.AddStage("Destination City");

            DeliverySystem system = new DeliverySystem();
            system.AddParcel("P1001", tracker1);
            system.AddParcel("P1002", tracker2);

            system.TrackParcel("P1001");
            system.TrackParcel("P1001");

            system.TrackParcel("P1002");

            system.DisplayAllParcels();
        }
    }
}
