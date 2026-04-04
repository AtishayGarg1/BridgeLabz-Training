
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartAddressDirectory.Infrastructure.Repositories;
using SmartAddressDirectory.Services;

namespace SmartAddressDirectory.Tests
{
    [TestClass]
    public class ContactManagerTests
    {
        [TestMethod]
        public void Should_Add_Contact_Successfully()
        {
            var repo = new InMemoryContactRepository();
            var manager = new ContactManager(repo);

            manager.CreateContact("Test User", "test@mail.com", "9999999999", "Delhi");

            Assert.AreEqual(1, manager.ListContacts().Count());
        }
    }
}
