using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.UCScenarioBased.AddressBook
{
    internal class ContactUtilityImpl : IContactable
    {
        private AddressBook addressBook;

        // Used to select an addresbook
        public void SetAddressBook(AddressBook addressBook)
        {
            this.addressBook = addressBook;
        }

        // Add Contact
        public void AddContact()
        {
            if (addressBook.Count >= addressBook.Contacts.Length)
            {
                Console.WriteLine("AddressBook is full");
                return;
            }


            ContactsInfo contact = new ContactsInfo();
            
            Console.Write("Enter First Name: ");
            contact.FirstName1 = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            contact.LastName1 = Console.ReadLine();

            if(AlreadyExists(contact.FirstName1, contact.LastName1))
            {
                Console.WriteLine("Contact Already exists");
                return;
            }

            Console.Write("Enter Address: ");
            contact.Address1 = Console.ReadLine();

            Console.Write("Enter City: ");
            contact.City1 = Console.ReadLine();

            Console.Write("Enter State: ");
            contact.State1 = Console.ReadLine();

            Console.Write("Enter ZIP: ");
            contact.ZIP1 = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            contact.PhoneNumber1 = Console.ReadLine();

            Console.Write("Enter Email: ");
            contact.Email1 = Console.ReadLine();

            addressBook.Contacts[addressBook.Count++] = contact;

            Console.WriteLine("Contact added successfully");
        }

        // Edit Contact Details
        public void EditDetails(string name)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < addressBook.Count; i++)
            {
                sb.Clear();
                sb.Append(addressBook.Contacts[i].FirstName1);
                sb.Append(" ");
                sb.Append(addressBook.Contacts[i].LastName1);

                if (sb.ToString().Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    while (true)
                    {
                        Console.WriteLine("\nEdit Contact Details");
                        Console.WriteLine("1. First Name");
                        Console.WriteLine("2. Last Name");
                        Console.WriteLine("3. Address");
                        Console.WriteLine("4. City");
                        Console.WriteLine("5. State");
                        Console.WriteLine("6. ZIP");
                        Console.WriteLine("7. Phone Number");
                        Console.WriteLine("8. Email");
                        Console.WriteLine("9. Exit");

                        int choice;
                        int.TryParse(Console.ReadLine(), out choice);

                        switch (choice)
                        {
                            case 1:
                                addressBook.Contacts[i].FirstName1 = Console.ReadLine();
                                break;
                            case 2:
                                addressBook.Contacts[i].LastName1 = Console.ReadLine();
                                break;
                            case 3:
                                addressBook.Contacts[i].Address1 = Console.ReadLine();
                                break;
                            case 4:
                                addressBook.Contacts[i].City1 = Console.ReadLine();
                                break;
                            case 5:
                                addressBook.Contacts[i].State1 = Console.ReadLine();
                                break;
                            case 6:
                                addressBook.Contacts[i].ZIP1 = Console.ReadLine();
                                break;
                            case 7:
                                addressBook.Contacts[i].PhoneNumber1 = Console.ReadLine();
                                break;
                            case 8:
                                addressBook.Contacts[i].Email1 = Console.ReadLine();
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

            Console.WriteLine("Contact not found");
        }

        // Display Contacts
        public void DisplayDetails()
        {
            if (addressBook.Count == 0)
            {
                Console.WriteLine("No contacts available");
                return;
            }

            for (int i = 0; i < addressBook.Count; i++)
            {
                Console.WriteLine(addressBook.Contacts[i].ToString());
            }
        }

        // Delete Contact
        public void DeleteContact(string name)
        {
            for (int i = 0; i < addressBook.Count; i++)
            {
                string fullName = addressBook.Contacts[i].FirstName1 + " " +
                                  addressBook.Contacts[i].LastName1;

                if (fullName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    for (int j = i; j < addressBook.Count - 1; j++)
                    {
                        addressBook.Contacts[j] = addressBook.Contacts[j + 1];
                    }

                    addressBook.Contacts[--addressBook.Count] = null;
                    Console.WriteLine("Contact deleted");
                    return;
                }
            }

            Console.WriteLine("Contact not found");
        }

        // Method to check If a contact already exists in an addressbook
        public bool AlreadyExists(string firstName, string lastName)
        {
            for(int i = 0; i < addressBook.Contacts.Length; i++)
            {
                ContactsInfo contactInfo = addressBook.Contacts[i];
                if(contactInfo == null)
                {
                    return false;
                }
                if(contactInfo.FirstName1.Equals(firstName) && contactInfo.LastName1.Equals(lastName))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
