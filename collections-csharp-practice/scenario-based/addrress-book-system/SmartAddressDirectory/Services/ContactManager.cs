
using System;
using System.Collections.Generic;
using SmartAddressDirectory.Core.Entities;
using SmartAddressDirectory.Core.Interfaces;

namespace SmartAddressDirectory.Services
{
    public class ContactManager
    {
        private readonly IContactRepository _repository;

        public ContactManager(IContactRepository repository)
        {
            _repository = repository;
        }

        public void CreateContact(string name, string email, string phone, string city)
        {
            var contact = new ContactEntry(name, email, phone, city);
            _repository.Add(contact);
        }

        public IEnumerable<ContactEntry> ListContacts()
        {
            return _repository.GetAll();
        }

        public void DeleteContact(Guid id)
        {
            _repository.Remove(id);
        }
    }
}
