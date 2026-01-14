using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.UCScenarioBased.AddressBook
{
    internal class ContactUtiityImpl : IContactable
    {
        private int Capacity = 10;
        private ContactsInfo[] ContactsInfos;
        private ContactsInfo ContactInformation;
        int count = 0;

        // Constructor to Initialize size of Address Book
        public ContactUtiityImpl()
        {
            ContactsInfos = new ContactsInfo[Capacity];
        }

        // Method to add Contact
        public void AddContact()
        {
            if(count >= Capacity)
            {
                return;
            }
            ContactInformation = new ContactsInfo();
            
            ContactsInfos[count] = new ContactsInfo();
            Console.Write("Enter First Name: ");
            ContactInformation.FirstName1 = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            ContactInformation.LastName1 = Console.ReadLine();

            Console.Write("Enter Address: ");
            ContactInformation.Address1 = Console.ReadLine();

            Console.Write("Enter City: ");
            ContactInformation.City1 = Console.ReadLine();

            Console.Write("Enter State: ");
            ContactInformation.State1 = Console.ReadLine();

            Console.Write("Enter ZIP: ");
            ContactInformation.ZIP1 = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            ContactInformation.PhoneNumber1 = Console.ReadLine();

            Console.Write("Enter Email: ");
            ContactInformation.Email1 = Console.ReadLine();

            ContactsInfos[count++] = ContactInformation;
        }

        // Method to Edit Details Using name
        public void EditDetails(string Name)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Clear();
                sb.Append(ContactsInfos[i].FirstName1);
                sb.Append(" ");
                sb.Append(ContactsInfos[i].LastName1);
                if (Name.ToLower().Contains(sb.ToString().ToLower()))
                {
                    while (true)
                    {
                        Console.WriteLine("Edit Contact Details");
                        Console.WriteLine("1. Edit First Name");
                        Console.WriteLine("2. Edit Last Name");
                        Console.WriteLine("3. Edit Address");
                        Console.WriteLine("4. Edit City");
                        Console.WriteLine("5. Edit State");
                        Console.WriteLine("6. Edit ZIP");
                        Console.WriteLine("7. Edit Phone Number");
                        Console.WriteLine("8. Edit Email");
                        Console.WriteLine("9. Exit");
                        int choice;
                        int.TryParse(Console.ReadLine(), out choice);
                        // Switch case to ask user what to change
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Previous First Name: " + ContactsInfos[i].FirstName1);
                                ContactsInfos[i].FirstName1 = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Previous Last Name: " + ContactsInfos[i].LastName1);
                                ContactsInfos[i].LastName1 = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Previous Address: " + ContactsInfos[i].Address1);
                                ContactsInfos[i].Address1 = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Previous City: " + ContactsInfos[i].City1);
                                ContactsInfos[i].City1 = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Previous State: " + ContactsInfos[i].State1);
                                ContactsInfos[i].State1 = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("Previous ZIP: " + ContactsInfos[i].ZIP1);
                                ContactsInfos[i].ZIP1 = Console.ReadLine();
                                break;
                            case 7:
                                Console.WriteLine("Previous Phone Number: " + ContactsInfos[i].PhoneNumber1);
                                ContactsInfos[i].PhoneNumber1 = Console.ReadLine();
                                break;
                            case 8:
                                Console.WriteLine("Previous Email: " + ContactsInfos[i].Email1);
                                ContactsInfos[i].Email1 = Console.ReadLine();
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

        public void DisplayDetails()
        {
            for(int i = 0; i < count; i++)
            {
                if (ContactsInfos[i] == null)
                {
                    continue;
                }
                Console.WriteLine(ContactsInfos[i].ToString());
            }
        }

        // Method to Delete a contact
        public void DeleteContact(string name)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < ContactsInfos.Length; i++)
            {
                if (ContactsInfos[i] == null)
                {
                    continue;
                }
                sb.Clear();
                sb.Append(ContactsInfos[i].FirstName1 + " " + ContactsInfos[i].LastName1);
                if (sb.ToString().ToLower().Equals(name.ToLower()))
                {
                    int index = i;
                    // Adjust array on deleting a contact
                    while (index < ContactsInfos.Length - 1)
                    {
                        if(ContactsInfos[index+1] != null)
                        {
                            ContactsInfos[index] = ContactsInfos[index + 1];
                        }
                        index++;
                    }
                }
            }
        }

    }
}
