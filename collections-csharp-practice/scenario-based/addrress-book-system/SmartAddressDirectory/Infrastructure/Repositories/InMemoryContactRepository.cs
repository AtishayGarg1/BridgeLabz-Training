
using System;
using System.Collections.Generic;
using System.Linq;
using SmartAddressDirectory.Core.Entities;
using SmartAddressDirectory.Core.Interfaces;

namespace SmartAddressDirectory.Infrastructure.Repositories
{
    public class InMemoryContactRepository : IContactRepository
    {
        private readonly List<ContactEntry> _contacts = new();

        public void Add(ContactEntry contact)
        {
            _contacts.Add(contact);
        }

        public IEnumerable<ContactEntry> GetAll() => _contacts;

        public ContactEntry GetById(Guid id)
        {
            return _contacts.FirstOrDefault(c => c.Id == id);
        }

        public void Remove(Guid id)
        {
            var contact = GetById(id);
            if (contact != null)
                _contacts.Remove(contact);
        }

        public void Update(ContactEntry contact)
        {
            var existing = GetById(contact.Id);
            if (existing != null)
            {
                existing.UpdateDetails(contact.EmailAddress, contact.PhoneNumber, contact.City);
            }
        }
    }
}
