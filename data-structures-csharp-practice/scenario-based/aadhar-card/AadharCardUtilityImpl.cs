using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.DSA_FOLDER.scenariobased.aadharcard
{
    internal class AadharCardUtilityImpl : IAadhar
    {
        private AadharCard[] AadharCards;
        private int Capacity = 100;
        private int count = 0;
        private bool IsSorted = false;

        // Constructor to Initialize Aadhar Card Array
        public AadharCardUtilityImpl()
        {
            AadharCards = new AadharCard[Capacity];
        }

        // Method to Add Aadhar Number
        public void AddAadhar()
        {
            Console.WriteLine("Enter Aadhar Card Number");
            string aadhar = Console.ReadLine();
            AadharCards[count++] = new AadharCard(aadhar);
        }

        // Method to Sort Aadhar Cards
        public void SortAadhar()
        {
            for(int i = 0; i < count - 1; i++)
            {
                for(int j = i + 1; j < count; j++)
                {
                    // String Comparison To Sort Aadhar Numbers
                    if (AadharCards[j].AadharNumber1.CompareTo(AadharCards[i].AadharNumber1) < 0)
                    {
                        AadharCard temp = AadharCards[i];
                        AadharCards[i] = AadharCards[j];
                        AadharCards[j] = temp;
                        IsSorted = true;
                    }
                }
            }
        }

        // Method to Search Aadhar Card in Records
        public void SearchAadhar()
        {
            if (!IsSorted)
            {
                Console.WriteLine("Aadhar Records Are Not Sorted, to search Sort first");
                return;
            }
            Console.WriteLine("Enter Aadhar Number To search");
            string aadhar = Console.ReadLine();
            int l = 0;
            int r = count - 1;

            // Binary Search To find Aadhar Number
            while(l < r)
            {
                int mid = l + (r - l) / 2;

                string midValue = AadharCards[mid].AadharNumber1;

                int compare = string.Compare(midValue, aadhar);

                if (compare == 0)
                {
                    Console.WriteLine("\nAadhar Found In Records\n");
                    return;
                }
                else if (compare < 0)
                    l = mid + 1;      // search right half
                else
                    r = mid - 1;     // search left half
            }
            Console.WriteLine("\nAadhar Card Not Found\n");
        }

        // Method to Display Aadhar Numbers
        public void DisplayAllAadhar()
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(AadharCards[i].ToString());
            }
        }

    }
}
