using Flunt.Tests.Entities;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class FloatValidationTests
    {
        private readonly SampleEntity _entity = new SampleEntity();

        [TestCategory("Float Validation")]
        [TestMethod("Requires a float is greater than")]
        public void RequiresFloatIsGreaterThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsGreaterThan((float)0, (int)10, "Float")
                .IsGreaterThan((float)0, (int)10, "Float", "Custom message here")
                .IsGreaterThan((float)10, (int)10, "Float")
                .IsGreaterThan((float)10, (int)10, "Float", "Custom message here")
                .IsGreaterThan((float)20, (int)10, "Float")
                .IsGreaterThan((float)20, (int)10, "Float", "Custom message here")

                .IsGreaterThan((float)0, (float)10, "Float")
                .IsGreaterThan((float)0, (float)10, "Float", "Custom message here")
                .IsGreaterThan((float)10, (float)10, "Float")
                .IsGreaterThan((float)10, (float)10, "Float", "Custom message here")
                .IsGreaterThan((float)20, (float)10, "Float")
                .IsGreaterThan((float)20, (float)10, "Float", "Custom message here")

                .IsGreaterThan((float)0, (double)10, "Float")
                .IsGreaterThan((float)0, (double)10, "Float", "Custom message here")
                .IsGreaterThan((float)10, (double)10, "Float")
                .IsGreaterThan((float)10, (double)10, "Float", "Custom message here")
                .IsGreaterThan((float)20, (double)10, "Float")
                .IsGreaterThan((float)20, (double)10, "Float", "Custom message here")

                .IsGreaterThan((float)0, (decimal)10, "Float")
                .IsGreaterThan((float)0, (decimal)10, "Float", "Custom message here")
                .IsGreaterThan((float)10, (decimal)10, "Float")
                .IsGreaterThan((float)10, (decimal)10, "Float", "Custom message here")
                .IsGreaterThan((float)20, (decimal)10, "Float")
                .IsGreaterThan((float)20, (decimal)10, "Float", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 16);
        }

        [TestCategory("Float Validation")]
        [TestMethod("Requires a float is greater or equals than")]
        public void RequiresFloatIsGreaterOrEqualsThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsGreaterOrEqualsThan((float)0, (int)10, "Float")
                .IsGreaterOrEqualsThan((float)0, (int)10, "Float", "Custom message here")
                .IsGreaterOrEqualsThan((float)10, (int)10, "Float")
                .IsGreaterOrEqualsThan((float)10, (int)10, "Float", "Custom message here")
                .IsGreaterOrEqualsThan((float)20, (int)10, "Float")
                .IsGreaterOrEqualsThan((float)20, (int)10, "Float", "Custom message here")

                .IsGreaterOrEqualsThan((float)0, (float)10, "Float")
                .IsGreaterOrEqualsThan((float)0, (float)10, "Float", "Custom message here")
                .IsGreaterOrEqualsThan((float)10, (float)10, "Float")
                .IsGreaterOrEqualsThan((float)10, (float)10, "Float", "Custom message here")
                .IsGreaterOrEqualsThan((float)20, (float)10, "Float")
                .IsGreaterOrEqualsThan((float)20, (float)10, "Float", "Custom message here")

                .IsGreaterOrEqualsThan((float)0, (double)10, "Float")
                .IsGreaterOrEqualsThan((float)0, (double)10, "Float", "Custom message here")
                .IsGreaterOrEqualsThan((float)10, (double)10, "Float")
                .IsGreaterOrEqualsThan((float)10, (double)10, "Float", "Custom message here")
                .IsGreaterOrEqualsThan((float)20, (double)10, "Float")
                .IsGreaterOrEqualsThan((float)20, (double)10, "Float", "Custom message here")

                .IsGreaterOrEqualsThan((float)0, (decimal)10, "Float")
                .IsGreaterOrEqualsThan((float)0, (decimal)10, "Float", "Custom message here")
                .IsGreaterOrEqualsThan((float)10, (decimal)10, "Float")
                .IsGreaterOrEqualsThan((float)10, (decimal)10, "Float", "Custom message here")
                .IsGreaterOrEqualsThan((float)20, (decimal)10, "Float")
                .IsGreaterOrEqualsThan((float)20, (decimal)10, "Float", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Float Validation")]
        [TestMethod("Requires a float is lower than")]
        public void RequiresFloatIsLowerThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsLowerThan((float)0, (int)0, "Float")
                .IsLowerThan((float)0, (int)0, "Float", "Custom message here")
                .IsLowerThan((float)-5, (int)0, "Float")
                .IsLowerThan((float)-5, (int)0, "Float", "Custom message here")
                .IsLowerThan((float)5, (int)0, "Float")
                .IsLowerThan((float)5, (int)0, "Float", "Custom message here")

                .IsLowerThan((float)0, (float)0, "Float")
                .IsLowerThan((float)0, (float)0, "Float", "Custom message here")
                .IsLowerThan((float)-5, (float)0, "Float")
                .IsLowerThan((float)-5, (float)0, "Float", "Custom message here")
                .IsLowerThan((float)5, (float)0, "Float")
                .IsLowerThan((float)5, (float)0, "Float", "Custom message here")

                .IsLowerThan((float)0, (double)0, "Float")
                .IsLowerThan((float)0, (double)0, "Float", "Custom message here")
                .IsLowerThan((float)-5, (double)0, "Float")
                .IsLowerThan((float)-5, (double)0, "Float", "Custom message here")
                .IsLowerThan((float)5, (double)0, "Float")
                .IsLowerThan((float)5, (double)0, "Float", "Custom message here")

                .IsLowerThan((float)0, (decimal)0, "Float")
                .IsLowerThan((float)0, (decimal)0, "Float", "Custom message here")
                .IsLowerThan((float)-5, (decimal)0, "Float")
                .IsLowerThan((float)-5, (decimal)0, "Float", "Custom message here")
                .IsLowerThan((float)5, (decimal)0, "Float")
                .IsLowerThan((float)5, (decimal)0, "Float", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 16);
        }

        [TestCategory("Float Validation")]
        [TestMethod("Requires a float is lower or equals than")]
        public void RequiresFloatIsLowerOrEqualsThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsLowerOrEqualsThan((float)0, (int)10, "Float")
                .IsLowerOrEqualsThan((float)0, (int)10, "Float", "Custom message here")
                .IsLowerOrEqualsThan((float)10, (int)10, "Float")
                .IsLowerOrEqualsThan((float)10, (int)10, "Float", "Custom message here")
                .IsLowerOrEqualsThan((float)20, (int)10, "Float")
                .IsLowerOrEqualsThan((float)20, (int)10, "Float", "Custom message here")

                .IsLowerOrEqualsThan((float)0, (float)10, "Float")
                .IsLowerOrEqualsThan((float)0, (float)10, "Float", "Custom message here")
                .IsLowerOrEqualsThan((float)10, (float)10, "Float")
                .IsLowerOrEqualsThan((float)10, (float)10, "Float", "Custom message here")
                .IsLowerOrEqualsThan((float)20, (float)10, "Float")
                .IsLowerOrEqualsThan((float)20, (float)10, "Float", "Custom message here")

                .IsLowerOrEqualsThan((float)0, (double)10, "Float")
                .IsLowerOrEqualsThan((float)0, (double)10, "Float", "Custom message here")
                .IsLowerOrEqualsThan((float)10, (double)10, "Float")
                .IsLowerOrEqualsThan((float)10, (double)10, "Float", "Custom message here")
                .IsLowerOrEqualsThan((float)20, (double)10, "Float")
                .IsLowerOrEqualsThan((float)20, (double)10, "Float", "Custom message here")

                .IsLowerOrEqualsThan((float)0, (decimal)10, "Float")
                .IsLowerOrEqualsThan((float)0, (decimal)10, "Float", "Custom message here")
                .IsLowerOrEqualsThan((float)10, (decimal)10, "Float")
                .IsLowerOrEqualsThan((float)10, (decimal)10, "Float", "Custom message here")
                .IsLowerOrEqualsThan((float)20, (decimal)10, "Float")
                .IsLowerOrEqualsThan((float)20, (decimal)10, "Float", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Float Validation")]
        [TestMethod("Requires a float has its min value")]
        public void RequireFloatHasItsMinValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsMinValue(float.MaxValue, "Float")
                .IsMinValue(float.MaxValue, "Float", "Custom message here")
                .IsMinValue(float.MinValue, "Float")
                .IsMinValue(float.MinValue, "Float", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Float Validation")]
        [TestMethod("Requires a float has not its min value")]
        public void RequireFloatHasNotItsMinValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotMinValue(float.MaxValue, "Float")
                .IsNotMinValue(float.MaxValue, "Float", "Custom message here")
                .IsNotMinValue(float.MinValue, "Float")
                .IsNotMinValue(float.MinValue, "Float", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Float Validation")]
        [TestMethod("Requires a float has its max value")]
        public void RequireFloatHasItsMaxValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsMaxValue(float.MaxValue, "Float")
                .IsMaxValue(float.MaxValue, "Float", "Custom message here")
                .IsMaxValue(float.MinValue, "Float")
                .IsMaxValue(float.MinValue, "Float", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Float Validation")]
        [TestMethod("Requires a float has not its max value")]
        public void RequireFloatHasNotItsMaxValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotMaxValue(float.MaxValue, "Float")
                .IsNotMaxValue(float.MaxValue, "Float", "Custom message here")
                .IsNotMaxValue(float.MinValue, "Float")
                .IsNotMaxValue(float.MinValue, "Float", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Float Validation")]
        [TestMethod("Requires two floats are equals")]
        public void RequireTwoFloatsAreEquals()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .AreEquals((float)0, (int)0, "Float")
                .AreEquals((float)0, (int)0, "Float", "Custom message here")
                .AreEquals((float)0, (int)10, "Float")
                .AreEquals((float)0, (int)10, "Float", "Custom message here")

                .AreEquals((float)0, (float)0, "Float")
                .AreEquals((float)0, (float)0, "Float", "Custom message here")
                .AreEquals((float)0, (float)10, "Float")
                .AreEquals((float)0, (float)10, "Float", "Custom message here")

                .AreEquals((float)0, (double)0, "Float")
                .AreEquals((float)0, (double)0, "Float", "Custom message here")
                .AreEquals((float)0, (double)10, "Float")
                .AreEquals((float)0, (double)10, "Float", "Custom message here")

                .AreEquals((float)0, (decimal)0, "Float")
                .AreEquals((float)0, (decimal)0, "Float", "Custom message here")
                .AreEquals((float)0, (decimal)10, "Float")
                .AreEquals((float)0, (decimal)10, "Float", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Float Validation")]
        [TestMethod("Requires two floats are not equals")]
        public void RequireTwoFloatsAreNotEquals()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .AreNotEquals((float)0, (int)0, "Float")
                .AreNotEquals((float)0, (int)0, "Float", "Custom message here")
                .AreNotEquals((float)0, (int)10, "Float")
                .AreNotEquals((float)0, (int)10, "Float", "Custom message here")

                .AreNotEquals((float)0, (float)0, "Float")
                .AreNotEquals((float)0, (float)0, "Float", "Custom message here")
                .AreNotEquals((float)0, (float)10, "Float")
                .AreNotEquals((float)0, (float)10, "Float", "Custom message here")

                .AreNotEquals((float)0, (double)0, "Float")
                .AreNotEquals((float)0, (double)0, "Float", "Custom message here")
                .AreNotEquals((float)0, (double)10, "Float")
                .AreNotEquals((float)0, (double)10, "Float", "Custom message here")

                .AreNotEquals((float)0, (decimal)0, "Float")
                .AreNotEquals((float)0, (decimal)0, "Float", "Custom message here")
                .AreNotEquals((float)0, (decimal)10, "Float")
                .AreNotEquals((float)0, (decimal)10, "Float", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Float Validation")]
        [TestMethod("Requires a float is null")]
        public void RequiresFloatIsNull()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNull(_entity.FloatNull, "Float")
                .IsNull(_entity.FloatNull, "Float", "Custom message here")
                .IsNull(_entity.FloatStart, "Float")
                .IsNull(_entity.FloatStart, "Float", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Float Validation")]
        [TestMethod("Requires a float is not null")]
        public void RequiresFloatIsNotNull()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotNull(_entity.FloatNull, "Float")
                .IsNotNull(_entity.FloatNull, "Float", "Custom message here")
                .IsNotNull(_entity.FloatStart, "Float")
                .IsNotNull(_entity.FloatStart, "Float", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Float Validation")]
        [TestMethod("Requires a float is between")]
        public void RequiresFloatIsBetween()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsBetween(_entity.FloatBetweenStartAndEnd, (int)_entity.FloatStart, (int)_entity.FloatEnd, "Float")
                .IsBetween(_entity.FloatBetweenStartAndEnd, (int)_entity.FloatStart, (int)_entity.FloatEnd, "Float", "Custom message here")
                .IsBetween(_entity.FloatStart, (int)_entity.FloatStart, (int)_entity.FloatEnd, "Float")
                .IsBetween(_entity.FloatStart, (int)_entity.FloatStart, (int)_entity.FloatEnd, "Float", "Custom message here")
                .IsBetween(_entity.FloatEnd, (int)_entity.FloatStart, (int)_entity.FloatEnd, "Float")
                .IsBetween(_entity.FloatEnd, (int)_entity.FloatStart, (int)_entity.FloatEnd, "Float", "Custom message here")
                .IsBetween(_entity.FloatNotBetweenStartAndEnd, (int)_entity.FloatStart, (int)_entity.FloatEnd, "Float")
                .IsBetween(_entity.FloatNotBetweenStartAndEnd, (int)_entity.FloatStart, (int)_entity.FloatEnd, "Float", "Custom message here")

                .IsBetween(_entity.FloatBetweenStartAndEnd, (double)_entity.FloatStart, (double)_entity.FloatEnd, "Float")
                .IsBetween(_entity.FloatBetweenStartAndEnd, (double)_entity.FloatStart, (double)_entity.FloatEnd, "Float", "Custom message here")
                .IsBetween(_entity.FloatStart, (double)_entity.FloatStart, (double)_entity.FloatEnd, "Float")
                .IsBetween(_entity.FloatStart, (double)_entity.FloatStart, (double)_entity.FloatEnd, "Float", "Custom message here")
                .IsBetween(_entity.FloatEnd, (double)_entity.FloatStart, (double)_entity.FloatEnd, "Float")
                .IsBetween(_entity.FloatEnd, (double)_entity.FloatStart, (double)_entity.FloatEnd, "Float", "Custom message here")
                .IsBetween(_entity.FloatNotBetweenStartAndEnd, (double)_entity.FloatStart, (double)_entity.FloatEnd, "Float")
                .IsBetween(_entity.FloatNotBetweenStartAndEnd, (double)_entity.FloatStart, (double)_entity.FloatEnd, "Float", "Custom message here")

                .IsBetween(_entity.FloatBetweenStartAndEnd, (float)_entity.FloatStart, (float)_entity.FloatEnd, "Float")
                .IsBetween(_entity.FloatBetweenStartAndEnd, (float)_entity.FloatStart, (float)_entity.FloatEnd, "Float", "Custom message here")
                .IsBetween(_entity.FloatStart, (float)_entity.FloatStart, (float)_entity.FloatEnd, "Float")
                .IsBetween(_entity.FloatStart, (float)_entity.FloatStart, (float)_entity.FloatEnd, "Float", "Custom message here")
                .IsBetween(_entity.FloatEnd, (float)_entity.FloatStart, (float)_entity.FloatEnd, "Float")
                .IsBetween(_entity.FloatEnd, (float)_entity.FloatStart, (float)_entity.FloatEnd, "Float", "Custom message here")
                .IsBetween(_entity.FloatNotBetweenStartAndEnd, (float)_entity.FloatStart, (float)_entity.FloatEnd, "Float")
                .IsBetween(_entity.FloatNotBetweenStartAndEnd, (float)_entity.FloatStart, (float)_entity.FloatEnd, "Float", "Custom message here")

                .IsBetween(_entity.FloatBetweenStartAndEnd, _entity.FloatStart, _entity.FloatEnd, "Float")
                .IsBetween(_entity.FloatBetweenStartAndEnd, _entity.FloatStart, _entity.FloatEnd, "Float", "Custom message here")
                .IsBetween(_entity.FloatStart, _entity.FloatStart, _entity.FloatEnd, "Float")
                .IsBetween(_entity.FloatStart, _entity.FloatStart, _entity.FloatEnd, "Float", "Custom message here")
                .IsBetween(_entity.FloatEnd, _entity.FloatStart, _entity.FloatEnd, "Float")
                .IsBetween(_entity.FloatEnd, _entity.FloatStart, _entity.FloatEnd, "Float", "Custom message here")
                .IsBetween(_entity.FloatNotBetweenStartAndEnd, _entity.FloatStart, _entity.FloatEnd, "Float")
                .IsBetween(_entity.FloatNotBetweenStartAndEnd, _entity.FloatStart, _entity.FloatEnd, "Float", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Float Validation")]
        [TestMethod("Requires a float is not between")]
        public void RequiresFloatIsNotBetween()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotBetween(_entity.FloatBetweenStartAndEnd, (int)_entity.FloatStart, (int)_entity.FloatEnd, "Float")
                .IsNotBetween(_entity.FloatBetweenStartAndEnd, (int)_entity.FloatStart, (int)_entity.FloatEnd, "Float", "Custom message here")
                .IsNotBetween(_entity.FloatStart, (int)_entity.FloatStart, (int)_entity.FloatEnd, "Float")
                .IsNotBetween(_entity.FloatStart, (int)_entity.FloatStart, (int)_entity.FloatEnd, "Float", "Custom message here")
                .IsNotBetween(_entity.FloatEnd, (int)_entity.FloatStart, (int)_entity.FloatEnd, "Float")
                .IsNotBetween(_entity.FloatEnd, (int)_entity.FloatStart, (int)_entity.FloatEnd, "Float", "Custom message here")
                .IsNotBetween(_entity.FloatNotBetweenStartAndEnd, (int)_entity.FloatStart, (int)_entity.FloatEnd, "Float")
                .IsNotBetween(_entity.FloatNotBetweenStartAndEnd, (int)_entity.FloatStart, (int)_entity.FloatEnd, "Float", "Custom message here")

                .IsNotBetween(_entity.FloatBetweenStartAndEnd, (double)_entity.FloatStart, (double)_entity.FloatEnd, "Float")
                .IsNotBetween(_entity.FloatBetweenStartAndEnd, (double)_entity.FloatStart, (double)_entity.FloatEnd, "Float", "Custom message here")
                .IsNotBetween(_entity.FloatStart, (double)_entity.FloatStart, (double)_entity.FloatEnd, "Float")
                .IsNotBetween(_entity.FloatStart, (double)_entity.FloatStart, (double)_entity.FloatEnd, "Float", "Custom message here")
                .IsNotBetween(_entity.FloatEnd, (double)_entity.FloatStart, (double)_entity.FloatEnd, "Float")
                .IsNotBetween(_entity.FloatEnd, (double)_entity.FloatStart, (double)_entity.FloatEnd, "Float", "Custom message here")
                .IsNotBetween(_entity.FloatNotBetweenStartAndEnd, (double)_entity.FloatStart, (double)_entity.FloatEnd, "Float")
                .IsNotBetween(_entity.FloatNotBetweenStartAndEnd, (double)_entity.FloatStart, (double)_entity.FloatEnd, "Float", "Custom message here")

                .IsNotBetween(_entity.FloatBetweenStartAndEnd, (float)_entity.FloatStart, (float)_entity.FloatEnd, "Float")
                .IsNotBetween(_entity.FloatBetweenStartAndEnd, (float)_entity.FloatStart, (float)_entity.FloatEnd, "Float", "Custom message here")
                .IsNotBetween(_entity.FloatStart, (float)_entity.FloatStart, (float)_entity.FloatEnd, "Float")
                .IsNotBetween(_entity.FloatStart, (float)_entity.FloatStart, (float)_entity.FloatEnd, "Float", "Custom message here")
                .IsNotBetween(_entity.FloatEnd, (float)_entity.FloatStart, (float)_entity.FloatEnd, "Float")
                .IsNotBetween(_entity.FloatEnd, (float)_entity.FloatStart, (float)_entity.FloatEnd, "Float", "Custom message here")
                .IsNotBetween(_entity.FloatNotBetweenStartAndEnd, (float)_entity.FloatStart, (float)_entity.FloatEnd, "Float")
                .IsNotBetween(_entity.FloatNotBetweenStartAndEnd, (float)_entity.FloatStart, (float)_entity.FloatEnd, "Float", "Custom message here")

                .IsNotBetween(_entity.FloatBetweenStartAndEnd, _entity.FloatStart, _entity.FloatEnd, "Float")
                .IsNotBetween(_entity.FloatBetweenStartAndEnd, _entity.FloatStart, _entity.FloatEnd, "Float", "Custom message here")
                .IsNotBetween(_entity.FloatStart, _entity.FloatStart, _entity.FloatEnd, "Float")
                .IsNotBetween(_entity.FloatStart, _entity.FloatStart, _entity.FloatEnd, "Float", "Custom message here")
                .IsNotBetween(_entity.FloatEnd, _entity.FloatStart, _entity.FloatEnd, "Float")
                .IsNotBetween(_entity.FloatEnd, _entity.FloatStart, _entity.FloatEnd, "Float", "Custom message here")
                .IsNotBetween(_entity.FloatNotBetweenStartAndEnd, _entity.FloatStart, _entity.FloatEnd, "Float")
                .IsNotBetween(_entity.FloatNotBetweenStartAndEnd, _entity.FloatStart, _entity.FloatEnd, "Float", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 24);
        }

        [TestCategory("Float Validation")]
        [TestMethod("Requires a list contains a float")]
        public void RequiresListContainsDouble()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .Contains((float)1, _entity.FloatList, "Float")
                .Contains((float)1, _entity.FloatList, "Float", "Custom message here")
                .Contains((float)3, _entity.FloatList, "Float")
                .Contains((float)3, _entity.FloatList, "Float", "Custom message here")
                .Contains((float)5, _entity.FloatList, "Float")
                .Contains((float)5, _entity.FloatList, "Float", "Custom message here")
                .Contains((float)7, _entity.FloatList, "Float")
                .Contains((float)7, _entity.FloatList, "Float", "Custom message here")
                .Contains((float)9, _entity.FloatList, "Float")
                .Contains((float)9, _entity.FloatList, "Float", "Custom message here")
                .Contains((float)11, _entity.FloatList, "Float")
                .Contains((float)11, _entity.FloatList, "Float", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Float Validation")]
        [TestMethod("Requires a list does not contains a float")]
        public void RequiresListNotContainsDouble()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .NotContains((float)1, _entity.FloatList, "Float")
                .NotContains((float)1, _entity.FloatList, "Float", "Custom message here")
                .NotContains((float)3, _entity.FloatList, "Float")
                .NotContains((float)3, _entity.FloatList, "Float", "Custom message here")
                .NotContains((float)5, _entity.FloatList, "Float")
                .NotContains((float)5, _entity.FloatList, "Float", "Custom message here")
                .NotContains((float)7, _entity.FloatList, "Float")
                .NotContains((float)7, _entity.FloatList, "Float", "Custom message here")
                .NotContains((float)9, _entity.FloatList, "Float")
                .NotContains((float)9, _entity.FloatList, "Float", "Custom message here")
                .NotContains((float)11, _entity.FloatList, "Float")
                .NotContains((float)11, _entity.FloatList, "Float", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 10);
        }
    }
}
