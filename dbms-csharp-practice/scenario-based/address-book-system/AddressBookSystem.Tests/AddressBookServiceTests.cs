
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddressBookSystem.Application.Services;
using AddressBookSystem.Infrastructure.Repositories;
using System.Linq;

namespace AddressBookSystem.Tests
{
    [TestClass]
    public class AddressBookServiceTests
    {
        [TestMethod]
        public void AddContact_ShouldIncreaseCount()
        {
            var repository = new InMemoryRepository();
            var service = new AddressBookService(repository);

            service.AddContact("Test", "User", "test@mail.com", "9999999999");

            Assert.AreEqual(1, service.GetAllContacts().Count());
        }
    }
}
