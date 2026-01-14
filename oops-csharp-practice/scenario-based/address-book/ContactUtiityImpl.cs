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
            ContactsInfos[count] = new ContactsInfo();
            Console.Write("Enter First Name: ");
            ContactsInfos[count].FirstName1 = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            ContactsInfos[count].LastName1 = Console.ReadLine();
            Console.Write("Enter Address: ");
            ContactsInfos[count].Address1 = Console.ReadLine();
            Console.Write("Enter City: ");
            ContactsInfos[count].City1= Console.ReadLine();
            Console.Write("Enter State: ");
            ContactsInfos[count].State1= Console.ReadLine();
            Console.Write("Enter ZIP: ");
            ContactsInfos[count].ZIP1= Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            ContactsInfos[count].PhoneNumber1= Console.ReadLine();
            Console.Write("Enter Email: ");
            ContactsInfos[count].Email1= Console.ReadLine();
            count++;
        }

        // Method to Edit Details Using name
        public void EditDetails(string Name)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(ContactsInfos[i].FirstName1);
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
                                Console.Write("Previous First Name: " + ContactsInfos[i].FirstName1);
                                ContactsInfos[i].FirstName1 = Console.ReadLine();
                                break;
                            case 2:
                                Console.Write("Previous Last Name: " + ContactsInfos[i].LastName1);
                                ContactsInfos[i].LastName1 = Console.ReadLine();
                                break;
                            case 3:
                                Console.Write("Previous Address: " + ContactsInfos[i].Address1);
                                ContactsInfos[i].Address1 = Console.ReadLine();
                                break;
                            case 4:
                                Console.Write("Previous City: " + ContactsInfos[i].City1);
                                ContactsInfos[i].City1 = Console.ReadLine();
                                break;
                            case 5:
                                Console.Write("Previous State: " + ContactsInfos[i].State1);
                                ContactsInfos[i].State1 = Console.ReadLine();
                                break;
                            case 6:
                                Console.Write("Previous ZIP: " + ContactsInfos[i].ZIP1);
                                ContactsInfos[i].ZIP1 = Console.ReadLine();
                                break;
                            case 7:
                                Console.Write("Previous Phone Number: " + ContactsInfos[i].PhoneNumber1);
                                ContactsInfos[i].PhoneNumber1 = Console.ReadLine();
                                break;
                            case 8:
                                Console.Write("Previous Email: " + ContactsInfos[i].Email1);
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

    }
}
