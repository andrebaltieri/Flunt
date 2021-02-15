using System;
using Flunt.Tests.Entities;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class TimeSpanValidationTests
    {
        private readonly SampleEntity _entity = new SampleEntity();

        [TestCategory("TimeSpan Validation")]
        [TestMethod("Requires a date is greater than")]
        public void RequiresDateIsGreaterThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsGreaterThan(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanGreaterThanNow, "TimeSpan")
                .IsGreaterThan(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanGreaterThanNow, "TimeSpan", "Custom message here")
                .IsGreaterThan(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanLowerThanNow, "TimeSpan")
                .IsGreaterThan(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanLowerThanNow, "TimeSpan", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("TimeSpan Validation")]
        [TestMethod("Requires a date is greater or equals than")]
        public void RequiresDateIsGreaterOrEqualsThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsGreaterOrEqualsThan(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanGreaterOrEqualsThanNow, "TimeSpan")
                .IsGreaterOrEqualsThan(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanGreaterOrEqualsThanNow, "TimeSpan", "Custom message here")
                .IsGreaterOrEqualsThan(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanGreaterThanNow, "TimeSpan")
                .IsGreaterOrEqualsThan(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanGreaterThanNow, "TimeSpan", "Custom message here")
                .IsGreaterOrEqualsThan(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanLowerThanNow, "TimeSpan")
                .IsGreaterOrEqualsThan(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanLowerThanNow, "TimeSpan", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("TimeSpan Validation")]
        [TestMethod("Requires a date is lower than")]
        public void RequiresDateIsLowerThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsLowerThan(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanLowerThanNow, "TimeSpan")
                .IsLowerThan(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanLowerThanNow, "TimeSpan", "Custom message here")
                .IsLowerThan(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanGreaterThanNow, "TimeSpan")
                .IsLowerThan(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanGreaterThanNow, "TimeSpan", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("TimeSpan Validation")]
        [TestMethod("Requires a date is lower or equals than")]
        public void RequiresDateIsLowerOrEqualsThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsLowerOrEqualsThan(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanLowerOrEqualsThanNow, "TimeSpan")
                .IsLowerOrEqualsThan(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanLowerOrEqualsThanNow, "TimeSpan", "Custom message here")
                .IsLowerOrEqualsThan(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanLowerThanNow, "TimeSpan")
                .IsLowerOrEqualsThan(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanLowerThanNow, "TimeSpan", "Custom message here")
                .IsLowerOrEqualsThan(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanGreaterThanNow, "TimeSpan")
                .IsLowerOrEqualsThan(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanGreaterThanNow, "TimeSpan", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("TimeSpan Validation")]
        [TestMethod("Requires a date is not null")]
        public void RequiresDateIsNotNull()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotNull(SampleEntity.TimeSpanSnapshot, "TimeSpan")
                .IsNotNull(SampleEntity.TimeSpanSnapshot, "TimeSpan", "Custom message here")
                .IsNotNull(_entity.TimeSpanNull, "TimeSpan")
                .IsNotNull(_entity.TimeSpanNull, "TimeSpan", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("TimeSpan Validation")]
        [TestMethod("Requires a date is null")]
        public void RequiresDateIsNull()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNull(SampleEntity.TimeSpanSnapshot, "TimeSpan")
                .IsNull(SampleEntity.TimeSpanSnapshot, "TimeSpan", "Custom message here")
                .IsNull(_entity.TimeSpanNull, "TimeSpan")
                .IsNull(_entity.TimeSpanNull, "TimeSpan", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("TimeSpan Validation")]
        [TestMethod("Requires a date is between")]
        public void RequiresDateIsBetween()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsBetween(_entity.TimeSpanBetweenStartAndEndDate, _entity.TimeSpanStartDate, _entity.TimeSpanEndDate, "TimeSpan")
                .IsBetween(_entity.TimeSpanBetweenStartAndEndDate, _entity.TimeSpanStartDate, _entity.TimeSpanEndDate, "TimeSpan", "Custom message here")

                // TimeSpan = StartDate will be consider between
                .IsBetween(_entity.TimeSpanStartDate, _entity.TimeSpanStartDate, _entity.TimeSpanEndDate, "TimeSpan")

                // TimeSpan = EndDate will be consider between
                .IsBetween(_entity.TimeSpanEndDate, _entity.TimeSpanStartDate, _entity.TimeSpanEndDate, "TimeSpan")

                .IsBetween(_entity.TimeSpanNotBetweenStartAndEndDate, _entity.TimeSpanStartDate, _entity.TimeSpanEndDate, "TimeSpan")
                .IsBetween(_entity.TimeSpanNotBetweenStartAndEndDate, _entity.TimeSpanStartDate, _entity.TimeSpanEndDate, "TimeSpan", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("TimeSpan Validation")]
        [TestMethod("Requires a date is not between")]
        public void RequiresDateIsNotBetween()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotBetween(_entity.TimeSpanNotBetweenStartAndEndDate, _entity.TimeSpanStartDate, _entity.TimeSpanEndDate, "TimeSpan")
                .IsNotBetween(_entity.TimeSpanNotBetweenStartAndEndDate, _entity.TimeSpanStartDate, _entity.TimeSpanEndDate, "TimeSpan", "Custom message here")

                // TimeSpan = StartDate will be consider not between
                .IsBetween(_entity.TimeSpanStartDate, _entity.TimeSpanStartDate, _entity.TimeSpanEndDate, "TimeSpan")

                // TimeSpan = EndDate will be consider not between
                .IsBetween(_entity.TimeSpanEndDate, _entity.TimeSpanStartDate, _entity.TimeSpanEndDate, "TimeSpan")

                .IsNotBetween(_entity.TimeSpanBetweenStartAndEndDate, _entity.TimeSpanStartDate, _entity.TimeSpanEndDate, "TimeSpan")
                .IsNotBetween(_entity.TimeSpanBetweenStartAndEndDate, _entity.TimeSpanStartDate, _entity.TimeSpanEndDate, "TimeSpan", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("TimeSpan Validation")]
        [TestMethod("Requires a date is min value")]
        public void RequiresDateHaveMinValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsMinValue(TimeSpan.MaxValue, "TimeSpan")
                .IsMinValue(TimeSpan.MaxValue, "TimeSpan", "Custom message here")
                .IsMinValue(TimeSpan.MinValue, "TimeSpan")
                .IsMinValue(TimeSpan.MinValue, "TimeSpan", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("TimeSpan Validation")]
        [TestMethod("Requires a date is not min value")]
        public void RequiresDateDoNotHaveMinValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotMinValue(TimeSpan.MaxValue, "TimeSpan")
                .IsNotMinValue(TimeSpan.MaxValue, "TimeSpan", "Custom message here")
                .IsNotMinValue(TimeSpan.MinValue, "TimeSpan")
                .IsNotMinValue(TimeSpan.MinValue, "TimeSpan", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("TimeSpan Validation")]
        [TestMethod("Requires a date is max value")]
        public void RequiresDateHaveMaxValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsMaxValue(TimeSpan.MaxValue, "TimeSpan")
                .IsMaxValue(TimeSpan.MaxValue, "TimeSpan", "Custom message here")
                .IsMaxValue(TimeSpan.MinValue, "TimeSpan")
                .IsMaxValue(TimeSpan.MinValue, "TimeSpan", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("TimeSpan Validation")]
        [TestMethod("Requires a date is not max value")]
        public void RequiresDateDoNotHaveMaxValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotMaxValue(TimeSpan.MaxValue, "TimeSpan")
                .IsNotMaxValue(TimeSpan.MaxValue, "TimeSpan", "Custom message here")
                .IsNotMaxValue(TimeSpan.MinValue, "TimeSpan")
                .IsNotMaxValue(TimeSpan.MinValue, "TimeSpan", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("TimeSpan Validation")]
        [TestMethod("Requires two dates are equals")]
        public void RequiresDatesAreEquals()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .AreEquals(_entity.TimeSpanStartDate, _entity.TimeSpanStartDate, "TimeSpan")
                .AreEquals(_entity.TimeSpanStartDate, _entity.TimeSpanStartDate, "TimeSpan", "Custom message here")
                .AreEquals(_entity.TimeSpanStartDate, _entity.TimeSpanEndDate, "TimeSpan")
                .AreEquals(_entity.TimeSpanStartDate, _entity.TimeSpanEndDate, "TimeSpan", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("TimeSpan Validation")]
        [TestMethod("Requires two dates are not equals")]
        public void RequiresDatesAreNotEquals()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .AreNotEquals(_entity.TimeSpanStartDate, _entity.TimeSpanStartDate, "TimeSpan")
                .AreNotEquals(_entity.TimeSpanStartDate, _entity.TimeSpanStartDate, "TimeSpan", "Custom message here")
                .AreNotEquals(_entity.TimeSpanStartDate, _entity.TimeSpanEndDate, "TimeSpan")
                .AreNotEquals(_entity.TimeSpanStartDate, _entity.TimeSpanEndDate, "TimeSpan", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("TimeSpan Validation")]
        [TestMethod("Requires a list contains a date")]
        public void RequiresListContainsDate()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .Contains(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanList, "TimeSpan")
                .Contains(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanList, "TimeSpan", "Custom message here")
                .Contains(_entity.TimeSpanEndDate, _entity.TimeSpanList, "TimeSpan")
                .Contains(_entity.TimeSpanEndDate, _entity.TimeSpanList, "TimeSpan", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("TimeSpan Validation")]
        [TestMethod("Requires a list not contains a date")]
        public void RequiresListNotContainsDate()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .NotContains(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanList, "TimeSpan")
                .NotContains(SampleEntity.TimeSpanSnapshot, _entity.TimeSpanList, "TimeSpan", "Custom message here")
                .NotContains(_entity.TimeSpanEndDate, _entity.TimeSpanList, "TimeSpan")
                .NotContains(_entity.TimeSpanEndDate, _entity.TimeSpanList, "TimeSpan", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }
    }
}
