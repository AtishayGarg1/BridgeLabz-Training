using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.DSA_FOLDER.scenariobased.parcelTracker
{
    internal class ParcelTrackerUtilityImpl : ITrackable
    {
        private Node Head;
        private Node Curr;

        public ParcelTrackerUtilityImpl()
        {
            Head = null;
            Curr = null;
        }

        public void AddStage(string stageName)
        {
            Node newNode = new Node(stageName);
            if(Head == null)
            {
                Head = newNode;
                Curr = newNode;
                return;
            }

            Node temp = Head;

            while(temp.Next1 != null)
            {
                temp = temp.Next1;
            }

            temp.Next1 = newNode;
        }

        public void InsertCheckPoint(string prevStage, string nextStage)
        {
            Node temp = Head;
            while(temp.Next1 != null && temp.Next1.Data1.Equals(prevStage))
            {
                temp = temp.Next1;
            }
            Node newNode = new Node(nextStage);
            newNode.Next1 = temp.Next1;
            temp.Next1 = newNode;
        }

        public void TrackForward()
        {
            if(Curr != null && Curr.Next1 != null)
            {
                Curr = Curr.Next1;
            }
        }

        public void MarkLost(string stageName)
        {
            Node temp = Head;
            while(temp != null)
            {
                if(temp.Data1.Equals(stageName))
                {
                    Console.WriteLine("Parcel Lost At Stage: "+stageName);
                    return;
                }
                temp = temp.Next1;
            }
        }

        public string GetCurrentStage()
        {
            if(Curr != null)
            {
                return Curr.Data1;
            }
            return "Stage Is Null";
        }

        public void DisplayChain()
        {
            Node temp = Head;
            while(temp != null)
            {
                Console.Write(temp.ToString());
                temp = temp.Next1;
            }
            Console.Write("null");
            Console.WriteLine();
        }

    }
}
