using BridgeLabzTraining.scenariobased.fitnesstracker;
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
        private IContactable ContactObj;
        public void Menu()
        {
            ContactObj = new ContactUtiityImpl();
            while (true)
            {
                Console.WriteLine("Welcome to Address Book");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact Using Name");
                Console.WriteLine("3. Delete A Contact");
                Console.WriteLine("8. Display All Contacts");
                Console.WriteLine("9. Exit");
                int choice;
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        ContactObj.AddContact();
                        break;
                    case 2:
                        Console.WriteLine("Enter Name To Edit Contact");
                        string nameEdit = Console.ReadLine();
                        ContactObj.EditDetails(nameEdit);
                        break;
                    case 3:
                        Console.WriteLine("Enter Name to Delete Contact");
                        string nameDelete = Console.ReadLine();
                        ContactObj.DeleteContact(nameDelete);
                        break;
                    case 8:
                        ContactObj.DisplayDetails();
                        break;
                    case 9:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
