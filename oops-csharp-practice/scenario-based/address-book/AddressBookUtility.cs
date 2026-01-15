using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.UCScenarioBased.AddressBook
{
    internal class AddressBookUtility : IAddress
    {
        private int AddressBookCapacity = 10;

        private int count = 0;
        private AddressBook[] AddressBooks;


        public AddressBookUtility()
        {

            AddressBooks = new AddressBook[AddressBookCapacity];
        }

        public void CreateAddressBook()
        {
            AddressBook addressBook = new AddressBook();
            Console.Write("Enter a Book Address Name: ");
            string addressBookName = Console.ReadLine();
            addressBook.Name = addressBookName;
            addressBook.Contacts = new ContactsInfo[10];
            addressBook.Count = 0;

            AddressBooks[count] = addressBook;

            ContactUtilityImpl contactUtility = new ContactUtilityImpl();
            contactUtility.SetAddressBook(addressBook);

            count++;
        }


        public AddressBook SelectAddressBook()
        {
            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (AddressBooks[i].Name.Equals(name))
                {
                    return AddressBooks[i];
                }
            }

            Console.WriteLine("Address Book not found");
            return null;
        }


        public void DisplayAddressBooks()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. {AddressBooks[i].Name}");
            }
        }

        public void DisplayAllContacts()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\n{i + 1}. Address Book: {AddressBooks[i].Name}");
                Console.WriteLine("-----------------------");

                for (int j = 0; j < AddressBooks[i].Count; j++)
                {
                    Console.WriteLine(AddressBooks[i].Contacts[j].ToString());
                }
            }
        }

    }
}

