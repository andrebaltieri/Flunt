using Flunt.Tests.Entities;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class ObjectValidationTests
    {
        private readonly SampleEntity _entity = new SampleEntity();

        [TestCategory("Object Validation")]
        [TestMethod("Requires an object is null")]
        public void IsNull()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNull(_entity.ObjectNull, "Object")
                .IsNull(_entity.ObjectNull, "Object", "Custom error message")

                .IsNull(_entity.ObjectToCompare, "Object")
                .IsNull(_entity.ObjectToCompare, "Object", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Object Validation")]
        [TestMethod("Requires an object is not null")]
        public void IsNotNull()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotNull(_entity.ObjectNull, "Object")
                .IsNotNull(_entity.ObjectNull, "Object", "Custom error message")

                .IsNotNull(_entity.ObjectToCompare, "Object")
                .IsNotNull(_entity.ObjectToCompare, "Object", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Object Validation")]
        [TestMethod("Requires two objects are equals")]
        public void AreEquals()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .AreEquals(_entity.ObjectNull, _entity.ObjectToCompare, "Object")
                .AreEquals(_entity.ObjectNull, _entity.ObjectToCompare, "Object", "Custom error message")

                .AreEquals(_entity.ObjectToCompare, _entity.ObjectAnotherToCompare, "Object")
                .AreEquals(_entity.ObjectToCompare, _entity.ObjectAnotherToCompare, "Object", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Object Validation")]
        [TestMethod("Requires two objects are not equals")]
        public void AreNotEquals()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .AreNotEquals(_entity.ObjectNull, _entity.ObjectToCompare, "Object")
                .AreNotEquals(_entity.ObjectNull, _entity.ObjectToCompare, "Object", "Custom error message")

                .AreNotEquals(_entity.ObjectToCompare, _entity.ObjectAnotherToCompare, "Object")
                .AreNotEquals(_entity.ObjectToCompare, _entity.ObjectAnotherToCompare, "Object", "Custom error message");

            Assert.AreEqual(true, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 0);
        }
    }
}
