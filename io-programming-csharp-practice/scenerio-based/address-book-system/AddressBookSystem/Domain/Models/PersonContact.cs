
using System;

namespace AdvancedContactDirectory.Domain.Models
{
    public class PersonContact
    {
        public Guid ContactId { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }

        public PersonContact(string name, string email, string phone, string address)
        {
            ContactId = Guid.NewGuid();
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Phone = phone ?? throw new ArgumentNullException(nameof(phone));
            Address = address ?? throw new ArgumentNullException(nameof(address));
        }

        public void Modify(string email, string phone, string address)
        {
            Email = email;
            Phone = phone;
            Address = address;
        }
    }
}
