using System;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class IntContractTests
    {  
        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsBetweenInt()
        {
            int value = 11;
            int from = 1;
            int to = 10;

            var wrong = new Contract()
                .Requires()
                .IsBetween(value, from, to, "int", "The value 11 must be between 1 and 10");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            value = 5;
            from = 1;
            to = 10;

            var right = new Contract()
                .Requires()
                .IsBetween(5, 1, 10, "int", "The value 5 is between 1 and 10");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsNullOrNullable()
        {
            var value = new Nullable<int>();

            var wrong = new Contract()
                .Requires()
                .IsNullOrNullable(value, "int", "The int is required");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            Nullable<int> valueNull = null;

            var wrongNull = new Contract()
                .Requires()
                .IsNullOrNullable(valueNull, "int", "The int is required");

            Assert.AreEqual(false, wrongNull.Valid);
            Assert.AreEqual(1, wrongNull.Notifications.Count);


            var right = new Contract()
                .Requires()
                .IsNullOrNullable(3.5F, "int", "The int is required");

            Assert.AreEqual(true, right.Valid);
        }
    }
}
