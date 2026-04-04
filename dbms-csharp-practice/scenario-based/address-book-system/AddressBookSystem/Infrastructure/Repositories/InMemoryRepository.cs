
using System;
using System.Collections.Generic;
using System.Linq;
using AddressBookSystem.Domain.Entities;
using AddressBookSystem.Domain.Interfaces;

namespace AddressBookSystem.Infrastructure.Repositories
{
    public class InMemoryRepository : IContactRepository
    {
        private readonly List<Contact> _contacts = new();

        public void Add(Contact contact) => _contacts.Add(contact);

        public IEnumerable<Contact> GetAll() => _contacts;

        public Contact? GetById(Guid id) =>
            _contacts.FirstOrDefault(c => c.Id == id);

        public void Update(Contact contact)
        {
            var existing = GetById(contact.Id);
            if (existing != null)
                existing.UpdateDetails(contact.Email, contact.Phone);
        }

        public void Delete(Guid id)
        {
            var contact = GetById(id);
            if (contact != null)
                _contacts.Remove(contact);
        }
    }
}
