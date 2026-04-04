
using System;
using System.Collections.Generic;
using AddressBookSystem.Domain.Entities;

namespace AddressBookSystem.Domain.Interfaces
{
    public interface IContactRepository
    {
        void Add(Contact contact);
        IEnumerable<Contact> GetAll();
        Contact? GetById(Guid id);
        void Update(Contact contact);
        void Delete(Guid id);
    }
}
