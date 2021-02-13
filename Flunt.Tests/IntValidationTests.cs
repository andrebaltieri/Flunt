using Flunt.Tests.Entities;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class IntValidationTests
    {
        private readonly SampleEntity _entity = new SampleEntity();

        [TestCategory("Int Validation")]
        [TestMethod("Requires an int is greater than")]
        public void RequiresIntIsGreaterThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsGreaterThan((int)0, (int)10, "Int")
                .IsGreaterThan((int)0, (int)10, "Int", "Custom message here")
                .IsGreaterThan((int)10, (int)10, "Int")
                .IsGreaterThan((int)10, (int)10, "Int", "Custom message here")
                .IsGreaterThan((int)20, (int)10, "Int")
                .IsGreaterThan((int)20, (int)10, "Int", "Custom message here")

                .IsGreaterThan((int)0, (float)10, "Int")
                .IsGreaterThan((int)0, (float)10, "Int", "Custom message here")
                .IsGreaterThan((int)10, (float)10, "Int")
                .IsGreaterThan((int)10, (float)10, "Int", "Custom message here")
                .IsGreaterThan((int)20, (float)10, "Int")
                .IsGreaterThan((int)20, (float)10, "Int", "Custom message here")

                .IsGreaterThan((int)0, (double)10, "Int")
                .IsGreaterThan((int)0, (double)10, "Int", "Custom message here")
                .IsGreaterThan((int)10, (double)10, "Int")
                .IsGreaterThan((int)10, (double)10, "Int", "Custom message here")
                .IsGreaterThan((int)20, (double)10, "Int")
                .IsGreaterThan((int)20, (double)10, "Int", "Custom message here")

                .IsGreaterThan((int)0, (decimal)10, "Int")
                .IsGreaterThan((int)0, (decimal)10, "Int", "Custom message here")
                .IsGreaterThan((int)10, (decimal)10, "Int")
                .IsGreaterThan((int)10, (decimal)10, "Int", "Custom message here")
                .IsGreaterThan((int)20, (decimal)10, "Int")
                .IsGreaterThan((int)20, (decimal)10, "Int", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 16);
        }

        [TestCategory("Int Validation")]
        [TestMethod("Requires an int is greater or equals than")]
        public void RequiresIntIsGreaterOrEqualsThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsGreaterOrEqualsThan((int)0, (int)10, "Int")
                .IsGreaterOrEqualsThan((int)0, (int)10, "Int", "Custom message here")
                .IsGreaterOrEqualsThan((int)10, (int)10, "Int")
                .IsGreaterOrEqualsThan((int)10, (int)10, "Int", "Custom message here")
                .IsGreaterOrEqualsThan((int)20, (int)10, "Int")
                .IsGreaterOrEqualsThan((int)20, (int)10, "Int", "Custom message here")

                .IsGreaterOrEqualsThan((int)0, (float)10, "Int")
                .IsGreaterOrEqualsThan((int)0, (float)10, "Int", "Custom message here")
                .IsGreaterOrEqualsThan((int)10, (float)10, "Int")
                .IsGreaterOrEqualsThan((int)10, (float)10, "Int", "Custom message here")
                .IsGreaterOrEqualsThan((int)20, (float)10, "Int")
                .IsGreaterOrEqualsThan((int)20, (float)10, "Int", "Custom message here")

                .IsGreaterOrEqualsThan((int)0, (double)10, "Int")
                .IsGreaterOrEqualsThan((int)0, (double)10, "Int", "Custom message here")
                .IsGreaterOrEqualsThan((int)10, (double)10, "Int")
                .IsGreaterOrEqualsThan((int)10, (double)10, "Int", "Custom message here")
                .IsGreaterOrEqualsThan((int)20, (double)10, "Int")
                .IsGreaterOrEqualsThan((int)20, (double)10, "Int", "Custom message here")

                .IsGreaterOrEqualsThan((int)0, (decimal)10, "Int")
                .IsGreaterOrEqualsThan((int)0, (decimal)10, "Int", "Custom message here")
                .IsGreaterOrEqualsThan((int)10, (decimal)10, "Int")
                .IsGreaterOrEqualsThan((int)10, (decimal)10, "Int", "Custom message here")
                .IsGreaterOrEqualsThan((int)20, (decimal)10, "Int")
                .IsGreaterOrEqualsThan((int)20, (decimal)10, "Int", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Int Validation")]
        [TestMethod("Requires an int is lower than")]
        public void RequiresIntIsLowerThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsLowerThan((int)0, (int)0, "Int")
                .IsLowerThan((int)0, (int)0, "Int", "Custom message here")
                .IsLowerThan((int)-5, (int)0, "Int")
                .IsLowerThan((int)-5, (int)0, "Int", "Custom message here")
                .IsLowerThan((int)5, (int)0, "Int")
                .IsLowerThan((int)5, (int)0, "Int", "Custom message here")

                .IsLowerThan((int)0, (float)0, "Int")
                .IsLowerThan((int)0, (float)0, "Int", "Custom message here")
                .IsLowerThan((int)-5, (float)0, "Int")
                .IsLowerThan((int)-5, (float)0, "Int", "Custom message here")
                .IsLowerThan((int)5, (float)0, "Int")
                .IsLowerThan((int)5, (float)0, "Int", "Custom message here")

                .IsLowerThan((int)0, (double)0, "Int")
                .IsLowerThan((int)0, (double)0, "Int", "Custom message here")
                .IsLowerThan((int)-5, (double)0, "Int")
                .IsLowerThan((int)-5, (double)0, "Int", "Custom message here")
                .IsLowerThan((int)5, (double)0, "Int")
                .IsLowerThan((int)5, (double)0, "Int", "Custom message here")

                .IsLowerThan((int)0, (decimal)0, "Int")
                .IsLowerThan((int)0, (decimal)0, "Int", "Custom message here")
                .IsLowerThan((int)-5, (decimal)0, "Int")
                .IsLowerThan((int)-5, (decimal)0, "Int", "Custom message here")
                .IsLowerThan((int)5, (decimal)0, "Int")
                .IsLowerThan((int)5, (decimal)0, "Int", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 16);
        }

        [TestCategory("Int Validation")]
        [TestMethod("Requires an int is lower or equals than")]
        public void RequiresIntIsLowerOrEqualsThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsLowerOrEqualsThan((int)0, (int)10, "Int")
                .IsLowerOrEqualsThan((int)0, (int)10, "Int", "Custom message here")
                .IsLowerOrEqualsThan((int)10, (int)10, "Int")
                .IsLowerOrEqualsThan((int)10, (int)10, "Int", "Custom message here")
                .IsLowerOrEqualsThan((int)20, (int)10, "Int")
                .IsLowerOrEqualsThan((int)20, (int)10, "Int", "Custom message here")

                .IsLowerOrEqualsThan((int)0, (float)10, "Int")
                .IsLowerOrEqualsThan((int)0, (float)10, "Int", "Custom message here")
                .IsLowerOrEqualsThan((int)10, (float)10, "Int")
                .IsLowerOrEqualsThan((int)10, (float)10, "Int", "Custom message here")
                .IsLowerOrEqualsThan((int)20, (float)10, "Int")
                .IsLowerOrEqualsThan((int)20, (float)10, "Int", "Custom message here")

                .IsLowerOrEqualsThan((int)0, (double)10, "Int")
                .IsLowerOrEqualsThan((int)0, (double)10, "Int", "Custom message here")
                .IsLowerOrEqualsThan((int)10, (double)10, "Int")
                .IsLowerOrEqualsThan((int)10, (double)10, "Int", "Custom message here")
                .IsLowerOrEqualsThan((int)20, (double)10, "Int")
                .IsLowerOrEqualsThan((int)20, (double)10, "Int", "Custom message here")

                .IsLowerOrEqualsThan((int)0, (decimal)10, "Int")
                .IsLowerOrEqualsThan((int)0, (decimal)10, "Int", "Custom message here")
                .IsLowerOrEqualsThan((int)10, (decimal)10, "Int")
                .IsLowerOrEqualsThan((int)10, (decimal)10, "Int", "Custom message here")
                .IsLowerOrEqualsThan((int)20, (decimal)10, "Int")
                .IsLowerOrEqualsThan((int)20, (decimal)10, "Int", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Int Validation")]
        [TestMethod("Requires an int has its min value")]
        public void RequireIntHasItsMinValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsMinValue(int.MaxValue, "Int")
                .IsMinValue(int.MaxValue, "Int", "Custom message here")
                .IsMinValue(int.MinValue, "Int")
                .IsMinValue(int.MinValue, "Int", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Int Validation")]
        [TestMethod("Requires an int has not its min value")]
        public void RequireIntHasNotItsMinValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotMinValue(int.MaxValue, "Int")
                .IsNotMinValue(int.MaxValue, "Int", "Custom message here")
                .IsNotMinValue(int.MinValue, "Int")
                .IsNotMinValue(int.MinValue, "Int", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Int Validation")]
        [TestMethod("Requires an int has its max value")]
        public void RequireIntHasItsMaxValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsMaxValue(int.MaxValue, "Int")
                .IsMaxValue(int.MaxValue, "Int", "Custom message here")
                .IsMaxValue(int.MinValue, "Int")
                .IsMaxValue(int.MinValue, "Int", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Int Validation")]
        [TestMethod("Requires an int has not its max value")]
        public void RequireIntHasNotItsMaxValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotMaxValue(int.MaxValue, "Int")
                .IsNotMaxValue(int.MaxValue, "Int", "Custom message here")
                .IsNotMaxValue(int.MinValue, "Int")
                .IsNotMaxValue(int.MinValue, "Int", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Int Validation")]
        [TestMethod("Requires two ints are equals")]
        public void RequireTwoIntsAreEquals()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .AreEquals((int)0, (int)0, "Int")
                .AreEquals((int)0, (int)0, "Int", "Custom message here")
                .AreEquals((int)0, (int)10, "Int")
                .AreEquals((int)0, (int)10, "Int", "Custom message here")

                .AreEquals((int)0, (float)0, "Int")
                .AreEquals((int)0, (float)0, "Int", "Custom message here")
                .AreEquals((int)0, (float)10, "Int")
                .AreEquals((int)0, (float)10, "Int", "Custom message here")

                .AreEquals((int)0, (double)0, "Int")
                .AreEquals((int)0, (double)0, "Int", "Custom message here")
                .AreEquals((int)0, (double)10, "Int")
                .AreEquals((int)0, (double)10, "Int", "Custom message here")

                .AreEquals((int)0, (decimal)0, "Int")
                .AreEquals((int)0, (decimal)0, "Int", "Custom message here")
                .AreEquals((int)0, (decimal)10, "Int")
                .AreEquals((int)0, (decimal)10, "Int", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Int Validation")]
        [TestMethod("Requires two ints are not equals")]
        public void RequireTwoIntsAreNotEquals()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .AreNotEquals((int)0, (int)0, "Int")
                .AreNotEquals((int)0, (int)0, "Int", "Custom message here")
                .AreNotEquals((int)0, (int)10, "Int")
                .AreNotEquals((int)0, (int)10, "Int", "Custom message here")

                .AreNotEquals((int)0, (float)0, "Int")
                .AreNotEquals((int)0, (float)0, "Int", "Custom message here")
                .AreNotEquals((int)0, (float)10, "Int")
                .AreNotEquals((int)0, (float)10, "Int", "Custom message here")

                .AreNotEquals((int)0, (double)0, "Int")
                .AreNotEquals((int)0, (double)0, "Int", "Custom message here")
                .AreNotEquals((int)0, (double)10, "Int")
                .AreNotEquals((int)0, (double)10, "Int", "Custom message here")

                .AreNotEquals((int)0, (decimal)0, "Int")
                .AreNotEquals((int)0, (decimal)0, "Int", "Custom message here")
                .AreNotEquals((int)0, (decimal)10, "Int")
                .AreNotEquals((int)0, (decimal)10, "Int", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Int Validation")]
        [TestMethod("Requires an int is null")]
        public void RequiresIntIsNull()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNull(_entity.IntNull, "Int")
                .IsNull(_entity.IntNull, "Int", "Custom message here")
                .IsNull(_entity.IntStart, "Int")
                .IsNull(_entity.IntStart, "Int", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Int Validation")]
        [TestMethod("Requires an int is not null")]
        public void RequiresIntIsNotNull()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotNull(_entity.IntNull, "Int")
                .IsNotNull(_entity.IntNull, "Int", "Custom message here")
                .IsNotNull(_entity.IntStart, "Int")
                .IsNotNull(_entity.IntStart, "Int", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Int Validation")]
        [TestMethod("Requires an int is between")]
        public void RequiresIntIsBetween()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsBetween(_entity.IntBetweenStartAndEnd, (int)_entity.IntStart, (int)_entity.IntEnd, "Int")
                .IsBetween(_entity.IntBetweenStartAndEnd, (int)_entity.IntStart, (int)_entity.IntEnd, "Int", "Custom message here")
                .IsBetween(_entity.IntStart, (int)_entity.IntStart, (int)_entity.IntEnd, "Int")
                .IsBetween(_entity.IntStart, (int)_entity.IntStart, (int)_entity.IntEnd, "Int", "Custom message here")
                .IsBetween(_entity.IntEnd, (int)_entity.IntStart, (int)_entity.IntEnd, "Int")
                .IsBetween(_entity.IntEnd, (int)_entity.IntStart, (int)_entity.IntEnd, "Int", "Custom message here")
                .IsBetween(_entity.IntNotBetweenStartAndEnd, (int)_entity.IntStart, (int)_entity.IntEnd, "Int")
                .IsBetween(_entity.IntNotBetweenStartAndEnd, (int)_entity.IntStart, (int)_entity.IntEnd, "Int", "Custom message here")

                .IsBetween(_entity.IntBetweenStartAndEnd, (double)_entity.IntStart, (double)_entity.IntEnd, "Int")
                .IsBetween(_entity.IntBetweenStartAndEnd, (double)_entity.IntStart, (double)_entity.IntEnd, "Int", "Custom message here")
                .IsBetween(_entity.IntStart, (double)_entity.IntStart, (double)_entity.IntEnd, "Int")
                .IsBetween(_entity.IntStart, (double)_entity.IntStart, (double)_entity.IntEnd, "Int", "Custom message here")
                .IsBetween(_entity.IntEnd, (double)_entity.IntStart, (double)_entity.IntEnd, "Int")
                .IsBetween(_entity.IntEnd, (double)_entity.IntStart, (double)_entity.IntEnd, "Int", "Custom message here")
                .IsBetween(_entity.IntNotBetweenStartAndEnd, (double)_entity.IntStart, (double)_entity.IntEnd, "Int")
                .IsBetween(_entity.IntNotBetweenStartAndEnd, (double)_entity.IntStart, (double)_entity.IntEnd, "Int", "Custom message here")

                .IsBetween(_entity.IntBetweenStartAndEnd, (float)_entity.IntStart, (float)_entity.IntEnd, "Int")
                .IsBetween(_entity.IntBetweenStartAndEnd, (float)_entity.IntStart, (float)_entity.IntEnd, "Int", "Custom message here")
                .IsBetween(_entity.IntStart, (float)_entity.IntStart, (float)_entity.IntEnd, "Int")
                .IsBetween(_entity.IntStart, (float)_entity.IntStart, (float)_entity.IntEnd, "Int", "Custom message here")
                .IsBetween(_entity.IntEnd, (float)_entity.IntStart, (float)_entity.IntEnd, "Int")
                .IsBetween(_entity.IntEnd, (float)_entity.IntStart, (float)_entity.IntEnd, "Int", "Custom message here")
                .IsBetween(_entity.IntNotBetweenStartAndEnd, (float)_entity.IntStart, (float)_entity.IntEnd, "Int")
                .IsBetween(_entity.IntNotBetweenStartAndEnd, (float)_entity.IntStart, (float)_entity.IntEnd, "Int", "Custom message here")

                .IsBetween(_entity.IntBetweenStartAndEnd, _entity.IntStart, _entity.IntEnd, "Int")
                .IsBetween(_entity.IntBetweenStartAndEnd, _entity.IntStart, _entity.IntEnd, "Int", "Custom message here")
                .IsBetween(_entity.IntStart, _entity.IntStart, _entity.IntEnd, "Int")
                .IsBetween(_entity.IntStart, _entity.IntStart, _entity.IntEnd, "Int", "Custom message here")
                .IsBetween(_entity.IntEnd, _entity.IntStart, _entity.IntEnd, "Int")
                .IsBetween(_entity.IntEnd, _entity.IntStart, _entity.IntEnd, "Int", "Custom message here")
                .IsBetween(_entity.IntNotBetweenStartAndEnd, _entity.IntStart, _entity.IntEnd, "Int")
                .IsBetween(_entity.IntNotBetweenStartAndEnd, _entity.IntStart, _entity.IntEnd, "Int", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Int Validation")]
        [TestMethod("Requires an int is not between")]
        public void RequiresIntIsNotBetween()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotBetween(_entity.IntBetweenStartAndEnd, (int)_entity.IntStart, (int)_entity.IntEnd, "Int")
                .IsNotBetween(_entity.IntBetweenStartAndEnd, (int)_entity.IntStart, (int)_entity.IntEnd, "Int", "Custom message here")
                .IsNotBetween(_entity.IntStart, (int)_entity.IntStart, (int)_entity.IntEnd, "Int")
                .IsNotBetween(_entity.IntStart, (int)_entity.IntStart, (int)_entity.IntEnd, "Int", "Custom message here")
                .IsNotBetween(_entity.IntEnd, (int)_entity.IntStart, (int)_entity.IntEnd, "Int")
                .IsNotBetween(_entity.IntEnd, (int)_entity.IntStart, (int)_entity.IntEnd, "Int", "Custom message here")
                .IsNotBetween(_entity.IntNotBetweenStartAndEnd, (int)_entity.IntStart, (int)_entity.IntEnd, "Int")
                .IsNotBetween(_entity.IntNotBetweenStartAndEnd, (int)_entity.IntStart, (int)_entity.IntEnd, "Int", "Custom message here")

                .IsNotBetween(_entity.IntBetweenStartAndEnd, (double)_entity.IntStart, (double)_entity.IntEnd, "Int")
                .IsNotBetween(_entity.IntBetweenStartAndEnd, (double)_entity.IntStart, (double)_entity.IntEnd, "Int", "Custom message here")
                .IsNotBetween(_entity.IntStart, (double)_entity.IntStart, (double)_entity.IntEnd, "Int")
                .IsNotBetween(_entity.IntStart, (double)_entity.IntStart, (double)_entity.IntEnd, "Int", "Custom message here")
                .IsNotBetween(_entity.IntEnd, (double)_entity.IntStart, (double)_entity.IntEnd, "Int")
                .IsNotBetween(_entity.IntEnd, (double)_entity.IntStart, (double)_entity.IntEnd, "Int", "Custom message here")
                .IsNotBetween(_entity.IntNotBetweenStartAndEnd, (double)_entity.IntStart, (double)_entity.IntEnd, "Int")
                .IsNotBetween(_entity.IntNotBetweenStartAndEnd, (double)_entity.IntStart, (double)_entity.IntEnd, "Int", "Custom message here")

                .IsNotBetween(_entity.IntBetweenStartAndEnd, (float)_entity.IntStart, (float)_entity.IntEnd, "Int")
                .IsNotBetween(_entity.IntBetweenStartAndEnd, (float)_entity.IntStart, (float)_entity.IntEnd, "Int", "Custom message here")
                .IsNotBetween(_entity.IntStart, (float)_entity.IntStart, (float)_entity.IntEnd, "Int")
                .IsNotBetween(_entity.IntStart, (float)_entity.IntStart, (float)_entity.IntEnd, "Int", "Custom message here")
                .IsNotBetween(_entity.IntEnd, (float)_entity.IntStart, (float)_entity.IntEnd, "Int")
                .IsNotBetween(_entity.IntEnd, (float)_entity.IntStart, (float)_entity.IntEnd, "Int", "Custom message here")
                .IsNotBetween(_entity.IntNotBetweenStartAndEnd, (float)_entity.IntStart, (float)_entity.IntEnd, "Int")
                .IsNotBetween(_entity.IntNotBetweenStartAndEnd, (float)_entity.IntStart, (float)_entity.IntEnd, "Int", "Custom message here")

                .IsNotBetween(_entity.IntBetweenStartAndEnd, _entity.IntStart, _entity.IntEnd, "Int")
                .IsNotBetween(_entity.IntBetweenStartAndEnd, _entity.IntStart, _entity.IntEnd, "Int", "Custom message here")
                .IsNotBetween(_entity.IntStart, _entity.IntStart, _entity.IntEnd, "Int")
                .IsNotBetween(_entity.IntStart, _entity.IntStart, _entity.IntEnd, "Int", "Custom message here")
                .IsNotBetween(_entity.IntEnd, _entity.IntStart, _entity.IntEnd, "Int")
                .IsNotBetween(_entity.IntEnd, _entity.IntStart, _entity.IntEnd, "Int", "Custom message here")
                .IsNotBetween(_entity.IntNotBetweenStartAndEnd, _entity.IntStart, _entity.IntEnd, "Int")
                .IsNotBetween(_entity.IntNotBetweenStartAndEnd, _entity.IntStart, _entity.IntEnd, "Int", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 24);
        }

        [TestCategory("Int Validation")]
        [TestMethod("Requires a list contains an int")]
        public void RequiresListContainsDouble()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .Contains((int)1, _entity.IntList, "Int")
                .Contains((int)1, _entity.IntList, "Int", "Custom message here")
                .Contains((int)3, _entity.IntList, "Int")
                .Contains((int)3, _entity.IntList, "Int", "Custom message here")
                .Contains((int)5, _entity.IntList, "Int")
                .Contains((int)5, _entity.IntList, "Int", "Custom message here")
                .Contains((int)7, _entity.IntList, "Int")
                .Contains((int)7, _entity.IntList, "Int", "Custom message here")
                .Contains((int)9, _entity.IntList, "Int")
                .Contains((int)9, _entity.IntList, "Int", "Custom message here")
                .Contains((int)11, _entity.IntList, "Int")
                .Contains((int)11, _entity.IntList, "Int", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Int Validation")]
        [TestMethod("Requires a list does not contains an int")]
        public void RequiresListNotContainsDouble()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .NotContains((int)1, _entity.IntList, "Int")
                .NotContains((int)1, _entity.IntList, "Int", "Custom message here")
                .NotContains((int)3, _entity.IntList, "Int")
                .NotContains((int)3, _entity.IntList, "Int", "Custom message here")
                .NotContains((int)5, _entity.IntList, "Int")
                .NotContains((int)5, _entity.IntList, "Int", "Custom message here")
                .NotContains((int)7, _entity.IntList, "Int")
                .NotContains((int)7, _entity.IntList, "Int", "Custom message here")
                .NotContains((int)9, _entity.IntList, "Int")
                .NotContains((int)9, _entity.IntList, "Int", "Custom message here")
                .NotContains((int)11, _entity.IntList, "Int")
                .NotContains((int)11, _entity.IntList, "Int", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 10);
        }
    }
}
