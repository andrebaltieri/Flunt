using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Flunt.Validations;

namespace Flunt.Tests
{
    [TestClass]
    public class LongContractTests
    {
        [TestMethod]
        [TestCategory("LongValidation")]
        public void IsBetweenLong()
        {
            long value = 4294967296;
            long from = 4294967290;
            long to = 4294967295;

            var wrong = new Contract()
                .Requires()
                .IsBetween(value, from, to, "long", "The value 11 must be between 1 and 10");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            value = 5;
            from = 1;
            to = 10;

            var right = new Contract()
                .Requires()
                .IsBetween(5, 1, 10, "long", "The value 5 is between 1 and 10");

            Assert.AreEqual(true, right.Valid);
        }
    }
}
