using System;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class FloatContractTests
    {
        [TestMethod]
        [TestCategory("FloatValidation")]
        public void IsBetweenFloat()
        {
            float value = -15;
            float from = -1.000F;
            float to = 1.999F;

            var wrong = new Contract()
                .Requires()
                .IsBetween(value, from, to, "float", "The value -15 must be between -1.000 and 1.999");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            value = 0;
            from = float.MinValue;
            to = float.MaxValue;

            var right = new Contract()
                .Requires()
                .IsBetween(value, from, to, "float", $"The value 0 is between {from} and {to}");

            Assert.AreEqual(true, right.Valid);
        }


        [TestMethod]
        [TestCategory("FloatValidation")]
        public void IsNullOrNullable()
        {
            var value = new Nullable<float>();

            var wrong = new Contract()
                .Requires()
                .IsNullOrNullable(value, "float", "The float is required");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            Nullable<float> valueNull = null;

            var wrongNull = new Contract()
                .Requires()
                .IsNullOrNullable(valueNull, "float", "The float is required");

            Assert.AreEqual(false, wrongNull.Valid);
            Assert.AreEqual(1, wrongNull.Notifications.Count);


            var right = new Contract()
                .Requires()
                .IsNullOrNullable(3.5F, "float", "The float is required");

            Assert.AreEqual(true, right.Valid);
        }
    }
}
