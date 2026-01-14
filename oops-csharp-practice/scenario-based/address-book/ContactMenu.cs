using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.UCScenarioBased.AddressBook
{
    // Menu class to show to user
    internal class ContactMenu
    {
        IContactable ContactObj = new ContactUtiityImpl();
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("Welcome to Address Book");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("9. Exit");
                int choice;
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        ContactObj.AddContact();
                        break;
                    case 9:
                        return;
                }
            }
        }
    }
}
