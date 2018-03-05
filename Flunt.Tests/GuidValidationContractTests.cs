using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Flunt.Tests
{
    [TestClass]
    public class GuidContractTests
    {
        [TestMethod]
        [TestCategory("GuidValidation")]
        public void Guid_IsEmpty_Valid()
        {
            var value = Guid.Empty;

            var contract = new Contract()
                .Requires()
                .IsEmpty(value, "guid", "Guid is not empty");

            Assert.IsTrue(contract.Valid);
            Assert.AreEqual(0, contract.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("GuidValidation")]
        public void Guid_IsEmpty_Invalid()
        {
            var value = Guid.NewGuid();

            var contract = new Contract()
                .Requires()
                .IsEmpty(value, "guid", "Guid is not empty");

            Assert.IsTrue(contract.Invalid);
            Assert.AreEqual(1, contract.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("GuidValidation")]
        public void Guid_IsNotEmpty_Valid()
        {
            var value = Guid.NewGuid();

            var contract = new Contract()
                .Requires()
                .IsNotEmpty(value, "guid", "Guid is empty");

            Assert.IsTrue(contract.Valid);
            Assert.AreEqual(0, contract.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("GuidValidation")]
        public void Guid_IsNotEmpty_Invalid()
        {
            var value = Guid.Empty;

            var contract = new Contract()
                .Requires()
                .IsNotEmpty(value, "guid", "Guid is empty");

            Assert.IsTrue(contract.Invalid);
            Assert.AreEqual(1, contract.Notifications.Count);
        }

    }
}
