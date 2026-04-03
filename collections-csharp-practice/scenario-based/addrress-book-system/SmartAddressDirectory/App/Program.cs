
using System;
using SmartAddressDirectory.Infrastructure.Repositories;
using SmartAddressDirectory.Services;
using SmartAddressDirectory.Helpers;

namespace SmartAddressDirectory.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new InMemoryContactRepository();
            var manager = new ContactManager(repository);

            manager.CreateContact("John Doe", "john@example.com", "9876543210", "New York");
            manager.CreateContact("Jane Smith", "jane@example.com", "9123456780", "Chicago");

            ConsolePrinter.DisplayMessage("Contact List");

            foreach (var contact in manager.ListContacts())
            {
                Console.WriteLine($"{contact.FullName} | {contact.EmailAddress} | {contact.PhoneNumber} | {contact.City}");
            }
        }
    }
}
