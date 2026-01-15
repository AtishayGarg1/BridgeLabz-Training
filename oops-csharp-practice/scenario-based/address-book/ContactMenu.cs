using System;

namespace BridgeLabzTraining.UCScenarioBased.AddressBook
{
    // Menu class to show to user
    internal class ContactMenu
    {
        private IContactable ContactObj;
        private IAddress AddressObj;

        public ContactMenu()
        {
            AddressObj = new AddressBookUtility();
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nWelcome to Address Book System");
                Console.WriteLine("1. Address Book Menu");
                Console.WriteLine("2. Contact Menu");
                Console.WriteLine("3. Exit");

                int choice;
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        AddressMenu();
                        break;
                    case 2:
                        ConMenu();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        // Address Book Menu
        public void AddressMenu()
        {
            while (true)
            {
                Console.WriteLine("\nWelcome to Address Book Menu");
                Console.WriteLine("1. Add Address Book");
                Console.WriteLine("2. Display Address Books");
                Console.WriteLine("3. Display All Contacts");
                Console.WriteLine("4. Search Contacts By City Or State Name");
                Console.WriteLine("5. View Persons By City");
                Console.WriteLine("6. View Persons By State");
                Console.WriteLine("7. Count Persons By City");
                Console.WriteLine("8. Count Persons By State");
                Console.WriteLine("9. Exit");

                int choice;
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        AddressObj.CreateAddressBook();
                        break;
                    case 2:
                        AddressObj.DisplayAddressBooks();
                        break;
                    case 3:
                        AddressObj.DisplayAllContacts();
                        break;
                    case 4:
                        AddressObj.SearchByStateOrCity();
                        break;
                    case 5:
                        AddressObj.ViewPersonsByCity();
                        break;
                    case 6:
                        AddressObj.ViewPersonsByState();
                        break;
                    case 7:
                        AddressObj.CountPersonsByCity();
                        break;
                    case 8:
                        AddressObj.CountPersonsByState();
                        break;
                    case 9:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

        // Contact Menu
        public void ConMenu()
        {

            AddressObj.DisplayAddressBooks();

            AddressBook selectedBook = AddressObj.SelectAddressBook();

            if (selectedBook == null)
            {
                Console.WriteLine("No AddressBook selected");
                return;
            }


            ContactUtilityImpl contactUtility = new ContactUtilityImpl();
            contactUtility.SetAddressBook(selectedBook);
            ContactObj = contactUtility;

            while (true)
            {
                Console.WriteLine("\nWelcome to Contact Menu");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact Using Name");
                Console.WriteLine("3. Delete A Contact");
                Console.WriteLine("4. Sort Contacts Alphabetically");
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
                    case 4:
                        ContactObj.SortAlphabetically();
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
