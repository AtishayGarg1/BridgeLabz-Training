using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.DSA_FOLDER.scenariobased.aadharcard
{
    // Class to Store Aadhar Records
    internal class AadharCard
    {
        private string AadharNumber;

        public AadharCard(string aadharNumber)
        {
            AadharNumber = aadharNumber;
        }

        public string AadharNumber1 { get => AadharNumber; }

        public override string? ToString()
        {
            return $"\nAadhar Number: {AadharNumber}";
        }
    }
}
