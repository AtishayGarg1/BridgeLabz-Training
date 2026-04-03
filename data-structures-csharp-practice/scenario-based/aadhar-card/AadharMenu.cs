using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.DSA_FOLDER.scenariobased.aadharcard
{
    // Menu Class to Display User
    internal class AadharMenu
    {
        private IAadhar MenuAadhar;
        public AadharMenu()
        {
            MenuAadhar = new AadharCardUtilityImpl();
        }
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("1. Add Aadhar Number");
                Console.WriteLine("2. Sort Aadhar Records");
                Console.WriteLine("3. Search Aadhar Number");
                Console.WriteLine("3. Display All Aadhar Number");
                Console.WriteLine("5. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        MenuAadhar.AddAadhar();
                        break;
                    case 2:
                        MenuAadhar.SortAadhar();
                        break;
                    case 3:
                        MenuAadhar.SearchAadhar();
                        break;
                    case 4:
                        MenuAadhar.DisplayAllAadhar();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
