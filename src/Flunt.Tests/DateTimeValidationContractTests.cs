using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Fluent.Tests.Entities;

namespace Flunt.Tests
{
    [TestClass]
    public class DateTimeContractTests
    {
        private Dummy _dummy;

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsGreaterThan()
        {
            _dummy = new Dummy();
            _dummy.dateTimeProp = new DateTime(2005, 5, 15, 16, 0, 0);

            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMilliseconds(1), nameof(_dummy.dateTimeProp), "Date 1 should be greater than Date 2")
                .IsGreaterThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddSeconds(1), nameof(_dummy.dateTimeProp), "Date 1 should be greater than Date 2")
                .IsGreaterThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMinutes(1), nameof(_dummy.dateTimeProp), "Date 1 should be greater than Date 2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(3, wrong.Notifications.Count);

            var right = new Contract()
                .Requires()
                .IsGreaterThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMilliseconds(-2), nameof(_dummy.dateTimeProp), "Date 1 is not greater than Date 2")
                .IsGreaterThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddSeconds(-2), nameof(_dummy.dateTimeProp), "Date 1 is not greater than Date 2")
                .IsGreaterThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMinutes(-2), nameof(_dummy.dateTimeProp), "Date 1 is not greater than Date 2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsGreaterOrEqualsThan()
        {
            _dummy = new Dummy();
            _dummy.dateTimeProp = new DateTime(2017, 1, 1, 12, 0, 0);

            var wrong = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMilliseconds(1), nameof(_dummy.dateTimeProp), "Date 1 should be greater than Date 2")
                .IsGreaterOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddSeconds(1), nameof(_dummy.dateTimeProp), "Date 1 should be greater than Date 2")
                .IsGreaterOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMinutes(1), nameof(_dummy.dateTimeProp), "Date 1 should be greater than Date 2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(3, wrong.Notifications.Count);

            var right = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp, nameof(_dummy.dateTimeProp), "Date 1 is not greater or equals than Date 2")
                .IsGreaterOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMilliseconds(-1), nameof(_dummy.dateTimeProp), "Date 1 is not greater or equals than Date 2")
                .IsGreaterOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddSeconds(-1), nameof(_dummy.dateTimeProp), "Date 1 is not greater or equals than Date 2")
                .IsGreaterOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMinutes(-1), nameof(_dummy.dateTimeProp), "Date 1 is not greater or equals than Date 2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsLowerThan()
        {
            _dummy = new Dummy();
            _dummy.dateTimeProp = new DateTime(2017, 9, 26, 15, 0, 0);

            var wrong = new Contract()
                .Requires()
                .IsLowerThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMilliseconds(-1), nameof(_dummy.dateTimeProp), "Date 1 should be lower than Date 2")
                .IsLowerThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddSeconds(-1), nameof(_dummy.dateTimeProp), "Date 1 should be lower than Date 2")
                .IsLowerThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMinutes(-1), nameof(_dummy.dateTimeProp), "Date 1 should be lower than Date 2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(3, wrong.Notifications.Count);

            var right = new Contract()
                .Requires()
                .IsLowerThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMilliseconds(1),nameof(_dummy.dateTimeProp), "Date 1 is not lower than Date 2")
                .IsLowerThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddSeconds(1), nameof(_dummy.dateTimeProp), "Date 1 is not lower than Date 2")
                .IsLowerThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMinutes(1), nameof(_dummy.dateTimeProp), "Date 1 is not lower than Date 2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsLowerOrEqualsThan()
        {
            _dummy = new Dummy();
            _dummy.dateTimeProp = new DateTime(2005, 5, 15, 16, 0, 0);

            var wrong = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMilliseconds(-1), nameof(_dummy.dateTimeProp), "Date 1 should be lower or equals than Date 2")
                .IsLowerOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddSeconds(-1), nameof(_dummy.dateTimeProp), "Date 1 should be lower or equals than Date 2")
                .IsLowerOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMinutes(-1), nameof(_dummy.dateTimeProp), "Date 1 should be lower or equals than Date 2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(3, wrong.Notifications.Count);

            var right = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp, nameof(_dummy.dateTimeProp), "Date 1 is not lower or equals than Date 2")
                .IsLowerOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMilliseconds(1), nameof(_dummy.dateTimeProp), "Date 1 is not lower or equals than Date 2")
                .IsLowerOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddSeconds(1), nameof(_dummy.dateTimeProp), "Date 1 is not lower or equals than Date 2")
                .IsLowerOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMinutes(1), nameof(_dummy.dateTimeProp), "Date 1 is not lower or equals than Date 2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsBetween()
        {            
            var from = new DateTime(2017, 10, 1);
            var to = from.AddDays(30);
            
            var wrong = new Contract()
                .Requires()
                .IsBetween(new DateTime(2017, 10, 1), from, to, "datetime", "The date must be between 01/10/2017 and 31/10/2017");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new Contract()
                .Requires()
                .IsBetween(new DateTime(2017, 10, 30), from, to, "datetime", "The date is between 01/10/2017 and 31/10/2017");

            Assert.AreEqual(true, right.Valid);
        }
    }
}
