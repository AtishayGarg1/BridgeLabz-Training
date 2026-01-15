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

        public void AddressMenu()
        {
            while (true)
            {
                Console.WriteLine("\nWelcome to Address Book Menu");
                Console.WriteLine("1. Add Address Book");
                Console.WriteLine("2. Display Address Books");
                Console.WriteLine("3. Display All Contacts");
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
                    case 9:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

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
