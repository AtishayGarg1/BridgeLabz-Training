
using System;
using System.Collections.Generic;
using AdvancedContactDirectory.Domain.Contracts;
using AdvancedContactDirectory.Domain.Models;

namespace AdvancedContactDirectory.Application.Services
{
    public class ContactService
    {
        private readonly IContactStore _store;

        public ContactService(IContactStore store)
        {
            _store = store;
        }

        public void Add(string name, string email, string phone, string address)
        {
            var contact = new PersonContact(name, email, phone, address);
            _store.Insert(contact);
        }

        public IEnumerable<PersonContact> GetAll()
        {
            return _store.RetrieveAll();
        }

        public void Remove(Guid id)
        {
            _store.Delete(id);
        }
    }
}
