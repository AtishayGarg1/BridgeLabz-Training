
using System;
using AddressBookSystem.Application.Services;
using AddressBookSystem.Infrastructure.Repositories;

namespace AddressBookSystem.Presentation
{
    class Program
    {
        static void Main()
        {
            var repository = new InMemoryRepository();
            var service = new AddressBookService(repository);

            service.AddContact("Rahul", "Sharma", "rahul@mail.com", "9000000001");
            service.AddContact("Anita", "Verma", "anita@mail.com", "9000000002");

            Console.WriteLine("==== Address Book System ====");

            foreach (var contact in service.GetAllContacts())
            {
                Console.WriteLine(contact);
            }
        }
    }
}
