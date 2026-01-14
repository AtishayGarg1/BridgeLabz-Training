using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.UCScenarioBased.AddressBook
{
    internal class ContactsInfo
    {
        // Private fields to store contact details
        private string FirstName;
        private string LastName;
        private string Address;
        private string City;
        private string State;
        private string ZIP;
        private string PhoneNumber;
        private string Email;

        // Public properties to provide access to private fields
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string City1 { get => City; set => City = value; }
        public string State1 { get => State; set => State = value; }
        public string ZIP1 { get => ZIP; set => ZIP = value; }
        public string PhoneNumber1 { get => PhoneNumber; set => PhoneNumber = value; }
        public string Email1 { get => Email; set => Email = value; }

        // Override ToString Method
        public override string? ToString()
        {
            return $"Name: {FirstName} {LastName}\nAddress: {Address}\nCity: {City}\nState: {State}\nZIP: {ZIP}\nPhone Number: {PhoneNumber}\nEmail: {Email}";
        }
    }
}
