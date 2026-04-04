using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.DSA_FOLDER.scenariobased.parcelTracker
{
    internal class Node
    {
        private string Data;
        private Node Next;

        public Node(string data)
        {
            Data1 = data;
            Next1 = null;
        }

        public string Data1 { get => Data; }
        internal Node Next1 { get => Next; set => Next = value; }

        public override string? ToString()
        {
            return $"Stage: {Data} -> ";
        }
    }
}
