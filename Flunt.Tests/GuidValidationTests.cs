using System;
using Flunt.Tests.Entities;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class GuidValidationTests
    {
        private readonly SampleEntity _entity = new SampleEntity();

        [TestCategory("Guid Validation")]
        [TestMethod("Requires two GUIDs are equals")]
        public void RequiresAreEquals()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .AreEquals(_entity.GuidNotEmpty, _entity.GuidNotEmpty, "Guid")
                .AreEquals(_entity.GuidNotEmpty, _entity.GuidNotEmpty, "Guid", "Custom message here")
                .AreEquals(_entity.GuidNotEmpty, Guid.NewGuid(), "Guid")
                .AreEquals(_entity.GuidNotEmpty, Guid.NewGuid(), "Guid", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Guid Validation")]
        [TestMethod("Requires two GUIDs are not equals")]
        public void RequiresAreNotEquals()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .AreNotEquals(_entity.GuidNotEmpty, _entity.GuidNotEmpty, "Guid")
                .AreNotEquals(_entity.GuidNotEmpty, _entity.GuidNotEmpty, "Guid", "Custom message here")
                .AreNotEquals(_entity.GuidNotEmpty, Guid.NewGuid(), "Guid")
                .AreNotEquals(_entity.GuidNotEmpty, Guid.NewGuid(), "Guid", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Guid Validation")]
        [TestMethod("Requires GUID is empty")]
        public void RequiresIsEmpty()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsEmpty(_entity.GuidNotEmpty, "Guid")
                .IsEmpty(_entity.GuidNotEmpty, "Guid", "Custom message here")
                .IsEmpty(_entity.GuidEmpty, "Guid")
                .IsEmpty(_entity.GuidEmpty, "Guid", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Guid Validation")]
        [TestMethod("Requires GUID is not empty")]
        public void RequiresIsNotEmpty()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotEmpty(_entity.GuidNotEmpty, "Guid")
                .IsNotEmpty(_entity.GuidNotEmpty, "Guid", "Custom message here")
                .IsNotEmpty(_entity.GuidEmpty, "Guid")
                .IsNotEmpty(_entity.GuidEmpty, "Guid", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }
    }
}
