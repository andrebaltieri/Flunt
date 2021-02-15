using Flunt.Tests.Entities;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class LongValidationTests
    {
        private readonly SampleEntity _entity = new SampleEntity();

        [TestCategory("Long Validation")]
        [TestMethod("Requires a long is greater than")]
        public void RequiresLongIsGreaterThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsGreaterThan((long)0, (int)10, "Long")
                .IsGreaterThan((long)0, (int)10, "Long", "Custom message here")
                .IsGreaterThan((long)10, (int)10, "Long")
                .IsGreaterThan((long)10, (int)10, "Long", "Custom message here")
                .IsGreaterThan((long)20, (int)10, "Long")
                .IsGreaterThan((long)20, (int)10, "Long", "Custom message here")

                .IsGreaterThan((long)0, (float)10, "Long")
                .IsGreaterThan((long)0, (float)10, "Long", "Custom message here")
                .IsGreaterThan((long)10, (float)10, "Long")
                .IsGreaterThan((long)10, (float)10, "Long", "Custom message here")
                .IsGreaterThan((long)20, (float)10, "Long")
                .IsGreaterThan((long)20, (float)10, "Long", "Custom message here")

                .IsGreaterThan((long)0, (double)10, "Long")
                .IsGreaterThan((long)0, (double)10, "Long", "Custom message here")
                .IsGreaterThan((long)10, (double)10, "Long")
                .IsGreaterThan((long)10, (double)10, "Long", "Custom message here")
                .IsGreaterThan((long)20, (double)10, "Long")
                .IsGreaterThan((long)20, (double)10, "Long", "Custom message here")

                .IsGreaterThan((long)0, (long)10, "Long")
                .IsGreaterThan((long)0, (long)10, "Long", "Custom message here")
                .IsGreaterThan((long)10, (long)10, "Long")
                .IsGreaterThan((long)10, (long)10, "Long", "Custom message here")
                .IsGreaterThan((long)20, (long)10, "Long")
                .IsGreaterThan((long)20, (long)10, "Long", "Custom message here")

                .IsGreaterThan((long)0, (decimal)10, "Long")
                .IsGreaterThan((long)0, (decimal)10, "Long", "Custom message here")
                .IsGreaterThan((long)10, (decimal)10, "Long")
                .IsGreaterThan((long)10, (decimal)10, "Long", "Custom message here")
                .IsGreaterThan((long)20, (decimal)10, "Long")
                .IsGreaterThan((long)20, (decimal)10, "Long", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 20);
        }

        [TestCategory("Long Validation")]
        [TestMethod("Requires a long is greater or equals than")]
        public void RequiresLongIsGreaterOrEqualsThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsGreaterOrEqualsThan((long)0, (int)10, "Long")
                .IsGreaterOrEqualsThan((long)0, (int)10, "Long", "Custom message here")
                .IsGreaterOrEqualsThan((long)10, (int)10, "Long")
                .IsGreaterOrEqualsThan((long)10, (int)10, "Long", "Custom message here")
                .IsGreaterOrEqualsThan((long)20, (int)10, "Long")
                .IsGreaterOrEqualsThan((long)20, (int)10, "Long", "Custom message here")

                .IsGreaterOrEqualsThan((long)0, (float)10, "Long")
                .IsGreaterOrEqualsThan((long)0, (float)10, "Long", "Custom message here")
                .IsGreaterOrEqualsThan((long)10, (float)10, "Long")
                .IsGreaterOrEqualsThan((long)10, (float)10, "Long", "Custom message here")
                .IsGreaterOrEqualsThan((long)20, (float)10, "Long")
                .IsGreaterOrEqualsThan((long)20, (float)10, "Long", "Custom message here")

                .IsGreaterOrEqualsThan((long)0, (double)10, "Long")
                .IsGreaterOrEqualsThan((long)0, (double)10, "Long", "Custom message here")
                .IsGreaterOrEqualsThan((long)10, (double)10, "Long")
                .IsGreaterOrEqualsThan((long)10, (double)10, "Long", "Custom message here")
                .IsGreaterOrEqualsThan((long)20, (double)10, "Long")
                .IsGreaterOrEqualsThan((long)20, (double)10, "Long", "Custom message here")

                .IsGreaterOrEqualsThan((long)0, (long)10, "Long")
                .IsGreaterOrEqualsThan((long)0, (long)10, "Long", "Custom message here")
                .IsGreaterOrEqualsThan((long)10, (long)10, "Long")
                .IsGreaterOrEqualsThan((long)10, (long)10, "Long", "Custom message here")
                .IsGreaterOrEqualsThan((long)20, (long)10, "Long")
                .IsGreaterOrEqualsThan((long)20, (long)10, "Long", "Custom message here")

                .IsGreaterOrEqualsThan((long)0, (decimal)10, "Long")
                .IsGreaterOrEqualsThan((long)0, (decimal)10, "Long", "Custom message here")
                .IsGreaterOrEqualsThan((long)10, (decimal)10, "Long")
                .IsGreaterOrEqualsThan((long)10, (decimal)10, "Long", "Custom message here")
                .IsGreaterOrEqualsThan((long)20, (decimal)10, "Long")
                .IsGreaterOrEqualsThan((long)20, (decimal)10, "Long", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 10);
        }

        [TestCategory("Long Validation")]
        [TestMethod("Requires a long is lower than")]
        public void RequiresLongIsLowerThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsLowerThan((long)0, (int)0, "Long")
                .IsLowerThan((long)0, (int)0, "Long", "Custom message here")
                .IsLowerThan((long)-5, (int)0, "Long")
                .IsLowerThan((long)-5, (int)0, "Long", "Custom message here")
                .IsLowerThan((long)5, (int)0, "Long")
                .IsLowerThan((long)5, (int)0, "Long", "Custom message here")

                .IsLowerThan((long)0, (float)0, "Long")
                .IsLowerThan((long)0, (float)0, "Long", "Custom message here")
                .IsLowerThan((long)-5, (float)0, "Long")
                .IsLowerThan((long)-5, (float)0, "Long", "Custom message here")
                .IsLowerThan((long)5, (float)0, "Long")
                .IsLowerThan((long)5, (float)0, "Long", "Custom message here")

                .IsLowerThan((long)0, (double)0, "Long")
                .IsLowerThan((long)0, (double)0, "Long", "Custom message here")
                .IsLowerThan((long)-5, (double)0, "Long")
                .IsLowerThan((long)-5, (double)0, "Long", "Custom message here")
                .IsLowerThan((long)5, (double)0, "Long")
                .IsLowerThan((long)5, (double)0, "Long", "Custom message here")

                .IsLowerThan((long)0, (long)0, "Long")
                .IsLowerThan((long)0, (long)0, "Long", "Custom message here")
                .IsLowerThan((long)-5, (long)0, "Long")
                .IsLowerThan((long)-5, (long)0, "Long", "Custom message here")
                .IsLowerThan((long)5, (long)0, "Long")
                .IsLowerThan((long)5, (long)0, "Long", "Custom message here")

                .IsLowerThan((long)0, (decimal)0, "Long")
                .IsLowerThan((long)0, (decimal)0, "Long", "Custom message here")
                .IsLowerThan((long)-5, (decimal)0, "Long")
                .IsLowerThan((long)-5, (decimal)0, "Long", "Custom message here")
                .IsLowerThan((long)5, (decimal)0, "Long")
                .IsLowerThan((long)5, (decimal)0, "Long", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 20);
        }

        [TestCategory("Long Validation")]
        [TestMethod("Requires a long is lower or equals than")]
        public void RequiresLongIsLowerOrEqualsThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsLowerOrEqualsThan((long)0, (int)10, "Long")
                .IsLowerOrEqualsThan((long)0, (int)10, "Long", "Custom message here")
                .IsLowerOrEqualsThan((long)10, (int)10, "Long")
                .IsLowerOrEqualsThan((long)10, (int)10, "Long", "Custom message here")
                .IsLowerOrEqualsThan((long)20, (int)10, "Long")
                .IsLowerOrEqualsThan((long)20, (int)10, "Long", "Custom message here")

                .IsLowerOrEqualsThan((long)0, (float)10, "Long")
                .IsLowerOrEqualsThan((long)0, (float)10, "Long", "Custom message here")
                .IsLowerOrEqualsThan((long)10, (float)10, "Long")
                .IsLowerOrEqualsThan((long)10, (float)10, "Long", "Custom message here")
                .IsLowerOrEqualsThan((long)20, (float)10, "Long")
                .IsLowerOrEqualsThan((long)20, (float)10, "Long", "Custom message here")

                .IsLowerOrEqualsThan((long)0, (double)10, "Long")
                .IsLowerOrEqualsThan((long)0, (double)10, "Long", "Custom message here")
                .IsLowerOrEqualsThan((long)10, (double)10, "Long")
                .IsLowerOrEqualsThan((long)10, (double)10, "Long", "Custom message here")
                .IsLowerOrEqualsThan((long)20, (double)10, "Long")
                .IsLowerOrEqualsThan((long)20, (double)10, "Long", "Custom message here")

                .IsLowerOrEqualsThan((long)0, (long)10, "Long")
                .IsLowerOrEqualsThan((long)0, (long)10, "Long", "Custom message here")
                .IsLowerOrEqualsThan((long)10, (long)10, "Long")
                .IsLowerOrEqualsThan((long)10, (long)10, "Long", "Custom message here")
                .IsLowerOrEqualsThan((long)20, (long)10, "Long")
                .IsLowerOrEqualsThan((long)20, (long)10, "Long", "Custom message here")

                .IsLowerOrEqualsThan((long)0, (decimal)10, "Long")
                .IsLowerOrEqualsThan((long)0, (decimal)10, "Long", "Custom message here")
                .IsLowerOrEqualsThan((long)10, (decimal)10, "Long")
                .IsLowerOrEqualsThan((long)10, (decimal)10, "Long", "Custom message here")
                .IsLowerOrEqualsThan((long)20, (decimal)10, "Long")
                .IsLowerOrEqualsThan((long)20, (decimal)10, "Long", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 10);
        }

        [TestCategory("Long Validation")]
        [TestMethod("Requires a long has its min value")]
        public void RequireLongHasItsMinValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsMinValue(long.MaxValue, "Long")
                .IsMinValue(long.MaxValue, "Long", "Custom message here")
                .IsMinValue(long.MinValue, "Long")
                .IsMinValue(long.MinValue, "Long", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Long Validation")]
        [TestMethod("Requires a long has not its min value")]
        public void RequireLongHasNotItsMinValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotMinValue(long.MaxValue, "Long")
                .IsNotMinValue(long.MaxValue, "Long", "Custom message here")
                .IsNotMinValue(long.MinValue, "Long")
                .IsNotMinValue(long.MinValue, "Long", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Long Validation")]
        [TestMethod("Requires a long has its max value")]
        public void RequireLongHasItsMaxValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsMaxValue(long.MaxValue, "Long")
                .IsMaxValue(long.MaxValue, "Long", "Custom message here")
                .IsMaxValue(long.MinValue, "Long")
                .IsMaxValue(long.MinValue, "Long", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Long Validation")]
        [TestMethod("Requires a long has not its max value")]
        public void RequireLongHasNotItsMaxValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotMaxValue(long.MaxValue, "Long")
                .IsNotMaxValue(long.MaxValue, "Long", "Custom message here")
                .IsNotMaxValue(long.MinValue, "Long")
                .IsNotMaxValue(long.MinValue, "Long", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Long Validation")]
        [TestMethod("Requires two longs are equals")]
        public void RequireTwoLongsAreEquals()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .AreEquals((long)0, (int)0, "Long")
                .AreEquals((long)0, (int)0, "Long", "Custom message here")
                .AreEquals((long)0, (int)10, "Long")
                .AreEquals((long)0, (int)10, "Long", "Custom message here")

                .AreEquals((long)0, (float)0, "Long")
                .AreEquals((long)0, (float)0, "Long", "Custom message here")
                .AreEquals((long)0, (float)10, "Long")
                .AreEquals((long)0, (float)10, "Long", "Custom message here")

                .AreEquals((long)0, (double)0, "Long")
                .AreEquals((long)0, (double)0, "Long", "Custom message here")
                .AreEquals((long)0, (double)10, "Long")
                .AreEquals((long)0, (double)10, "Long", "Custom message here")

                .AreEquals((long)0, (long)0, "Long")
                .AreEquals((long)0, (long)0, "Long", "Custom message here")
                .AreEquals((long)0, (long)10, "Long")
                .AreEquals((long)0, (long)10, "Long", "Custom message here")

                .AreEquals((long)0, (decimal)0, "Long")
                .AreEquals((long)0, (decimal)0, "Long", "Custom message here")
                .AreEquals((long)0, (decimal)10, "Long")
                .AreEquals((long)0, (decimal)10, "Long", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 10);
        }

        [TestCategory("Long Validation")]
        [TestMethod("Requires two longs are not equals")]
        public void RequireTwoLongsAreNotEquals()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .AreNotEquals((long)0, (int)0, "Long")
                .AreNotEquals((long)0, (int)0, "Long", "Custom message here")
                .AreNotEquals((long)0, (int)10, "Long")
                .AreNotEquals((long)0, (int)10, "Long", "Custom message here")

                .AreNotEquals((long)0, (float)0, "Long")
                .AreNotEquals((long)0, (float)0, "Long", "Custom message here")
                .AreNotEquals((long)0, (float)10, "Long")
                .AreNotEquals((long)0, (float)10, "Long", "Custom message here")

                .AreNotEquals((long)0, (double)0, "Long")
                .AreNotEquals((long)0, (double)0, "Long", "Custom message here")
                .AreNotEquals((long)0, (double)10, "Long")
                .AreNotEquals((long)0, (double)10, "Long", "Custom message here")

                .AreNotEquals((long)0, (long)0, "Long")
                .AreNotEquals((long)0, (long)0, "Long", "Custom message here")
                .AreNotEquals((long)0, (long)10, "Long")
                .AreNotEquals((long)0, (long)10, "Long", "Custom message here")

                .AreNotEquals((long)0, (decimal)0, "Long")
                .AreNotEquals((long)0, (decimal)0, "Long", "Custom message here")
                .AreNotEquals((long)0, (decimal)10, "Long")
                .AreNotEquals((long)0, (decimal)10, "Long", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 10);
        }

        [TestCategory("Long Validation")]
        [TestMethod("Requires a long is null")]
        public void RequiresLongIsNull()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNull(_entity.LongNull, "Long")
                .IsNull(_entity.LongNull, "Long", "Custom message here")
                .IsNull(_entity.LongStart, "Long")
                .IsNull(_entity.LongStart, "Long", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Long Validation")]
        [TestMethod("Requires a long is not null")]
        public void RequiresLongIsNotNull()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotNull(_entity.LongNull, "Long")
                .IsNotNull(_entity.LongNull, "Long", "Custom message here")
                .IsNotNull(_entity.LongStart, "Long")
                .IsNotNull(_entity.LongStart, "Long", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Long Validation")]
        [TestMethod("Requires a long is between")]
        public void RequiresLongIsBetween()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsBetween(_entity.LongBetweenStartAndEnd, (int)_entity.LongStart, (int)_entity.LongEnd, "Long")
                .IsBetween(_entity.LongBetweenStartAndEnd, (int)_entity.LongStart, (int)_entity.LongEnd, "Long", "Custom message here")
                .IsBetween(_entity.LongStart, (int)_entity.LongStart, (int)_entity.LongEnd, "Long")
                .IsBetween(_entity.LongStart, (int)_entity.LongStart, (int)_entity.LongEnd, "Long", "Custom message here")
                .IsBetween(_entity.LongEnd, (int)_entity.LongStart, (int)_entity.LongEnd, "Long")
                .IsBetween(_entity.LongEnd, (int)_entity.LongStart, (int)_entity.LongEnd, "Long", "Custom message here")
                .IsBetween(_entity.LongNotBetweenStartAndEnd, (int)_entity.LongStart, (int)_entity.LongEnd, "Long")
                .IsBetween(_entity.LongNotBetweenStartAndEnd, (int)_entity.LongStart, (int)_entity.LongEnd, "Long", "Custom message here")

                .IsBetween(_entity.LongBetweenStartAndEnd, (double)_entity.LongStart, (double)_entity.LongEnd, "Long")
                .IsBetween(_entity.LongBetweenStartAndEnd, (double)_entity.LongStart, (double)_entity.LongEnd, "Long", "Custom message here")
                .IsBetween(_entity.LongStart, (double)_entity.LongStart, (double)_entity.LongEnd, "Long")
                .IsBetween(_entity.LongStart, (double)_entity.LongStart, (double)_entity.LongEnd, "Long", "Custom message here")
                .IsBetween(_entity.LongEnd, (double)_entity.LongStart, (double)_entity.LongEnd, "Long")
                .IsBetween(_entity.LongEnd, (double)_entity.LongStart, (double)_entity.LongEnd, "Long", "Custom message here")
                .IsBetween(_entity.LongNotBetweenStartAndEnd, (double)_entity.LongStart, (double)_entity.LongEnd, "Long")
                .IsBetween(_entity.LongNotBetweenStartAndEnd, (double)_entity.LongStart, (double)_entity.LongEnd, "Long", "Custom message here")

                .IsBetween(_entity.LongBetweenStartAndEnd, (float)_entity.LongStart, (float)_entity.LongEnd, "Long")
                .IsBetween(_entity.LongBetweenStartAndEnd, (float)_entity.LongStart, (float)_entity.LongEnd, "Long", "Custom message here")
                .IsBetween(_entity.LongStart, (float)_entity.LongStart, (float)_entity.LongEnd, "Long")
                .IsBetween(_entity.LongStart, (float)_entity.LongStart, (float)_entity.LongEnd, "Long", "Custom message here")
                .IsBetween(_entity.LongEnd, (float)_entity.LongStart, (float)_entity.LongEnd, "Long")
                .IsBetween(_entity.LongEnd, (float)_entity.LongStart, (float)_entity.LongEnd, "Long", "Custom message here")
                .IsBetween(_entity.LongNotBetweenStartAndEnd, (float)_entity.LongStart, (float)_entity.LongEnd, "Long")
                .IsBetween(_entity.LongNotBetweenStartAndEnd, (float)_entity.LongStart, (float)_entity.LongEnd, "Long", "Custom message here")

                .IsBetween(_entity.LongBetweenStartAndEnd, (long)_entity.LongStart, (long)_entity.LongEnd, "Long")
                .IsBetween(_entity.LongBetweenStartAndEnd, (long)_entity.LongStart, (long)_entity.LongEnd, "Long", "Custom message here")
                .IsBetween(_entity.LongStart, (long)_entity.LongStart, (long)_entity.LongEnd, "Long")
                .IsBetween(_entity.LongStart, (long)_entity.LongStart, (long)_entity.LongEnd, "Long", "Custom message here")
                .IsBetween(_entity.LongEnd, (long)_entity.LongStart, (long)_entity.LongEnd, "Long")
                .IsBetween(_entity.LongEnd, (long)_entity.LongStart, (long)_entity.LongEnd, "Long", "Custom message here")
                .IsBetween(_entity.LongNotBetweenStartAndEnd, (long)_entity.LongStart, (long)_entity.LongEnd, "Long")
                .IsBetween(_entity.LongNotBetweenStartAndEnd, (long)_entity.LongStart, (long)_entity.LongEnd, "Long", "Custom message here")

                .IsBetween(_entity.LongBetweenStartAndEnd, _entity.LongStart, _entity.LongEnd, "Long")
                .IsBetween(_entity.LongBetweenStartAndEnd, _entity.LongStart, _entity.LongEnd, "Long", "Custom message here")
                .IsBetween(_entity.LongStart, _entity.LongStart, _entity.LongEnd, "Long")
                .IsBetween(_entity.LongStart, _entity.LongStart, _entity.LongEnd, "Long", "Custom message here")
                .IsBetween(_entity.LongEnd, _entity.LongStart, _entity.LongEnd, "Long")
                .IsBetween(_entity.LongEnd, _entity.LongStart, _entity.LongEnd, "Long", "Custom message here")
                .IsBetween(_entity.LongNotBetweenStartAndEnd, _entity.LongStart, _entity.LongEnd, "Long")
                .IsBetween(_entity.LongNotBetweenStartAndEnd, _entity.LongStart, _entity.LongEnd, "Long", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 10);
        }

        [TestCategory("Long Validation")]
        [TestMethod("Requires a long is not between")]
        public void RequiresLongIsNotBetween()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotBetween(_entity.LongBetweenStartAndEnd, (int)_entity.LongStart, (int)_entity.LongEnd, "Long")
                .IsNotBetween(_entity.LongBetweenStartAndEnd, (int)_entity.LongStart, (int)_entity.LongEnd, "Long", "Custom message here")
                .IsNotBetween(_entity.LongStart, (int)_entity.LongStart, (int)_entity.LongEnd, "Long")
                .IsNotBetween(_entity.LongStart, (int)_entity.LongStart, (int)_entity.LongEnd, "Long", "Custom message here")
                .IsNotBetween(_entity.LongEnd, (int)_entity.LongStart, (int)_entity.LongEnd, "Long")
                .IsNotBetween(_entity.LongEnd, (int)_entity.LongStart, (int)_entity.LongEnd, "Long", "Custom message here")
                .IsNotBetween(_entity.LongNotBetweenStartAndEnd, (int)_entity.LongStart, (int)_entity.LongEnd, "Long")
                .IsNotBetween(_entity.LongNotBetweenStartAndEnd, (int)_entity.LongStart, (int)_entity.LongEnd, "Long", "Custom message here")

                .IsNotBetween(_entity.LongBetweenStartAndEnd, (double)_entity.LongStart, (double)_entity.LongEnd, "Long")
                .IsNotBetween(_entity.LongBetweenStartAndEnd, (double)_entity.LongStart, (double)_entity.LongEnd, "Long", "Custom message here")
                .IsNotBetween(_entity.LongStart, (double)_entity.LongStart, (double)_entity.LongEnd, "Long")
                .IsNotBetween(_entity.LongStart, (double)_entity.LongStart, (double)_entity.LongEnd, "Long", "Custom message here")
                .IsNotBetween(_entity.LongEnd, (double)_entity.LongStart, (double)_entity.LongEnd, "Long")
                .IsNotBetween(_entity.LongEnd, (double)_entity.LongStart, (double)_entity.LongEnd, "Long", "Custom message here")
                .IsNotBetween(_entity.LongNotBetweenStartAndEnd, (double)_entity.LongStart, (double)_entity.LongEnd, "Long")
                .IsNotBetween(_entity.LongNotBetweenStartAndEnd, (double)_entity.LongStart, (double)_entity.LongEnd, "Long", "Custom message here")

                .IsNotBetween(_entity.LongBetweenStartAndEnd, (float)_entity.LongStart, (float)_entity.LongEnd, "Long")
                .IsNotBetween(_entity.LongBetweenStartAndEnd, (float)_entity.LongStart, (float)_entity.LongEnd, "Long", "Custom message here")
                .IsNotBetween(_entity.LongStart, (float)_entity.LongStart, (float)_entity.LongEnd, "Long")
                .IsNotBetween(_entity.LongStart, (float)_entity.LongStart, (float)_entity.LongEnd, "Long", "Custom message here")
                .IsNotBetween(_entity.LongEnd, (float)_entity.LongStart, (float)_entity.LongEnd, "Long")
                .IsNotBetween(_entity.LongEnd, (float)_entity.LongStart, (float)_entity.LongEnd, "Long", "Custom message here")
                .IsNotBetween(_entity.LongNotBetweenStartAndEnd, (float)_entity.LongStart, (float)_entity.LongEnd, "Long")
                .IsNotBetween(_entity.LongNotBetweenStartAndEnd, (float)_entity.LongStart, (float)_entity.LongEnd, "Long", "Custom message here")

                .IsNotBetween(_entity.LongBetweenStartAndEnd, (long)_entity.LongStart, (long)_entity.LongEnd, "Long")
                .IsNotBetween(_entity.LongBetweenStartAndEnd, (long)_entity.LongStart, (long)_entity.LongEnd, "Long", "Custom message here")
                .IsNotBetween(_entity.LongStart, (long)_entity.LongStart, (long)_entity.LongEnd, "Long")
                .IsNotBetween(_entity.LongStart, (long)_entity.LongStart, (long)_entity.LongEnd, "Long", "Custom message here")
                .IsNotBetween(_entity.LongEnd, (long)_entity.LongStart, (long)_entity.LongEnd, "Long")
                .IsNotBetween(_entity.LongEnd, (long)_entity.LongStart, (long)_entity.LongEnd, "Long", "Custom message here")
                .IsNotBetween(_entity.LongNotBetweenStartAndEnd, (long)_entity.LongStart, (long)_entity.LongEnd, "Long")
                .IsNotBetween(_entity.LongNotBetweenStartAndEnd, (long)_entity.LongStart, (long)_entity.LongEnd, "Long", "Custom message here")

                .IsNotBetween(_entity.LongBetweenStartAndEnd, _entity.LongStart, _entity.LongEnd, "Long")
                .IsNotBetween(_entity.LongBetweenStartAndEnd, _entity.LongStart, _entity.LongEnd, "Long", "Custom message here")
                .IsNotBetween(_entity.LongStart, _entity.LongStart, _entity.LongEnd, "Long")
                .IsNotBetween(_entity.LongStart, _entity.LongStart, _entity.LongEnd, "Long", "Custom message here")
                .IsNotBetween(_entity.LongEnd, _entity.LongStart, _entity.LongEnd, "Long")
                .IsNotBetween(_entity.LongEnd, _entity.LongStart, _entity.LongEnd, "Long", "Custom message here")
                .IsNotBetween(_entity.LongNotBetweenStartAndEnd, _entity.LongStart, _entity.LongEnd, "Long")
                .IsNotBetween(_entity.LongNotBetweenStartAndEnd, _entity.LongStart, _entity.LongEnd, "Long", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 30);
        }

        [TestCategory("Long Validation")]
        [TestMethod("Requires a list contains a long")]
        public void RequiresListContainsLong()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .Contains((long)1, _entity.LongList, "Long")
                .Contains((long)1, _entity.LongList, "Long", "Custom message here")
                .Contains((long)3, _entity.LongList, "Long")
                .Contains((long)3, _entity.LongList, "Long", "Custom message here")
                .Contains((long)5, _entity.LongList, "Long")
                .Contains((long)5, _entity.LongList, "Long", "Custom message here")
                .Contains((long)7, _entity.LongList, "Long")
                .Contains((long)7, _entity.LongList, "Long", "Custom message here")
                .Contains((long)9, _entity.LongList, "Long")
                .Contains((long)9, _entity.LongList, "Long", "Custom message here")
                .Contains((long)11, _entity.LongList, "Long")
                .Contains((long)11, _entity.LongList, "Long", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Long Validation")]
        [TestMethod("Requires a list does not contains a long")]
        public void RequiresListNotContainsDouble()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .NotContains((long)1, _entity.LongList, "Long")
                .NotContains((long)1, _entity.LongList, "Long", "Custom message here")
                .NotContains((long)3, _entity.LongList, "Long")
                .NotContains((long)3, _entity.LongList, "Long", "Custom message here")
                .NotContains((long)5, _entity.LongList, "Long")
                .NotContains((long)5, _entity.LongList, "Long", "Custom message here")
                .NotContains((long)7, _entity.LongList, "Long")
                .NotContains((long)7, _entity.LongList, "Long", "Custom message here")
                .NotContains((long)9, _entity.LongList, "Long")
                .NotContains((long)9, _entity.LongList, "Long", "Custom message here")
                .NotContains((long)11, _entity.LongList, "Long")
                .NotContains((long)11, _entity.LongList, "Long", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 10);
        }
    }
}
