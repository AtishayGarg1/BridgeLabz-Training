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
        public ContactUtiityImpl()
        {
            ContactsInfos = new ContactsInfo[Capacity];
        }

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

        
    }
}
