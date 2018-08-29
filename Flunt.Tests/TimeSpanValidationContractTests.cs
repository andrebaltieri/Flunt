using System;
using Fluent.Tests.Entities;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
	[TestClass]
    public class TimeSpanContractTests
    {
		private Dummy _dummy;

        [TestMethod]
        [TestCategory("TimeSpanValidation")]
        public void IsGreaterThan()
        {
            _dummy = new Dummy();
            _dummy.timeSpanProp = new TimeSpan(0, 23, 54, 0);

            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromMilliseconds(10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 should be greater than TimeSpan 2")
                .IsGreaterThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromSeconds(10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 should be greater than TimeSpan 2")
                .IsGreaterThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromMinutes(10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 should be greater than TimeSpan 2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(3, wrong.Notifications.Count);
            
            
            var right = new Contract()
                .Requires()
                .IsGreaterThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromMilliseconds(-10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 is not greater than TimeSpan 2")
                .IsGreaterThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromSeconds(-10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 is not greater than TimeSpan 2")
                .IsGreaterThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromMinutes(-10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 is not greater than TimeSpan 2");

            Assert.AreEqual(true, right.Valid);
        }
        
        [TestMethod]
        [TestCategory("TimeSpanValidation")]
        public void IsGreaterOrEqualsThan()
        {
            _dummy = new Dummy();
            _dummy.timeSpanProp = new TimeSpan(0, 23, 54, 0);

            var wrong = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromMilliseconds(10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 should be greater or equals than TimeSpan 2")
                .IsGreaterOrEqualsThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromSeconds(10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 should be greater or equals than TimeSpan 2")
                .IsGreaterOrEqualsThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromMinutes(10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 should be greater or equals than TimeSpan 2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(3, wrong.Notifications.Count);
            
            var right = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromMilliseconds(-10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 is not greater or equals than TimeSpan 2")
                .IsGreaterOrEqualsThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromSeconds(-10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 is not greater or equals than TimeSpan 2")
                .IsGreaterOrEqualsThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromMinutes(-10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 is not greater or equals than TimeSpan 2")
                .IsGreaterOrEqualsThan(_dummy.timeSpanProp, _dummy.timeSpanProp, nameof(_dummy.timeSpanProp), "TimeSpan 1 is not greater or equals than TimeSpan 2");

            Assert.AreEqual(true, right.Valid);
        }
        
        [TestMethod]
        [TestCategory("TimeSpanValidation")]
        public void IsLowerThan()
        {
            _dummy = new Dummy();
            _dummy.timeSpanProp = new TimeSpan(0, 23, 54, 0);

            var wrong = new Contract()
                .Requires()
                .IsLowerThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromMilliseconds(-10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 should be lower than TimeSpan 2")
                .IsLowerThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromSeconds(-10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 should be lower than TimeSpan 2")
                .IsLowerThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromMinutes(-10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 should be lower than TimeSpan 2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(3, wrong.Notifications.Count);
            
            
            var right = new Contract()
                .Requires()
                .IsLowerThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromMilliseconds(10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 is not lower than TimeSpan 2")
                .IsLowerThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromSeconds(10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 is not lower than TimeSpan 2")
                .IsLowerThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromMinutes(10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 is not lower than TimeSpan 2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("TimeSpanValidation")]
        public void IsLowerOrEqualsThan()
        {
            _dummy = new Dummy();
            _dummy.timeSpanProp = new TimeSpan(0, 23, 54, 0);

            var wrong = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromMilliseconds(-10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 should be lower or equals than TimeSpan 2")
                .IsLowerOrEqualsThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromSeconds(-10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 should be lower or equals than TimeSpan 2")
                .IsLowerOrEqualsThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromMinutes(-10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 should be lower or equals than TimeSpan 2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(3, wrong.Notifications.Count);
            
            var right = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromMilliseconds(10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 is not lower or equals than TimeSpan 2")
                .IsLowerOrEqualsThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromSeconds(10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 is not lower or equals than TimeSpan 2")
                .IsLowerOrEqualsThan(_dummy.timeSpanProp, _dummy.timeSpanProp.Add(TimeSpan.FromMinutes(10)), nameof(_dummy.timeSpanProp), "TimeSpan 1 is not lower or equals than TimeSpan 2")
                .IsLowerOrEqualsThan(_dummy.timeSpanProp, _dummy.timeSpanProp, nameof(_dummy.timeSpanProp), "TimeSpan 1 is not lower or equals than TimeSpan 2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("TimeSpanValidation")]
        public void IsBetween()
        {
            _dummy = new Dummy();
            _dummy.timeSpanProp = new TimeSpan(0, 23, 54, 0);
            
            var start = new TimeSpan(0, 23, 56, 0);
            var end = new TimeSpan(0, 23, 59, 0);

            var wrong = new Contract()
                .Requires()
                .IsBetween(_dummy.timeSpanProp, start, end, nameof(_dummy.timeSpanProp), "TimeSpan should be between start and end");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            start = new TimeSpan(0, 23, 0, 0);
            
            var right = new Contract()
                .Requires()
                .IsBetween(_dummy.timeSpanProp, start, end, nameof(_dummy.timeSpanProp), "TimeSpan should be between start and end");

            Assert.AreEqual(true, right.Valid);
        }

    }
}
