using Flunt.Tests.Entities;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class ListValidationTests
    {
        private readonly SampleEntity _entity = new SampleEntity();

        [TestCategory("List Validation")]
        [TestMethod("Requires a list is null")]
        public void RequiresIsNull()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNull(_entity.ListNull, "List")
                .IsNull(_entity.ListNull, "List", "Custom message here")
                .IsNull(_entity.ListNotNull, "List")
                .IsNull(_entity.ListNotNull, "List", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("List Validation")]
        [TestMethod("Requires a list is not null")]
        public void RequiresIsNotNull()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotNull(_entity.ListNull, "List")
                .IsNotNull(_entity.ListNull, "List", "Custom message here")
                .IsNotNull(_entity.ListNotNull, "List")
                .IsNotNull(_entity.ListNotNull, "List", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("List Validation")]
        [TestMethod("Requires a list has no elements")]
        public void RequiresIsEmpty()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsEmpty(_entity.ListEmpty, "List")
                .IsEmpty(_entity.ListEmpty, "List", "Custom message here")
                .IsEmpty(_entity.ListNotEmpty, "List")
                .IsEmpty(_entity.ListNotEmpty, "List", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("List Validation")]
        [TestMethod("Requires a list has at least one element")]
        public void RequiresIsNotEmpty()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotEmpty(_entity.ListEmpty, "List")
                .IsNotEmpty(_entity.ListEmpty, "List", "Custom message here")
                .IsNotEmpty(_entity.ListNotEmpty, "List")
                .IsNotEmpty(_entity.ListNotEmpty, "List", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("List Validation")]
        [TestMethod("Requires a list count is greater than")]
        public void RequiresIsGreaterThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsGreaterThan(_entity.ListNotEmpty, 0, "List")
                .IsGreaterThan(_entity.ListNotEmpty, 1, "List")
                .IsGreaterThan(_entity.ListNotEmpty, 2, "List")
                .IsGreaterThan(_entity.ListNotEmpty, 3, "List")
                .IsGreaterThan(_entity.ListNotEmpty, 4, "List")

                .IsGreaterThan(_entity.ListNotEmpty, 0, "List", "Custom message here")
                .IsGreaterThan(_entity.ListNotEmpty, 1, "List", "Custom message here")
                .IsGreaterThan(_entity.ListNotEmpty, 2, "List", "Custom message here")
                .IsGreaterThan(_entity.ListNotEmpty, 3, "List", "Custom message here")
                .IsGreaterThan(_entity.ListNotEmpty, 4, "List", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 4);
        }

        [TestCategory("List Validation")]
        [TestMethod("Requires a list count is greater or equals than")]
        public void RequiresIsGreaterOrEqualsThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsGreaterOrEqualsThan(_entity.ListNotEmpty, 0, "List")
                .IsGreaterOrEqualsThan(_entity.ListNotEmpty, 1, "List")
                .IsGreaterOrEqualsThan(_entity.ListNotEmpty, 2, "List")
                .IsGreaterOrEqualsThan(_entity.ListNotEmpty, 3, "List")
                .IsGreaterOrEqualsThan(_entity.ListNotEmpty, 4, "List")

                .IsGreaterOrEqualsThan(_entity.ListNotEmpty, 0, "List", "Custom message here")
                .IsGreaterOrEqualsThan(_entity.ListNotEmpty, 1, "List", "Custom message here")
                .IsGreaterOrEqualsThan(_entity.ListNotEmpty, 2, "List", "Custom message here")
                .IsGreaterOrEqualsThan(_entity.ListNotEmpty, 3, "List", "Custom message here")
                .IsGreaterOrEqualsThan(_entity.ListNotEmpty, 4, "List", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("List Validation")]
        [TestMethod("Requires a list count is lower than")]
        public void RequiresIsLowerThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsLowerThan(_entity.ListNotEmpty, 0, "List")
                .IsLowerThan(_entity.ListNotEmpty, 1, "List")
                .IsLowerThan(_entity.ListNotEmpty, 2, "List")
                .IsLowerThan(_entity.ListNotEmpty, 3, "List")
                .IsLowerThan(_entity.ListNotEmpty, 4, "List")

                .IsLowerThan(_entity.ListNotEmpty, 0, "List", "Custom message here")
                .IsLowerThan(_entity.ListNotEmpty, 1, "List", "Custom message here")
                .IsLowerThan(_entity.ListNotEmpty, 2, "List", "Custom message here")
                .IsLowerThan(_entity.ListNotEmpty, 3, "List", "Custom message here")
                .IsLowerThan(_entity.ListNotEmpty, 4, "List", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 4);
        }

        [TestCategory("List Validation")]
        [TestMethod("Requires a list count is lower or equals than")]
        public void RequiresIsLowerOrEqualsThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsLowerThan(_entity.ListNotEmpty, 0, "List")
                .IsLowerThan(_entity.ListNotEmpty, 1, "List")
                .IsLowerThan(_entity.ListNotEmpty, 2, "List")
                .IsLowerThan(_entity.ListNotEmpty, 3, "List")
                .IsLowerThan(_entity.ListNotEmpty, 4, "List")

                .IsLowerThan(_entity.ListNotEmpty, 0, "List", "Custom message here")
                .IsLowerThan(_entity.ListNotEmpty, 1, "List", "Custom message here")
                .IsLowerThan(_entity.ListNotEmpty, 2, "List", "Custom message here")
                .IsLowerThan(_entity.ListNotEmpty, 3, "List", "Custom message here")
                .IsLowerThan(_entity.ListNotEmpty, 4, "List", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }
    }
}
