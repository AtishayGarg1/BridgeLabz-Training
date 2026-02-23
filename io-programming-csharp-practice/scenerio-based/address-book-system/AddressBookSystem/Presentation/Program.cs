
using System;
using AdvancedContactDirectory.Application.Services;
using AdvancedContactDirectory.Infrastructure.Data;

namespace AdvancedContactDirectory.Presentation
{
    class Program
    {
        static void Main()
        {
            var store = new MemoryContactStore();
            var service = new ContactService(store);

            service.Add("Alice Johnson", "alice@mail.com", "8888888888", "Los Angeles");
            service.Add("Bob Martin", "bob@mail.com", "7777777777", "San Francisco");

            Console.WriteLine("==== Contact Directory ====");

            foreach (var contact in service.GetAll())
            {
                Console.WriteLine($"{contact.Name} | {contact.Email} | {contact.Phone} | {contact.Address}");
            }
        }
    }
}
