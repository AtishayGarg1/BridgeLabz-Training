
using System;
using System.Collections.Generic;
using AddressBookSystem.Domain.Entities;
using AddressBookSystem.Domain.Interfaces;

namespace AddressBookSystem.Application.Services
{
    public class AddressBookService
    {
        private readonly IContactRepository _repository;

        public AddressBookService(IContactRepository repository)
        {
            _repository = repository;
        }

        public void AddContact(string firstName, string lastName, string email, string phone)
        {
            var contact = new Contact(firstName, lastName, email, phone);
            _repository.Add(contact);
        }

        public IEnumerable<Contact> GetAllContacts() => _repository.GetAll();

        public void RemoveContact(Guid id) => _repository.Delete(id);
    }
}
