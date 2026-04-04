
using System;
using System.Collections.Generic;
using AdvancedContactDirectory.Domain.Models;

namespace AdvancedContactDirectory.Domain.Contracts
{
    public interface IContactStore
    {
        void Insert(PersonContact contact);
        IEnumerable<PersonContact> RetrieveAll();
        PersonContact RetrieveById(Guid id);
        void Delete(Guid id);
        void Update(PersonContact contact);
    }
}
