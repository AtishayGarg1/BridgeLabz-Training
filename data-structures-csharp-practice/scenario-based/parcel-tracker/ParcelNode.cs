using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.DSA_FOLDER.scenariobased.parcelTracker
{
    internal class ParcelNode
    {
        private string ParcelId;
        private ParcelTrackerUtilityImpl Tracker;
        private ParcelNode Next;

        public ParcelNode(string parcelId, ParcelTrackerUtilityImpl tracker)
        {
            ParcelId = parcelId;
            Tracker = tracker;
            Next = null;
        }

        public string ParcelId1 { get => ParcelId;}
        internal ParcelNode Next1 { get => Next; set => Next = value; }
        internal ParcelTrackerUtilityImpl Tracker1 { get => Tracker; set => Tracker = value; }
    }
}
