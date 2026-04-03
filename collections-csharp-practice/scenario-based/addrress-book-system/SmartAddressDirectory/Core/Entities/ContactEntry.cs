
using System;

namespace SmartAddressDirectory.Core.Entities
{
    public class ContactEntry
    {
        public Guid Id { get; private set; }
        public string FullName { get; private set; }
        public string EmailAddress { get; private set; }
        public string PhoneNumber { get; private set; }
        public string City { get; private set; }

        public ContactEntry(string fullName, string email, string phone, string city)
        {
            Id = Guid.NewGuid();
            FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
            EmailAddress = email ?? throw new ArgumentNullException(nameof(email));
            PhoneNumber = phone ?? throw new ArgumentNullException(nameof(phone));
            City = city ?? throw new ArgumentNullException(nameof(city));
        }

        public void UpdateDetails(string email, string phone, string city)
        {
            EmailAddress = email;
            PhoneNumber = phone;
            City = city;
        }
    }
}
