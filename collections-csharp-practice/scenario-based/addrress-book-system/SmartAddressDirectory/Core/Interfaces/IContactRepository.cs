
using System;
using System.Collections.Generic;
using SmartAddressDirectory.Core.Entities;

namespace SmartAddressDirectory.Core.Interfaces
{
    public interface IContactRepository
    {
        void Add(ContactEntry contact);
        IEnumerable<ContactEntry> GetAll();
        ContactEntry GetById(Guid id);
        void Remove(Guid id);
        void Update(ContactEntry contact);
    }
}
