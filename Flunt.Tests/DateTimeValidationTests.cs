using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Tests.Entities;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class DateTimeValidationTests
    {
        private readonly SampleEntity _entity = new SampleEntity();

        [TestCategory("DateTime Validation")]
        [TestMethod("Requires a date is greater than")]
        public void RequiresDateIsGreaterThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsGreaterThan(SampleEntity.DateTimeSnapshot, _entity.DateTimeGreaterThanNow, "DateTime")
                .IsGreaterThan(SampleEntity.DateTimeSnapshot, _entity.DateTimeGreaterThanNow, "DateTime", "Custom message here")
                .IsGreaterThan(SampleEntity.DateTimeSnapshot, _entity.DateTimeLowerThanNow, "DateTime")
                .IsGreaterThan(SampleEntity.DateTimeSnapshot, _entity.DateTimeLowerThanNow, "DateTime", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("DateTime Validation")]
        [TestMethod("Requires a date is greater or equals than")]
        public void RequiresDateIsGreaterOrEqualsThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsGreaterOrEqualsThan(SampleEntity.DateTimeSnapshot, _entity.DateTimeGreaterOrEqualsThanNow, "DateTime")
                .IsGreaterOrEqualsThan(SampleEntity.DateTimeSnapshot, _entity.DateTimeGreaterOrEqualsThanNow, "DateTime", "Custom message here")
                .IsGreaterOrEqualsThan(SampleEntity.DateTimeSnapshot, _entity.DateTimeGreaterThanNow, "DateTime")
                .IsGreaterOrEqualsThan(SampleEntity.DateTimeSnapshot, _entity.DateTimeGreaterThanNow, "DateTime", "Custom message here")
                .IsGreaterOrEqualsThan(SampleEntity.DateTimeSnapshot, _entity.DateTimeLowerThanNow, "DateTime")
                .IsGreaterOrEqualsThan(SampleEntity.DateTimeSnapshot, _entity.DateTimeLowerThanNow, "DateTime", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("DateTime Validation")]
        [TestMethod("Requires a date is lower than")]
        public void RequiresDateIsLowerThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsLowerThan(SampleEntity.DateTimeSnapshot, _entity.DateTimeLowerThanNow, "DateTime")
                .IsLowerThan(SampleEntity.DateTimeSnapshot, _entity.DateTimeLowerThanNow, "DateTime", "Custom message here")
                .IsLowerThan(SampleEntity.DateTimeSnapshot, _entity.DateTimeGreaterThanNow, "DateTime")
                .IsLowerThan(SampleEntity.DateTimeSnapshot, _entity.DateTimeGreaterThanNow, "DateTime", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("DateTime Validation")]
        [TestMethod("Requires a date is lower or equals than")]
        public void RequiresDateIsLowerOrEqualsThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsLowerOrEqualsThan(SampleEntity.DateTimeSnapshot, _entity.DateTimeLowerOrEqualsThanNow, "DateTime")
                .IsLowerOrEqualsThan(SampleEntity.DateTimeSnapshot, _entity.DateTimeLowerOrEqualsThanNow, "DateTime", "Custom message here")
                .IsLowerOrEqualsThan(SampleEntity.DateTimeSnapshot, _entity.DateTimeLowerThanNow, "DateTime")
                .IsLowerOrEqualsThan(SampleEntity.DateTimeSnapshot, _entity.DateTimeLowerThanNow, "DateTime", "Custom message here")
                .IsLowerOrEqualsThan(SampleEntity.DateTimeSnapshot, _entity.DateTimeGreaterThanNow, "DateTime")
                .IsLowerOrEqualsThan(SampleEntity.DateTimeSnapshot, _entity.DateTimeGreaterThanNow, "DateTime", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("DateTime Validation")]
        [TestMethod("Requires a date is not null")]
        public void RequiresDateIsNotNull()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotNull(SampleEntity.DateTimeSnapshot, "DateTime")
                .IsNotNull(SampleEntity.DateTimeSnapshot, "DateTime", "Custom message here")
                .IsNotNull(_entity.DateTimeNull, "DateTime")
                .IsNotNull(_entity.DateTimeNull, "DateTime", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("DateTime Validation")]
        [TestMethod("Requires a date is null")]
        public void RequiresDateIsNull()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNull(SampleEntity.DateTimeSnapshot, "DateTime")
                .IsNull(SampleEntity.DateTimeSnapshot, "DateTime", "Custom message here")
                .IsNull(_entity.DateTimeNull, "DateTime")
                .IsNull(_entity.DateTimeNull, "DateTime", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("DateTime Validation")]
        [TestMethod("Requires a date is between")]
        public void RequiresDateIsBetween()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsBetween(_entity.DateTimeBetweenStartAndEndDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate, "DateTime")
                .IsBetween(_entity.DateTimeBetweenStartAndEndDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate, "DateTime", "Custom message here")

                // DateTime = StartDate will be consider between
                .IsBetween(_entity.DateTimeStartDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate, "DateTime")

                // DateTime = EndDate will be consider between
                .IsBetween(_entity.DateTimeEndDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate, "DateTime")

                .IsBetween(_entity.DateTimeNotBetweenStartAndEndDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate, "DateTime")
                .IsBetween(_entity.DateTimeNotBetweenStartAndEndDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate, "DateTime", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("DateTime Validation")]
        [TestMethod("Requires a date is not between")]
        public void RequiresDateIsNotBetween()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotBetween(_entity.DateTimeNotBetweenStartAndEndDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate, "DateTime")
                .IsNotBetween(_entity.DateTimeNotBetweenStartAndEndDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate, "DateTime", "Custom message here")

                // DateTime = StartDate will be consider not between
                .IsBetween(_entity.DateTimeStartDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate, "DateTime")

                // DateTime = EndDate will be consider not between
                .IsBetween(_entity.DateTimeEndDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate, "DateTime")

                .IsNotBetween(_entity.DateTimeBetweenStartAndEndDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate, "DateTime")
                .IsNotBetween(_entity.DateTimeBetweenStartAndEndDate, _entity.DateTimeStartDate, _entity.DateTimeEndDate, "DateTime", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("DateTime Validation")]
        [TestMethod("Requires a date is min value")]
        public void RequiresDateHaveMinValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsMinValue(DateTime.MaxValue, "DateTime")
                .IsMinValue(DateTime.MaxValue, "DateTime", "Custom message here")
                .IsMinValue(DateTime.MinValue, "DateTime")
                .IsMinValue(DateTime.MinValue, "DateTime", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("DateTime Validation")]
        [TestMethod("Requires a date is not min value")]
        public void RequiresDateDoNotHaveMinValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotMinValue(DateTime.MaxValue, "DateTime")
                .IsNotMinValue(DateTime.MaxValue, "DateTime", "Custom message here")
                .IsNotMinValue(DateTime.MinValue, "DateTime")
                .IsNotMinValue(DateTime.MinValue, "DateTime", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("DateTime Validation")]
        [TestMethod("Requires a date is max value")]
        public void RequiresDateHaveMaxValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsMaxValue(DateTime.MaxValue, "DateTime")
                .IsMaxValue(DateTime.MaxValue, "DateTime", "Custom message here")
                .IsMaxValue(DateTime.MinValue, "DateTime")
                .IsMaxValue(DateTime.MinValue, "DateTime", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("DateTime Validation")]
        [TestMethod("Requires a date is not max value")]
        public void RequiresDateDoNotHaveMaxValue()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsNotMaxValue(DateTime.MaxValue, "DateTime")
                .IsNotMaxValue(DateTime.MaxValue, "DateTime", "Custom message here")
                .IsNotMaxValue(DateTime.MinValue, "DateTime")
                .IsNotMaxValue(DateTime.MinValue, "DateTime", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("DateTime Validation")]
        [TestMethod("Requires two dates are equals")]
        public void RequiresDatesAreEquals()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .AreEquals(_entity.DateTimeStartDate, _entity.DateTimeStartDate, "DateTime")
                .AreEquals(_entity.DateTimeStartDate, _entity.DateTimeStartDate, "DateTime", "Custom message here")
                .AreEquals(_entity.DateTimeStartDate, _entity.DateTimeEndDate, "DateTime")
                .AreEquals(_entity.DateTimeStartDate, _entity.DateTimeEndDate, "DateTime", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("DateTime Validation")]
        [TestMethod("Requires two dates are not equals")]
        public void RequiresDatesAreNotEquals()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .AreNotEquals(_entity.DateTimeStartDate, _entity.DateTimeStartDate, "DateTime")
                .AreNotEquals(_entity.DateTimeStartDate, _entity.DateTimeStartDate, "DateTime", "Custom message here")
                .AreNotEquals(_entity.DateTimeStartDate, _entity.DateTimeEndDate, "DateTime")
                .AreNotEquals(_entity.DateTimeStartDate, _entity.DateTimeEndDate, "DateTime", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("DateTime Validation")]
        [TestMethod("Requires a list contains a date")]
        public void RequiresListContainsDate()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .Contains(SampleEntity.DateTimeSnapshot, _entity.DateTimeList, "DateTime")
                .Contains(SampleEntity.DateTimeSnapshot, _entity.DateTimeList, "DateTime", "Custom message here")
                .Contains(_entity.DateTimeEndDate, _entity.DateTimeList, "DateTime")
                .Contains(_entity.DateTimeEndDate, _entity.DateTimeList, "DateTime", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("DateTime Validation")]
        [TestMethod("Requires a list not contains a date")]
        public void RequiresListNotContainsDate()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .NotContains(SampleEntity.DateTimeSnapshot, _entity.DateTimeList, "DateTime")
                .NotContains(SampleEntity.DateTimeSnapshot, _entity.DateTimeList, "DateTime", "Custom message here")
                .NotContains(_entity.DateTimeEndDate, _entity.DateTimeList, "DateTime")
                .NotContains(_entity.DateTimeEndDate, _entity.DateTimeList, "DateTime", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }
    }
}
