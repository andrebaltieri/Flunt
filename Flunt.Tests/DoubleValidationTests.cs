using Flunt.Tests.Entities;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class DoubleValidationTests
    {
        private readonly SampleEntity _entity = new SampleEntity();

        [TestCategory("Double Validation")]
        [TestMethod("Requires a double is greater than")]
        public void RequiresDoubleIsGreaterThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsGreaterThan((double)0, (int)10, "Double")
                .IsGreaterThan((double)0, (int)10, "Double", "Custom message here")
                .IsGreaterThan((double)10, (int)10, "Double")
                .IsGreaterThan((double)10, (int)10, "Double", "Custom message here")
                .IsGreaterThan((double)20, (int)10, "Double")
                .IsGreaterThan((double)20, (int)10, "Double", "Custom message here")

                .IsGreaterThan((double)0, (float)10, "Double")
                .IsGreaterThan((double)0, (float)10, "Double", "Custom message here")
                .IsGreaterThan((double)10, (float)10, "Double")
                .IsGreaterThan((double)10, (float)10, "Double", "Custom message here")
                .IsGreaterThan((double)20, (float)10, "Double")
                .IsGreaterThan((double)20, (float)10, "Double", "Custom message here")

                .IsGreaterThan((double)0, (double)10, "Double")
                .IsGreaterThan((double)0, (double)10, "Double", "Custom message here")
                .IsGreaterThan((double)10, (double)10, "Double")
                .IsGreaterThan((double)10, (double)10, "Double", "Custom message here")
                .IsGreaterThan((double)20, (double)10, "Double")
                .IsGreaterThan((double)20, (double)10, "Double", "Custom message here")

                .IsGreaterThan((double)0, (decimal)10, "Double")
                .IsGreaterThan((double)0, (decimal)10, "Double", "Custom message here")
                .IsGreaterThan((double)10, (decimal)10, "Double")
                .IsGreaterThan((double)10, (decimal)10, "Double", "Custom message here")
                .IsGreaterThan((double)20, (decimal)10, "Double")
                .IsGreaterThan((double)20, (decimal)10, "Double", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 16);
        }

        [TestCategory("Double Validation")]
        [TestMethod("Requires a double is greater or equals than")]
        public void RequiresDoubleIsGreaterOrEqualsThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsGreaterOrEqualsThan((double)0, (int)10, "Double")
                .IsGreaterOrEqualsThan((double)0, (int)10, "Double", "Custom message here")
                .IsGreaterOrEqualsThan((double)10, (int)10, "Double")
                .IsGreaterOrEqualsThan((double)10, (int)10, "Double", "Custom message here")
                .IsGreaterOrEqualsThan((double)20, (int)10, "Double")
                .IsGreaterOrEqualsThan((double)20, (int)10, "Double", "Custom message here")

                .IsGreaterOrEqualsThan((double)0, (float)10, "Double")
                .IsGreaterOrEqualsThan((double)0, (float)10, "Double", "Custom message here")
                .IsGreaterOrEqualsThan((double)10, (float)10, "Double")
                .IsGreaterOrEqualsThan((double)10, (float)10, "Double", "Custom message here")
                .IsGreaterOrEqualsThan((double)20, (float)10, "Double")
                .IsGreaterOrEqualsThan((double)20, (float)10, "Double", "Custom message here")

                .IsGreaterOrEqualsThan((double)0, (double)10, "Double")
                .IsGreaterOrEqualsThan((double)0, (double)10, "Double", "Custom message here")
                .IsGreaterOrEqualsThan((double)10, (double)10, "Double")
                .IsGreaterOrEqualsThan((double)10, (double)10, "Double", "Custom message here")
                .IsGreaterOrEqualsThan((double)20, (double)10, "Double")
                .IsGreaterOrEqualsThan((double)20, (double)10, "Double", "Custom message here")

                .IsGreaterOrEqualsThan((double)0, (decimal)10, "Double")
                .IsGreaterOrEqualsThan((double)0, (decimal)10, "Double", "Custom message here")
                .IsGreaterOrEqualsThan((double)10, (decimal)10, "Double")
                .IsGreaterOrEqualsThan((double)10, (decimal)10, "Double", "Custom message here")
                .IsGreaterOrEqualsThan((double)20, (decimal)10, "Double")
                .IsGreaterOrEqualsThan((double)20, (decimal)10, "Double", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Double Validation")]
        [TestMethod("Requires a double is lower than")]
        public void RequiresDoubleIsLowerThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsLowerThan((double)0, (int)0, "Double")
                .IsLowerThan((double)0, (int)0, "Double", "Custom message here")
                .IsLowerThan((double)-5, (int)0, "Double")
                .IsLowerThan((double)-5, (int)0, "Double", "Custom message here")
                .IsLowerThan((double)5, (int)0, "Double")
                .IsLowerThan((double)5, (int)0, "Double", "Custom message here")

                .IsLowerThan((double)0, (float)0, "Double")
                .IsLowerThan((double)0, (float)0, "Double", "Custom message here")
                .IsLowerThan((double)-5, (float)0, "Double")
                .IsLowerThan((double)-5, (float)0, "Double", "Custom message here")
                .IsLowerThan((double)5, (float)0, "Double")
                .IsLowerThan((double)5, (float)0, "Double", "Custom message here")

                .IsLowerThan((double)0, (double)0, "Double")
                .IsLowerThan((double)0, (double)0, "Double", "Custom message here")
                .IsLowerThan((double)-5, (double)0, "Double")
                .IsLowerThan((double)-5, (double)0, "Double", "Custom message here")
                .IsLowerThan((double)5, (double)0, "Double")
                .IsLowerThan((double)5, (double)0, "Double", "Custom message here")

                .IsLowerThan((double)0, (decimal)0, "Double")
                .IsLowerThan((double)0, (decimal)0, "Double", "Custom message here")
                .IsLowerThan((double)-5, (decimal)0, "Double")
                .IsLowerThan((double)-5, (decimal)0, "Double", "Custom message here")
                .IsLowerThan((double)5, (decimal)0, "Double")
                .IsLowerThan((double)5, (decimal)0, "Double", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 16);
        }

        [TestCategory("Double Validation")]
        [TestMethod("Requires a double is lower or equals than")]
        public void RequiresDoubleIsLowerOrEqualsThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsLowerOrEqualsThan((double)0, (int)10, "Double")
                .IsLowerOrEqualsThan((double)0, (int)10, "Double", "Custom message here")
                .IsLowerOrEqualsThan((double)10, (int)10, "Double")
                .IsLowerOrEqualsThan((double)10, (int)10, "Double", "Custom message here")
                .IsLowerOrEqualsThan((double)20, (int)10, "Double")
                .IsLowerOrEqualsThan((double)20, (int)10, "Double", "Custom message here")

                .IsLowerOrEqualsThan((double)0, (float)10, "Double")
                .IsLowerOrEqualsThan((double)0, (float)10, "Double", "Custom message here")
                .IsLowerOrEqualsThan((double)10, (float)10, "Double")
                .IsLowerOrEqualsThan((double)10, (float)10, "Double", "Custom message here")
                .IsLowerOrEqualsThan((double)20, (float)10, "Double")
                .IsLowerOrEqualsThan((double)20, (float)10, "Double", "Custom message here")

                .IsLowerOrEqualsThan((double)0, (double)10, "Double")
                .IsLowerOrEqualsThan((double)0, (double)10, "Double", "Custom message here")
                .IsLowerOrEqualsThan((double)10, (double)10, "Double")
                .IsLowerOrEqualsThan((double)10, (double)10, "Double", "Custom message here")
                .IsLowerOrEqualsThan((double)20, (double)10, "Double")
                .IsLowerOrEqualsThan((double)20, (double)10, "Double", "Custom message here")

                .IsLowerOrEqualsThan((double)0, (decimal)10, "Double")
                .IsLowerOrEqualsThan((double)0, (decimal)10, "Double", "Custom message here")
                .IsLowerOrEqualsThan((double)10, (decimal)10, "Double")
                .IsLowerOrEqualsThan((double)10, (decimal)10, "Double", "Custom message here")
                .IsLowerOrEqualsThan((double)20, (decimal)10, "Double")
                .IsLowerOrEqualsThan((double)20, (decimal)10, "Double", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Double Validation")]
        [TestMethod("Requires a double has its min value")]
        public void RequireDoubleHasItsMinValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsMinValue(double.MaxValue, "Double")
                .IsMinValue(double.MaxValue, "Double", "Custom message here")
                .IsMinValue(double.MinValue, "Double")
                .IsMinValue(double.MinValue, "Double", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Double Validation")]
        [TestMethod("Requires a double has not its min value")]
        public void RequireDoubleHasNotItsMinValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotMinValue(double.MaxValue, "Double")
                .IsNotMinValue(double.MaxValue, "Double", "Custom message here")
                .IsNotMinValue(double.MinValue, "Double")
                .IsNotMinValue(double.MinValue, "Double", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Double Validation")]
        [TestMethod("Requires a double has its max value")]
        public void RequireDoubleHasItsMaxValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsMaxValue(double.MaxValue, "Double")
                .IsMaxValue(double.MaxValue, "Double", "Custom message here")
                .IsMaxValue(double.MinValue, "Double")
                .IsMaxValue(double.MinValue, "Double", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Double Validation")]
        [TestMethod("Requires a double has not its max value")]
        public void RequireDoubleHasNotItsMaxValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotMaxValue(double.MaxValue, "Double")
                .IsNotMaxValue(double.MaxValue, "Double", "Custom message here")
                .IsNotMaxValue(double.MinValue, "Double")
                .IsNotMaxValue(double.MinValue, "Double", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Double Validation")]
        [TestMethod("Requires two doubles are equals")]
        public void RequireTwoDoublesAreEquals()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .AreEquals((double)0, (int)0, "Double")
                .AreEquals((double)0, (int)0, "Double", "Custom message here")
                .AreEquals((double)0, (int)10, "Double")
                .AreEquals((double)0, (int)10, "Double", "Custom message here")

                .AreEquals((double)0, (float)0, "Double")
                .AreEquals((double)0, (float)0, "Double", "Custom message here")
                .AreEquals((double)0, (float)10, "Double")
                .AreEquals((double)0, (float)10, "Double", "Custom message here")

                .AreEquals((double)0, (double)0, "Double")
                .AreEquals((double)0, (double)0, "Double", "Custom message here")
                .AreEquals((double)0, (double)10, "Double")
                .AreEquals((double)0, (double)10, "Double", "Custom message here")

                .AreEquals((double)0, (decimal)0, "Double")
                .AreEquals((double)0, (decimal)0, "Double", "Custom message here")
                .AreEquals((double)0, (decimal)10, "Double")
                .AreEquals((double)0, (decimal)10, "Double", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Double Validation")]
        [TestMethod("Requires two doubles are not equals")]
        public void RequireTwoDoublesAreNotEquals()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .AreNotEquals((double)0, (int)0, "Double")
                .AreNotEquals((double)0, (int)0, "Double", "Custom message here")
                .AreNotEquals((double)0, (int)10, "Double")
                .AreNotEquals((double)0, (int)10, "Double", "Custom message here")

                .AreNotEquals((double)0, (float)0, "Double")
                .AreNotEquals((double)0, (float)0, "Double", "Custom message here")
                .AreNotEquals((double)0, (float)10, "Double")
                .AreNotEquals((double)0, (float)10, "Double", "Custom message here")

                .AreNotEquals((double)0, (double)0, "Double")
                .AreNotEquals((double)0, (double)0, "Double", "Custom message here")
                .AreNotEquals((double)0, (double)10, "Double")
                .AreNotEquals((double)0, (double)10, "Double", "Custom message here")

                .AreNotEquals((double)0, (decimal)0, "Double")
                .AreNotEquals((double)0, (decimal)0, "Double", "Custom message here")
                .AreNotEquals((double)0, (decimal)10, "Double")
                .AreNotEquals((double)0, (decimal)10, "Double", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Double Validation")]
        [TestMethod("Requires a double is null")]
        public void RequiresDoubleIsNull()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNull(_entity.DoubleNull, "Double")
                .IsNull(_entity.DoubleNull, "Double", "Custom message here")
                .IsNull(_entity.DoubleStart, "Double")
                .IsNull(_entity.DoubleStart, "Double", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Double Validation")]
        [TestMethod("Requires a double is not null")]
        public void RequiresDoubleIsNotNull()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotNull(_entity.DoubleNull, "Double")
                .IsNotNull(_entity.DoubleNull, "Double", "Custom message here")
                .IsNotNull(_entity.DoubleStart, "Double")
                .IsNotNull(_entity.DoubleStart, "Double", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Double Validation")]
        [TestMethod("Requires a double is between")]
        public void RequiresDoubleIsBetween()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsBetween(_entity.DoubleBetweenStartAndEnd, (int)_entity.DoubleStart, (int)_entity.DoubleEnd, "Double")
                .IsBetween(_entity.DoubleBetweenStartAndEnd, (int)_entity.DoubleStart, (int)_entity.DoubleEnd, "Double", "Custom message here")
                .IsBetween(_entity.DoubleStart, (int)_entity.DoubleStart, (int)_entity.DoubleEnd, "Double")
                .IsBetween(_entity.DoubleStart, (int)_entity.DoubleStart, (int)_entity.DoubleEnd, "Double", "Custom message here")
                .IsBetween(_entity.DoubleEnd, (int)_entity.DoubleStart, (int)_entity.DoubleEnd, "Double")
                .IsBetween(_entity.DoubleEnd, (int)_entity.DoubleStart, (int)_entity.DoubleEnd, "Double", "Custom message here")
                .IsBetween(_entity.DoubleNotBetweenStartAndEnd, (int)_entity.DoubleStart, (int)_entity.DoubleEnd, "Double")
                .IsBetween(_entity.DoubleNotBetweenStartAndEnd, (int)_entity.DoubleStart, (int)_entity.DoubleEnd, "Double", "Custom message here")

                .IsBetween(_entity.DoubleBetweenStartAndEnd, (double)_entity.DoubleStart, (double)_entity.DoubleEnd, "Double")
                .IsBetween(_entity.DoubleBetweenStartAndEnd, (double)_entity.DoubleStart, (double)_entity.DoubleEnd, "Double", "Custom message here")
                .IsBetween(_entity.DoubleStart, (double)_entity.DoubleStart, (double)_entity.DoubleEnd, "Double")
                .IsBetween(_entity.DoubleStart, (double)_entity.DoubleStart, (double)_entity.DoubleEnd, "Double", "Custom message here")
                .IsBetween(_entity.DoubleEnd, (double)_entity.DoubleStart, (double)_entity.DoubleEnd, "Double")
                .IsBetween(_entity.DoubleEnd, (double)_entity.DoubleStart, (double)_entity.DoubleEnd, "Double", "Custom message here")
                .IsBetween(_entity.DoubleNotBetweenStartAndEnd, (double)_entity.DoubleStart, (double)_entity.DoubleEnd, "Double")
                .IsBetween(_entity.DoubleNotBetweenStartAndEnd, (double)_entity.DoubleStart, (double)_entity.DoubleEnd, "Double", "Custom message here")

                .IsBetween(_entity.DoubleBetweenStartAndEnd, (float)_entity.DoubleStart, (float)_entity.DoubleEnd, "Double")
                .IsBetween(_entity.DoubleBetweenStartAndEnd, (float)_entity.DoubleStart, (float)_entity.DoubleEnd, "Double", "Custom message here")
                .IsBetween(_entity.DoubleStart, (float)_entity.DoubleStart, (float)_entity.DoubleEnd, "Double")
                .IsBetween(_entity.DoubleStart, (float)_entity.DoubleStart, (float)_entity.DoubleEnd, "Double", "Custom message here")
                .IsBetween(_entity.DoubleEnd, (float)_entity.DoubleStart, (float)_entity.DoubleEnd, "Double")
                .IsBetween(_entity.DoubleEnd, (float)_entity.DoubleStart, (float)_entity.DoubleEnd, "Double", "Custom message here")
                .IsBetween(_entity.DoubleNotBetweenStartAndEnd, (float)_entity.DoubleStart, (float)_entity.DoubleEnd, "Double")
                .IsBetween(_entity.DoubleNotBetweenStartAndEnd, (float)_entity.DoubleStart, (float)_entity.DoubleEnd, "Double", "Custom message here")

                .IsBetween(_entity.DoubleBetweenStartAndEnd, _entity.DoubleStart, _entity.DoubleEnd, "Double")
                .IsBetween(_entity.DoubleBetweenStartAndEnd, _entity.DoubleStart, _entity.DoubleEnd, "Double", "Custom message here")
                .IsBetween(_entity.DoubleStart, _entity.DoubleStart, _entity.DoubleEnd, "Double")
                .IsBetween(_entity.DoubleStart, _entity.DoubleStart, _entity.DoubleEnd, "Double", "Custom message here")
                .IsBetween(_entity.DoubleEnd, _entity.DoubleStart, _entity.DoubleEnd, "Double")
                .IsBetween(_entity.DoubleEnd, _entity.DoubleStart, _entity.DoubleEnd, "Double", "Custom message here")
                .IsBetween(_entity.DoubleNotBetweenStartAndEnd, _entity.DoubleStart, _entity.DoubleEnd, "Double")
                .IsBetween(_entity.DoubleNotBetweenStartAndEnd, _entity.DoubleStart, _entity.DoubleEnd, "Double", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Double Validation")]
        [TestMethod("Requires a double is not between")]
        public void RequiresDoubleIsNotBetween()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotBetween(_entity.DoubleBetweenStartAndEnd, (int)_entity.DoubleStart, (int)_entity.DoubleEnd, "Double")
                .IsNotBetween(_entity.DoubleBetweenStartAndEnd, (int)_entity.DoubleStart, (int)_entity.DoubleEnd, "Double", "Custom message here")
                .IsNotBetween(_entity.DoubleStart, (int)_entity.DoubleStart, (int)_entity.DoubleEnd, "Double")
                .IsNotBetween(_entity.DoubleStart, (int)_entity.DoubleStart, (int)_entity.DoubleEnd, "Double", "Custom message here")
                .IsNotBetween(_entity.DoubleEnd, (int)_entity.DoubleStart, (int)_entity.DoubleEnd, "Double")
                .IsNotBetween(_entity.DoubleEnd, (int)_entity.DoubleStart, (int)_entity.DoubleEnd, "Double", "Custom message here")
                .IsNotBetween(_entity.DoubleNotBetweenStartAndEnd, (int)_entity.DoubleStart, (int)_entity.DoubleEnd, "Double")
                .IsNotBetween(_entity.DoubleNotBetweenStartAndEnd, (int)_entity.DoubleStart, (int)_entity.DoubleEnd, "Double", "Custom message here")

                .IsNotBetween(_entity.DoubleBetweenStartAndEnd, (double)_entity.DoubleStart, (double)_entity.DoubleEnd, "Double")
                .IsNotBetween(_entity.DoubleBetweenStartAndEnd, (double)_entity.DoubleStart, (double)_entity.DoubleEnd, "Double", "Custom message here")
                .IsNotBetween(_entity.DoubleStart, (double)_entity.DoubleStart, (double)_entity.DoubleEnd, "Double")
                .IsNotBetween(_entity.DoubleStart, (double)_entity.DoubleStart, (double)_entity.DoubleEnd, "Double", "Custom message here")
                .IsNotBetween(_entity.DoubleEnd, (double)_entity.DoubleStart, (double)_entity.DoubleEnd, "Double")
                .IsNotBetween(_entity.DoubleEnd, (double)_entity.DoubleStart, (double)_entity.DoubleEnd, "Double", "Custom message here")
                .IsNotBetween(_entity.DoubleNotBetweenStartAndEnd, (double)_entity.DoubleStart, (double)_entity.DoubleEnd, "Double")
                .IsNotBetween(_entity.DoubleNotBetweenStartAndEnd, (double)_entity.DoubleStart, (double)_entity.DoubleEnd, "Double", "Custom message here")

                .IsNotBetween(_entity.DoubleBetweenStartAndEnd, (float)_entity.DoubleStart, (float)_entity.DoubleEnd, "Double")
                .IsNotBetween(_entity.DoubleBetweenStartAndEnd, (float)_entity.DoubleStart, (float)_entity.DoubleEnd, "Double", "Custom message here")
                .IsNotBetween(_entity.DoubleStart, (float)_entity.DoubleStart, (float)_entity.DoubleEnd, "Double")
                .IsNotBetween(_entity.DoubleStart, (float)_entity.DoubleStart, (float)_entity.DoubleEnd, "Double", "Custom message here")
                .IsNotBetween(_entity.DoubleEnd, (float)_entity.DoubleStart, (float)_entity.DoubleEnd, "Double")
                .IsNotBetween(_entity.DoubleEnd, (float)_entity.DoubleStart, (float)_entity.DoubleEnd, "Double", "Custom message here")
                .IsNotBetween(_entity.DoubleNotBetweenStartAndEnd, (float)_entity.DoubleStart, (float)_entity.DoubleEnd, "Double")
                .IsNotBetween(_entity.DoubleNotBetweenStartAndEnd, (float)_entity.DoubleStart, (float)_entity.DoubleEnd, "Double", "Custom message here")

                .IsNotBetween(_entity.DoubleBetweenStartAndEnd, _entity.DoubleStart, _entity.DoubleEnd, "Double")
                .IsNotBetween(_entity.DoubleBetweenStartAndEnd, _entity.DoubleStart, _entity.DoubleEnd, "Double", "Custom message here")
                .IsNotBetween(_entity.DoubleStart, _entity.DoubleStart, _entity.DoubleEnd, "Double")
                .IsNotBetween(_entity.DoubleStart, _entity.DoubleStart, _entity.DoubleEnd, "Double", "Custom message here")
                .IsNotBetween(_entity.DoubleEnd, _entity.DoubleStart, _entity.DoubleEnd, "Double")
                .IsNotBetween(_entity.DoubleEnd, _entity.DoubleStart, _entity.DoubleEnd, "Double", "Custom message here")
                .IsNotBetween(_entity.DoubleNotBetweenStartAndEnd, _entity.DoubleStart, _entity.DoubleEnd, "Double")
                .IsNotBetween(_entity.DoubleNotBetweenStartAndEnd, _entity.DoubleStart, _entity.DoubleEnd, "Double", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 24);
        }

        [TestCategory("Double Validation")]
        [TestMethod("Requires a list contains a double")]
        public void RequiresListContainsDouble()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .Contains((double)1, _entity.DoubleList, "Double")
                .Contains((double)1, _entity.DoubleList, "Double", "Custom message here")
                .Contains((double)3, _entity.DoubleList, "Double")
                .Contains((double)3, _entity.DoubleList, "Double", "Custom message here")
                .Contains((double)5, _entity.DoubleList, "Double")
                .Contains((double)5, _entity.DoubleList, "Double", "Custom message here")
                .Contains((double)7, _entity.DoubleList, "Double")
                .Contains((double)7, _entity.DoubleList, "Double", "Custom message here")
                .Contains((double)9, _entity.DoubleList, "Double")
                .Contains((double)9, _entity.DoubleList, "Double", "Custom message here")
                .Contains((double)11, _entity.DoubleList, "Double")
                .Contains((double)11, _entity.DoubleList, "Double", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Double Validation")]
        [TestMethod("Requires a list does not contains a double")]
        public void RequiresListNotContainsDouble()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .NotContains((double)1, _entity.DoubleList, "Double")
                .NotContains((double)1, _entity.DoubleList, "Double", "Custom message here")
                .NotContains((double)3, _entity.DoubleList, "Double")
                .NotContains((double)3, _entity.DoubleList, "Double", "Custom message here")
                .NotContains((double)5, _entity.DoubleList, "Double")
                .NotContains((double)5, _entity.DoubleList, "Double", "Custom message here")
                .NotContains((double)7, _entity.DoubleList, "Double")
                .NotContains((double)7, _entity.DoubleList, "Double", "Custom message here")
                .NotContains((double)9, _entity.DoubleList, "Double")
                .NotContains((double)9, _entity.DoubleList, "Double", "Custom message here")
                .NotContains((double)11, _entity.DoubleList, "Double")
                .NotContains((double)11, _entity.DoubleList, "Double", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 10);
        }
    }
}
