using Flunt.Tests.Entities;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class DecimalValidationTests
    {
        private readonly SampleEntity _entity = new SampleEntity();

        [TestCategory("Decimal Validation")]
        [TestMethod("Requires a decimal is greater than")]
        public void RequiresDecimalIsGreaterThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsGreaterThan((decimal)0, (int)10, "Decimal")
                .IsGreaterThan((decimal)0, (int)10, "Decimal", "Custom message here")
                .IsGreaterThan((decimal)10, (int)10, "Decimal")
                .IsGreaterThan((decimal)10, (int)10, "Decimal", "Custom message here")
                .IsGreaterThan((decimal)20, (int)10, "Decimal")
                .IsGreaterThan((decimal)20, (int)10, "Decimal", "Custom message here")

                .IsGreaterThan((decimal)0, (float)10, "Decimal")
                .IsGreaterThan((decimal)0, (float)10, "Decimal", "Custom message here")
                .IsGreaterThan((decimal)10, (float)10, "Decimal")
                .IsGreaterThan((decimal)10, (float)10, "Decimal", "Custom message here")
                .IsGreaterThan((decimal)20, (float)10, "Decimal")
                .IsGreaterThan((decimal)20, (float)10, "Decimal", "Custom message here")

                .IsGreaterThan((decimal)0, (double)10, "Decimal")
                .IsGreaterThan((decimal)0, (double)10, "Decimal", "Custom message here")
                .IsGreaterThan((decimal)10, (double)10, "Decimal")
                .IsGreaterThan((decimal)10, (double)10, "Decimal", "Custom message here")
                .IsGreaterThan((decimal)20, (double)10, "Decimal")
                .IsGreaterThan((decimal)20, (double)10, "Decimal", "Custom message here")

                .IsGreaterThan((decimal)0, (decimal)10, "Decimal")
                .IsGreaterThan((decimal)0, (decimal)10, "Decimal", "Custom message here")
                .IsGreaterThan((decimal)10, (decimal)10, "Decimal")
                .IsGreaterThan((decimal)10, (decimal)10, "Decimal", "Custom message here")
                .IsGreaterThan((decimal)20, (decimal)10, "Decimal")
                .IsGreaterThan((decimal)20, (decimal)10, "Decimal", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 16);
        }

        [TestCategory("Decimal Validation")]
        [TestMethod("Requires a decimal is greater or equals than")]
        public void RequiresDecimalIsGreaterOrEqualsThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsGreaterOrEqualsThan((decimal)0, (int)10, "Decimal")
                .IsGreaterOrEqualsThan((decimal)0, (int)10, "Decimal", "Custom message here")
                .IsGreaterOrEqualsThan((decimal)10, (int)10, "Decimal")
                .IsGreaterOrEqualsThan((decimal)10, (int)10, "Decimal", "Custom message here")
                .IsGreaterOrEqualsThan((decimal)20, (int)10, "Decimal")
                .IsGreaterOrEqualsThan((decimal)20, (int)10, "Decimal", "Custom message here")

                .IsGreaterOrEqualsThan((decimal)0, (float)10, "Decimal")
                .IsGreaterOrEqualsThan((decimal)0, (float)10, "Decimal", "Custom message here")
                .IsGreaterOrEqualsThan((decimal)10, (float)10, "Decimal")
                .IsGreaterOrEqualsThan((decimal)10, (float)10, "Decimal", "Custom message here")
                .IsGreaterOrEqualsThan((decimal)20, (float)10, "Decimal")
                .IsGreaterOrEqualsThan((decimal)20, (float)10, "Decimal", "Custom message here")

                .IsGreaterOrEqualsThan((decimal)0, (double)10, "Decimal")
                .IsGreaterOrEqualsThan((decimal)0, (double)10, "Decimal", "Custom message here")
                .IsGreaterOrEqualsThan((decimal)10, (double)10, "Decimal")
                .IsGreaterOrEqualsThan((decimal)10, (double)10, "Decimal", "Custom message here")
                .IsGreaterOrEqualsThan((decimal)20, (double)10, "Decimal")
                .IsGreaterOrEqualsThan((decimal)20, (double)10, "Decimal", "Custom message here")

                .IsGreaterOrEqualsThan((decimal)0, (decimal)10, "Decimal")
                .IsGreaterOrEqualsThan((decimal)0, (decimal)10, "Decimal", "Custom message here")
                .IsGreaterOrEqualsThan((decimal)10, (decimal)10, "Decimal")
                .IsGreaterOrEqualsThan((decimal)10, (decimal)10, "Decimal", "Custom message here")
                .IsGreaterOrEqualsThan((decimal)20, (decimal)10, "Decimal")
                .IsGreaterOrEqualsThan((decimal)20, (decimal)10, "Decimal", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Decimal Validation")]
        [TestMethod("Requires a decimal is lower than")]
        public void RequiresDecimalIsLowerThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsLowerThan((decimal)0, (int)0, "Decimal")
                .IsLowerThan((decimal)0, (int)0, "Decimal", "Custom message here")
                .IsLowerThan((decimal)-5, (int)0, "Decimal")
                .IsLowerThan((decimal)-5, (int)0, "Decimal", "Custom message here")
                .IsLowerThan((decimal)5, (int)0, "Decimal")
                .IsLowerThan((decimal)5, (int)0, "Decimal", "Custom message here")

                .IsLowerThan((decimal)0, (float)0, "Decimal")
                .IsLowerThan((decimal)0, (float)0, "Decimal", "Custom message here")
                .IsLowerThan((decimal)-5, (float)0, "Decimal")
                .IsLowerThan((decimal)-5, (float)0, "Decimal", "Custom message here")
                .IsLowerThan((decimal)5, (float)0, "Decimal")
                .IsLowerThan((decimal)5, (float)0, "Decimal", "Custom message here")

                .IsLowerThan((decimal)0, (double)0, "Decimal")
                .IsLowerThan((decimal)0, (double)0, "Decimal", "Custom message here")
                .IsLowerThan((decimal)-5, (double)0, "Decimal")
                .IsLowerThan((decimal)-5, (double)0, "Decimal", "Custom message here")
                .IsLowerThan((decimal)5, (double)0, "Decimal")
                .IsLowerThan((decimal)5, (double)0, "Decimal", "Custom message here")

                .IsLowerThan((decimal)0, (decimal)0, "Decimal")
                .IsLowerThan((decimal)0, (decimal)0, "Decimal", "Custom message here")
                .IsLowerThan((decimal)-5, (decimal)0, "Decimal")
                .IsLowerThan((decimal)-5, (decimal)0, "Decimal", "Custom message here")
                .IsLowerThan((decimal)5, (decimal)0, "Decimal")
                .IsLowerThan((decimal)5, (decimal)0, "Decimal", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 16);
        }

        [TestCategory("Decimal Validation")]
        [TestMethod("Requires a decimal is lower or equals than")]
        public void RequiresDecimalIsLowerOrEqualsThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsLowerOrEqualsThan((decimal)0, (int)10, "Decimal")
                .IsLowerOrEqualsThan((decimal)0, (int)10, "Decimal", "Custom message here")
                .IsLowerOrEqualsThan((decimal)10, (int)10, "Decimal")
                .IsLowerOrEqualsThan((decimal)10, (int)10, "Decimal", "Custom message here")
                .IsLowerOrEqualsThan((decimal)20, (int)10, "Decimal")
                .IsLowerOrEqualsThan((decimal)20, (int)10, "Decimal", "Custom message here")

                .IsLowerOrEqualsThan((decimal)0, (float)10, "Decimal")
                .IsLowerOrEqualsThan((decimal)0, (float)10, "Decimal", "Custom message here")
                .IsLowerOrEqualsThan((decimal)10, (float)10, "Decimal")
                .IsLowerOrEqualsThan((decimal)10, (float)10, "Decimal", "Custom message here")
                .IsLowerOrEqualsThan((decimal)20, (float)10, "Decimal")
                .IsLowerOrEqualsThan((decimal)20, (float)10, "Decimal", "Custom message here")

                .IsLowerOrEqualsThan((decimal)0, (double)10, "Decimal")
                .IsLowerOrEqualsThan((decimal)0, (double)10, "Decimal", "Custom message here")
                .IsLowerOrEqualsThan((decimal)10, (double)10, "Decimal")
                .IsLowerOrEqualsThan((decimal)10, (double)10, "Decimal", "Custom message here")
                .IsLowerOrEqualsThan((decimal)20, (double)10, "Decimal")
                .IsLowerOrEqualsThan((decimal)20, (double)10, "Decimal", "Custom message here")

                .IsLowerOrEqualsThan((decimal)0, (decimal)10, "Decimal")
                .IsLowerOrEqualsThan((decimal)0, (decimal)10, "Decimal", "Custom message here")
                .IsLowerOrEqualsThan((decimal)10, (decimal)10, "Decimal")
                .IsLowerOrEqualsThan((decimal)10, (decimal)10, "Decimal", "Custom message here")
                .IsLowerOrEqualsThan((decimal)20, (decimal)10, "Decimal")
                .IsLowerOrEqualsThan((decimal)20, (decimal)10, "Decimal", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Decimal Validation")]
        [TestMethod("Requires a decimal has its min value")]
        public void RequireDecimalHasItsMinValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsMinValue(decimal.MaxValue, "Decimal")
                .IsMinValue(decimal.MaxValue, "Decimal", "Custom message here")
                .IsMinValue(decimal.MinValue, "Decimal")
                .IsMinValue(decimal.MinValue, "Decimal", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Decimal Validation")]
        [TestMethod("Requires a decimal has not its min value")]
        public void RequireDecimalHasNotItsMinValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotMinValue(decimal.MaxValue, "Decimal")
                .IsNotMinValue(decimal.MaxValue, "Decimal", "Custom message here")
                .IsNotMinValue(decimal.MinValue, "Decimal")
                .IsNotMinValue(decimal.MinValue, "Decimal", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Decimal Validation")]
        [TestMethod("Requires a decimal has its max value")]
        public void RequireDecimalHasItsMaxValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsMaxValue(decimal.MaxValue, "Decimal")
                .IsMaxValue(decimal.MaxValue, "Decimal", "Custom message here")
                .IsMaxValue(decimal.MinValue, "Decimal")
                .IsMaxValue(decimal.MinValue, "Decimal", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Decimal Validation")]
        [TestMethod("Requires a decimal has not its max value")]
        public void RequireDecimalHasNotItsMaxValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotMaxValue(decimal.MaxValue, "Decimal")
                .IsNotMaxValue(decimal.MaxValue, "Decimal", "Custom message here")
                .IsNotMaxValue(decimal.MinValue, "Decimal")
                .IsNotMaxValue(decimal.MinValue, "Decimal", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Decimal Validation")]
        [TestMethod("Requires two decimals are equals")]
        public void RequireTwoDecimalsAreEquals()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .AreEquals((decimal)0, (int)0, "Decimal")
                .AreEquals((decimal)0, (int)0, "Decimal", "Custom message here")
                .AreEquals((decimal)0, (int)10, "Decimal")
                .AreEquals((decimal)0, (int)10, "Decimal", "Custom message here")

                .AreEquals((decimal)0, (float)0, "Decimal")
                .AreEquals((decimal)0, (float)0, "Decimal", "Custom message here")
                .AreEquals((decimal)0, (float)10, "Decimal")
                .AreEquals((decimal)0, (float)10, "Decimal", "Custom message here")

                .AreEquals((decimal)0, (double)0, "Decimal")
                .AreEquals((decimal)0, (double)0, "Decimal", "Custom message here")
                .AreEquals((decimal)0, (double)10, "Decimal")
                .AreEquals((decimal)0, (double)10, "Decimal", "Custom message here")

                .AreEquals((decimal)0, (decimal)0, "Decimal")
                .AreEquals((decimal)0, (decimal)0, "Decimal", "Custom message here")
                .AreEquals((decimal)0, (decimal)10, "Decimal")
                .AreEquals((decimal)0, (decimal)10, "Decimal", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Decimal Validation")]
        [TestMethod("Requires two decimals are not equals")]
        public void RequireTwoDecimalsAreNotEquals()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .AreNotEquals((decimal)0, (int)0, "Decimal")
                .AreNotEquals((decimal)0, (int)0, "Decimal", "Custom message here")
                .AreNotEquals((decimal)0, (int)10, "Decimal")
                .AreNotEquals((decimal)0, (int)10, "Decimal", "Custom message here")

                .AreNotEquals((decimal)0, (float)0, "Decimal")
                .AreNotEquals((decimal)0, (float)0, "Decimal", "Custom message here")
                .AreNotEquals((decimal)0, (float)10, "Decimal")
                .AreNotEquals((decimal)0, (float)10, "Decimal", "Custom message here")

                .AreNotEquals((decimal)0, (double)0, "Decimal")
                .AreNotEquals((decimal)0, (double)0, "Decimal", "Custom message here")
                .AreNotEquals((decimal)0, (double)10, "Decimal")
                .AreNotEquals((decimal)0, (double)10, "Decimal", "Custom message here")

                .AreNotEquals((decimal)0, (decimal)0, "Decimal")
                .AreNotEquals((decimal)0, (decimal)0, "Decimal", "Custom message here")
                .AreNotEquals((decimal)0, (decimal)10, "Decimal")
                .AreNotEquals((decimal)0, (decimal)10, "Decimal", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Decimal Validation")]
        [TestMethod("Requires a decimal is null")]
        public void RequiresDecimalIsNull()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNull(_entity.DecimalNull, "Decimal")
                .IsNull(_entity.DecimalNull, "Decimal", "Custom message here")
                .IsNull(_entity.DecimalStart, "Decimal")
                .IsNull(_entity.DecimalStart, "Decimal", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Decimal Validation")]
        [TestMethod("Requires a decimal is not null")]
        public void RequiresDecimalIsNotNull()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotNull(_entity.DecimalNull, "Decimal")
                .IsNotNull(_entity.DecimalNull, "Decimal", "Custom message here")
                .IsNotNull(_entity.DecimalStart, "Decimal")
                .IsNotNull(_entity.DecimalStart, "Decimal", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Decimal Validation")]
        [TestMethod("Requires a decimal is between")]
        public void RequiresDecimalIsBetween()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsBetween(_entity.DecimalBetweenStartAndEnd, (int)_entity.DecimalStart, (int)_entity.DecimalEnd, "Decimal")
                .IsBetween(_entity.DecimalBetweenStartAndEnd, (int)_entity.DecimalStart, (int)_entity.DecimalEnd, "Decimal", "Custom message here")
                .IsBetween(_entity.DecimalStart, (int)_entity.DecimalStart, (int)_entity.DecimalEnd, "Decimal")
                .IsBetween(_entity.DecimalStart, (int)_entity.DecimalStart, (int)_entity.DecimalEnd, "Decimal", "Custom message here")
                .IsBetween(_entity.DecimalEnd, (int)_entity.DecimalStart, (int)_entity.DecimalEnd, "Decimal")
                .IsBetween(_entity.DecimalEnd, (int)_entity.DecimalStart, (int)_entity.DecimalEnd, "Decimal", "Custom message here")
                .IsBetween(_entity.DecimalNotBetweenStartAndEnd, (int)_entity.DecimalStart, (int)_entity.DecimalEnd, "Decimal")
                .IsBetween(_entity.DecimalNotBetweenStartAndEnd, (int)_entity.DecimalStart, (int)_entity.DecimalEnd, "Decimal", "Custom message here")

                .IsBetween(_entity.DecimalBetweenStartAndEnd, (double)_entity.DecimalStart, (double)_entity.DecimalEnd, "Decimal")
                .IsBetween(_entity.DecimalBetweenStartAndEnd, (double)_entity.DecimalStart, (double)_entity.DecimalEnd, "Decimal", "Custom message here")
                .IsBetween(_entity.DecimalStart, (double)_entity.DecimalStart, (double)_entity.DecimalEnd, "Decimal")
                .IsBetween(_entity.DecimalStart, (double)_entity.DecimalStart, (double)_entity.DecimalEnd, "Decimal", "Custom message here")
                .IsBetween(_entity.DecimalEnd, (double)_entity.DecimalStart, (double)_entity.DecimalEnd, "Decimal")
                .IsBetween(_entity.DecimalEnd, (double)_entity.DecimalStart, (double)_entity.DecimalEnd, "Decimal", "Custom message here")
                .IsBetween(_entity.DecimalNotBetweenStartAndEnd, (double)_entity.DecimalStart, (double)_entity.DecimalEnd, "Decimal")
                .IsBetween(_entity.DecimalNotBetweenStartAndEnd, (double)_entity.DecimalStart, (double)_entity.DecimalEnd, "Decimal", "Custom message here")

                .IsBetween(_entity.DecimalBetweenStartAndEnd, (float)_entity.DecimalStart, (float)_entity.DecimalEnd, "Decimal")
                .IsBetween(_entity.DecimalBetweenStartAndEnd, (float)_entity.DecimalStart, (float)_entity.DecimalEnd, "Decimal", "Custom message here")
                .IsBetween(_entity.DecimalStart, (float)_entity.DecimalStart, (float)_entity.DecimalEnd, "Decimal")
                .IsBetween(_entity.DecimalStart, (float)_entity.DecimalStart, (float)_entity.DecimalEnd, "Decimal", "Custom message here")
                .IsBetween(_entity.DecimalEnd, (float)_entity.DecimalStart, (float)_entity.DecimalEnd, "Decimal")
                .IsBetween(_entity.DecimalEnd, (float)_entity.DecimalStart, (float)_entity.DecimalEnd, "Decimal", "Custom message here")
                .IsBetween(_entity.DecimalNotBetweenStartAndEnd, (float)_entity.DecimalStart, (float)_entity.DecimalEnd, "Decimal")
                .IsBetween(_entity.DecimalNotBetweenStartAndEnd, (float)_entity.DecimalStart, (float)_entity.DecimalEnd, "Decimal", "Custom message here")

                .IsBetween(_entity.DecimalBetweenStartAndEnd, _entity.DecimalStart, _entity.DecimalEnd, "Decimal")
                .IsBetween(_entity.DecimalBetweenStartAndEnd, _entity.DecimalStart, _entity.DecimalEnd, "Decimal", "Custom message here")
                .IsBetween(_entity.DecimalStart, _entity.DecimalStart, _entity.DecimalEnd, "Decimal")
                .IsBetween(_entity.DecimalStart, _entity.DecimalStart, _entity.DecimalEnd, "Decimal", "Custom message here")
                .IsBetween(_entity.DecimalEnd, _entity.DecimalStart, _entity.DecimalEnd, "Decimal")
                .IsBetween(_entity.DecimalEnd, _entity.DecimalStart, _entity.DecimalEnd, "Decimal", "Custom message here")
                .IsBetween(_entity.DecimalNotBetweenStartAndEnd, _entity.DecimalStart, _entity.DecimalEnd, "Decimal")
                .IsBetween(_entity.DecimalNotBetweenStartAndEnd, _entity.DecimalStart, _entity.DecimalEnd, "Decimal", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Decimal Validation")]
        [TestMethod("Requires a decimal is not between")]
        public void RequiresDecimalIsNotBetween()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotBetween(_entity.DecimalBetweenStartAndEnd, (int)_entity.DecimalStart, (int)_entity.DecimalEnd, "Decimal")
                .IsNotBetween(_entity.DecimalBetweenStartAndEnd, (int)_entity.DecimalStart, (int)_entity.DecimalEnd, "Decimal", "Custom message here")
                .IsNotBetween(_entity.DecimalStart, (int)_entity.DecimalStart, (int)_entity.DecimalEnd, "Decimal")
                .IsNotBetween(_entity.DecimalStart, (int)_entity.DecimalStart, (int)_entity.DecimalEnd, "Decimal", "Custom message here")
                .IsNotBetween(_entity.DecimalEnd, (int)_entity.DecimalStart, (int)_entity.DecimalEnd, "Decimal")
                .IsNotBetween(_entity.DecimalEnd, (int)_entity.DecimalStart, (int)_entity.DecimalEnd, "Decimal", "Custom message here")
                .IsNotBetween(_entity.DecimalNotBetweenStartAndEnd, (int)_entity.DecimalStart, (int)_entity.DecimalEnd, "Decimal")
                .IsNotBetween(_entity.DecimalNotBetweenStartAndEnd, (int)_entity.DecimalStart, (int)_entity.DecimalEnd, "Decimal", "Custom message here")

                .IsNotBetween(_entity.DecimalBetweenStartAndEnd, (double)_entity.DecimalStart, (double)_entity.DecimalEnd, "Decimal")
                .IsNotBetween(_entity.DecimalBetweenStartAndEnd, (double)_entity.DecimalStart, (double)_entity.DecimalEnd, "Decimal", "Custom message here")
                .IsNotBetween(_entity.DecimalStart, (double)_entity.DecimalStart, (double)_entity.DecimalEnd, "Decimal")
                .IsNotBetween(_entity.DecimalStart, (double)_entity.DecimalStart, (double)_entity.DecimalEnd, "Decimal", "Custom message here")
                .IsNotBetween(_entity.DecimalEnd, (double)_entity.DecimalStart, (double)_entity.DecimalEnd, "Decimal")
                .IsNotBetween(_entity.DecimalEnd, (double)_entity.DecimalStart, (double)_entity.DecimalEnd, "Decimal", "Custom message here")
                .IsNotBetween(_entity.DecimalNotBetweenStartAndEnd, (double)_entity.DecimalStart, (double)_entity.DecimalEnd, "Decimal")
                .IsNotBetween(_entity.DecimalNotBetweenStartAndEnd, (double)_entity.DecimalStart, (double)_entity.DecimalEnd, "Decimal", "Custom message here")

                .IsNotBetween(_entity.DecimalBetweenStartAndEnd, (float)_entity.DecimalStart, (float)_entity.DecimalEnd, "Decimal")
                .IsNotBetween(_entity.DecimalBetweenStartAndEnd, (float)_entity.DecimalStart, (float)_entity.DecimalEnd, "Decimal", "Custom message here")
                .IsNotBetween(_entity.DecimalStart, (float)_entity.DecimalStart, (float)_entity.DecimalEnd, "Decimal")
                .IsNotBetween(_entity.DecimalStart, (float)_entity.DecimalStart, (float)_entity.DecimalEnd, "Decimal", "Custom message here")
                .IsNotBetween(_entity.DecimalEnd, (float)_entity.DecimalStart, (float)_entity.DecimalEnd, "Decimal")
                .IsNotBetween(_entity.DecimalEnd, (float)_entity.DecimalStart, (float)_entity.DecimalEnd, "Decimal", "Custom message here")
                .IsNotBetween(_entity.DecimalNotBetweenStartAndEnd, (float)_entity.DecimalStart, (float)_entity.DecimalEnd, "Decimal")
                .IsNotBetween(_entity.DecimalNotBetweenStartAndEnd, (float)_entity.DecimalStart, (float)_entity.DecimalEnd, "Decimal", "Custom message here")

                .IsNotBetween(_entity.DecimalBetweenStartAndEnd, _entity.DecimalStart, _entity.DecimalEnd, "Decimal")
                .IsNotBetween(_entity.DecimalBetweenStartAndEnd, _entity.DecimalStart, _entity.DecimalEnd, "Decimal", "Custom message here")
                .IsNotBetween(_entity.DecimalStart, _entity.DecimalStart, _entity.DecimalEnd, "Decimal")
                .IsNotBetween(_entity.DecimalStart, _entity.DecimalStart, _entity.DecimalEnd, "Decimal", "Custom message here")
                .IsNotBetween(_entity.DecimalEnd, _entity.DecimalStart, _entity.DecimalEnd, "Decimal")
                .IsNotBetween(_entity.DecimalEnd, _entity.DecimalStart, _entity.DecimalEnd, "Decimal", "Custom message here")
                .IsNotBetween(_entity.DecimalNotBetweenStartAndEnd, _entity.DecimalStart, _entity.DecimalEnd, "Decimal")
                .IsNotBetween(_entity.DecimalNotBetweenStartAndEnd, _entity.DecimalStart, _entity.DecimalEnd, "Decimal", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 24);
        }

        [TestCategory("Decimal Validation")]
        [TestMethod("Requires a list contains a decimal")]
        public void RequiresListContainsDecimal()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .Contains((decimal)1, _entity.DecimalList, "Decimal")
                .Contains((decimal)1, _entity.DecimalList, "Decimal", "Custom message here")
                .Contains((decimal)3, _entity.DecimalList, "Decimal")
                .Contains((decimal)3, _entity.DecimalList, "Decimal", "Custom message here")
                .Contains((decimal)5, _entity.DecimalList, "Decimal")
                .Contains((decimal)5, _entity.DecimalList, "Decimal", "Custom message here")
                .Contains((decimal)7, _entity.DecimalList, "Decimal")
                .Contains((decimal)7, _entity.DecimalList, "Decimal", "Custom message here")
                .Contains((decimal)9, _entity.DecimalList, "Decimal")
                .Contains((decimal)9, _entity.DecimalList, "Decimal", "Custom message here")
                .Contains((decimal)11, _entity.DecimalList, "Decimal")
                .Contains((decimal)11, _entity.DecimalList, "Decimal", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Decimal Validation")]
        [TestMethod("Requires a list does not contains a decimal")]
        public void RequiresListNotContainsDecimal()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .NotContains((decimal)1, _entity.DecimalList, "Decimal")
                .NotContains((decimal)1, _entity.DecimalList, "Decimal", "Custom message here")
                .NotContains((decimal)3, _entity.DecimalList, "Decimal")
                .NotContains((decimal)3, _entity.DecimalList, "Decimal", "Custom message here")
                .NotContains((decimal)5, _entity.DecimalList, "Decimal")
                .NotContains((decimal)5, _entity.DecimalList, "Decimal", "Custom message here")
                .NotContains((decimal)7, _entity.DecimalList, "Decimal")
                .NotContains((decimal)7, _entity.DecimalList, "Decimal", "Custom message here")
                .NotContains((decimal)9, _entity.DecimalList, "Decimal")
                .NotContains((decimal)9, _entity.DecimalList, "Decimal", "Custom message here")
                .NotContains((decimal)11, _entity.DecimalList, "Decimal")
                .NotContains((decimal)11, _entity.DecimalList, "Decimal", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 10);
        }
    }
}
