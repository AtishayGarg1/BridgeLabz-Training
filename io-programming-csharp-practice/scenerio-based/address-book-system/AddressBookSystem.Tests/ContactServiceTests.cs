
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdvancedContactDirectory.Application.Services;
using AdvancedContactDirectory.Infrastructure.Data;

namespace AdvancedContactDirectory.Tests
{
    [TestClass]
    public class ContactServiceTests
    {
        [TestMethod]
        public void Add_ShouldIncreaseCount()
        {
            var store = new MemoryContactStore();
            var service = new ContactService(store);

            service.Add("Test User", "test@mail.com", "9999999999", "Delhi");

            Assert.AreEqual(1, service.GetAll().Count());
        }
    }
}
