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

        // Method to Display Address Books
        public void DisplayAddressBooks()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. {AddressBooks[i].Name}");
            }
        }

        // Method to Display All Contacts
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

        // Method to Search Contacts by City Or State Accross All Address Books
        public void SearchByStateOrCity()
        {
            Console.WriteLine("Enter State Or City");
            string name = Console.ReadLine();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\n{i + 1}. Address Book: {AddressBooks[i].Name}");
                Console.WriteLine("-----------------------");

                for (int j = 0; j < AddressBooks[i].Count; j++)
                {
                    if(AddressBooks[i].Contacts[j].State1.Equals(name) || AddressBooks[i].Contacts[j].City1.Equals(name))
                    Console.WriteLine(AddressBooks[i].Contacts[j].ToString());
                }
            }
        }

        // Display Person Contact by City Name
        public void ViewPersonsByCity()
        {
            string[] cityNames = new string[50];
            ContactsInfo[][] cityContacts = new ContactsInfo[50][];
            int[] cityCounts = new int[50];
            int citySize = 0;

            for (int i = 0; i < count; i++)
            {
                AddressBook book = AddressBooks[i];

                for (int j = 0; j < book.Count; j++)
                {
                    ContactsInfo contact = book.Contacts[j];
                    string city = contact.City1;

                    int index = -1;
                    for (int k = 0; k < citySize; k++)
                    {
                        if (cityNames[k].Equals(city))
                        {
                            index = k;
                            break;
                        }
                    }

                    if (index == -1)
                    {
                        cityNames[citySize] = city;
                        cityContacts[citySize] = new ContactsInfo[20];
                        cityContacts[citySize][0] = contact;
                        cityCounts[citySize] = 1;
                        citySize++;
                    }
                    else
                    {
                        cityContacts[index][cityCounts[index]++] = contact;
                    }
                }
            }

            for (int i = 0; i < citySize; i++)
            {
                Console.WriteLine($"\nCity: {cityNames[i]}");
                Console.WriteLine("------------------");
                for (int j = 0; j < cityCounts[i]; j++)
                {
                    Console.WriteLine(cityContacts[i][j].ToString());
                }
            }
        }

        // Display Person Contact by StateName
        public void ViewPersonsByState()
        {
            string[] stateNames = new string[50];
            ContactsInfo[][] stateContacts = new ContactsInfo[50][];
            int[] stateCounts = new int[50];
            int stateSize = 0;

            for (int i = 0; i < count; i++)
            {
                AddressBook book = AddressBooks[i];

                for (int j = 0; j < book.Count; j++)
                {
                    ContactsInfo contact = book.Contacts[j];
                    string state = contact.State1;

                    int index = -1;
                    for (int k = 0; k < stateSize; k++)
                    {
                        if (stateNames[k].Equals(state))
                        {
                            index = k;
                            break;
                        }
                    }

                    if (index == -1)
                    {
                        stateNames[stateSize] = state;
                        stateContacts[stateSize] = new ContactsInfo[20];
                        stateContacts[stateSize][0] = contact;
                        stateCounts[stateSize] = 1;
                        stateSize++;
                    }
                    else
                    {
                        stateContacts[index][stateCounts[index]++] = contact;
                    }
                }
            }

            for (int i = 0; i < stateSize; i++)
            {
                Console.WriteLine($"\nState: {stateNames[i]}");
                Console.WriteLine("------------------");
                for (int j = 0; j < stateCounts[i]; j++)
                {
                    Console.WriteLine(stateContacts[i][j].ToString());
                }
            }
        }

        // Method to Count Person By City
        public void CountPersonsByCity()
        {
            string[] cityNames = new string[50];
            int[] cityCounts = new int[50];
            int citySize = 0;

            for (int i = 0; i < count; i++)
            {
                AddressBook book = AddressBooks[i];

                for (int j = 0; j < book.Count; j++)
                {
                    string city = book.Contacts[j].City1;
                    int index = -1;

                    for (int k = 0; k < citySize; k++)
                    {
                        if (cityNames[k].Equals(city))
                        {
                            index = k;
                            break;
                        }
                    }

                    if (index == -1)
                    {
                        cityNames[citySize] = city;
                        cityCounts[citySize] = 1;
                        citySize++;
                    }
                    else
                    {
                        cityCounts[index]++;
                    }
                }
            }

            Console.WriteLine("\nPerson Count by City:");
            for (int i = 0; i < citySize; i++)
            {
                Console.WriteLine($"{cityNames[i]} : {cityCounts[i]}");
            }
        }

        // Method to Count Person By State
        public void CountPersonsByState()
        {
            string[] stateNames = new string[50];
            int[] stateCounts = new int[50];
            int stateSize = 0;

            for (int i = 0; i < count; i++)
            {
                AddressBook book = AddressBooks[i];

                for (int j = 0; j < book.Count; j++)
                {
                    string state = book.Contacts[j].State1;
                    int index = -1;

                    for (int k = 0; k < stateSize; k++)
                    {
                        if (stateNames[k].Equals(state))
                        {
                            index = k;
                            break;
                        }
                    }

                    if (index == -1)
                    {
                        stateNames[stateSize] = state;
                        stateCounts[stateSize] = 1;
                        stateSize++;
                    }
                    else
                    {
                        stateCounts[index]++;
                    }
                }
            }

            Console.WriteLine("\nPerson Count by State:");
            for (int i = 0; i < stateSize; i++)
            {
                Console.WriteLine($"{stateNames[i]} : {stateCounts[i]}");
            }
        }




    }
}

