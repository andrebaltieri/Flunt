using System;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class DoubleContractTests
    {              
        [TestMethod]
        [TestCategory("DoubleValidation")]
        public void IsBetweenDouble()
        {
            double value = 49.999;
            double from = 50.000;
            double to = 59.999;

            var wrong = new Contract()
                .Requires()
                .IsBetween(value, from, to, "double", "The value 49.999 must be between 50.000 and 59.999");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            value = 1250.01;
            from = 1250.00;
            to = 1299.99;

            var right = new Contract()
                .Requires()
                .IsBetween(value, from, to, "double", "The value 1250.01 is between 1000.01 and 1299.99");

            Assert.AreEqual(true, right.Valid);
        }  


        [TestMethod]
        [TestCategory("DoubleValidation")]
        public void IsNullOrNullable()
        {            
            var value = new Nullable<double>();
            
            var wrong = new Contract()
                .Requires()
                .IsNullOrNullable(value, "double", "The double is required");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            Nullable<double> valueNull = null;
            
            var wrongNull = new Contract()
                .Requires()
                .IsNullOrNullable(valueNull, "double", "The double is required");

            Assert.AreEqual(false, wrongNull.Valid);
            Assert.AreEqual(1, wrongNull.Notifications.Count);


            var right = new Contract()
                .Requires()
                .IsNullOrNullable(1.7E+3, "double", "The decimal is required");

            Assert.AreEqual(true, right.Valid);
        }


    }
}
