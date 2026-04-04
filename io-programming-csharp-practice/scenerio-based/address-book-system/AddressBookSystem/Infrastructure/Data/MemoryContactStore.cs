
using System;
using System.Collections.Generic;
using System.Linq;
using AdvancedContactDirectory.Domain.Contracts;
using AdvancedContactDirectory.Domain.Models;

namespace AdvancedContactDirectory.Infrastructure.Data
{
    public class MemoryContactStore : IContactStore
    {
        private readonly List<PersonContact> _storage = new();

        public void Insert(PersonContact contact) => _storage.Add(contact);

        public IEnumerable<PersonContact> RetrieveAll() => _storage;

        public PersonContact RetrieveById(Guid id) =>
            _storage.FirstOrDefault(c => c.ContactId == id);

        public void Delete(Guid id)
        {
            var contact = RetrieveById(id);
            if (contact != null)
                _storage.Remove(contact);
        }

        public void Update(PersonContact contact)
        {
            var existing = RetrieveById(contact.ContactId);
            if (existing != null)
            {
                existing.Modify(contact.Email, contact.Phone, contact.Address);
            }
        }
    }
}
