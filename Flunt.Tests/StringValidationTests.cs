using Flunt.Tests.Entities;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class StringValidationTests
    {
        private readonly SampleEntity _entity = new SampleEntity();

        [TestCategory("String Validation")]
        [TestMethod("Requires a string is null")]
        public void IsNull()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .IsNull(_entity.StringEmpty, "String")
                .IsNull(_entity.StringEmpty, "String", "Custom error message")

                .IsNull(_entity.StringNotEmpty, "String")
                .IsNull(_entity.StringNotEmpty, "String", "Custom error message")

                .IsNull(_entity.StringNull, "String")
                .IsNull(_entity.StringNull, "String", "Custom error message")

                .IsNull(_entity.StringWhiteSpace, "String")
                .IsNull(_entity.StringWhiteSpace, "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 6);
        }

        [TestCategory("String Validation")]
        [TestMethod("Requires a string is not null")]
        public void IsNotNull()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .IsNotNull(_entity.StringEmpty, "String")
                .IsNotNull(_entity.StringEmpty, "String", "Custom error message")

                .IsNotNull(_entity.StringNotEmpty, "String")
                .IsNotNull(_entity.StringNotEmpty, "String", "Custom error message")

                .IsNotNull(_entity.StringNull, "String")
                .IsNotNull(_entity.StringNull, "String", "Custom error message")

                .IsNotNull(_entity.StringWhiteSpace, "String")
                .IsNotNull(_entity.StringWhiteSpace, "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("String Validation")]
        [TestMethod("Requires a string is null or empty")]
        public void IsNullOrEmpty()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .IsNullOrEmpty(_entity.StringEmpty, "String")
                .IsNullOrEmpty(_entity.StringEmpty, "String", "Custom error message")

                .IsNullOrEmpty(_entity.StringNotEmpty, "String")
                .IsNullOrEmpty(_entity.StringNotEmpty, "String", "Custom error message")

                .IsNullOrEmpty(_entity.StringNull, "String")
                .IsNullOrEmpty(_entity.StringNull, "String", "Custom error message")

                .IsNullOrEmpty(_entity.StringWhiteSpace, "String")
                .IsNullOrEmpty(_entity.StringWhiteSpace, "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 4);
        }

        [TestCategory("String Validation")]
        [TestMethod("Requires a string is not null or empty")]
        public void IsNotNullOrEmpty()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .IsNotNullOrEmpty(_entity.StringEmpty, "String")
                .IsNotNullOrEmpty(_entity.StringEmpty, "String", "Custom error message")

                .IsNotNullOrEmpty(_entity.StringNotEmpty, "String")
                .IsNotNullOrEmpty(_entity.StringNotEmpty, "String", "Custom error message")

                .IsNotNullOrEmpty(_entity.StringNull, "String")
                .IsNotNullOrEmpty(_entity.StringNull, "String", "Custom error message")

                .IsNotNullOrEmpty(_entity.StringWhiteSpace, "String")
                .IsNotNullOrEmpty(_entity.StringWhiteSpace, "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 4);
        }

        [TestCategory("String Validation")]
        [TestMethod("Requires a string is null or white space")]
        public void IsNullOrWhiteSpace()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .IsNullOrWhiteSpace(_entity.StringEmpty, "String")
                .IsNullOrWhiteSpace(_entity.StringEmpty, "String", "Custom error message")

                .IsNullOrWhiteSpace(_entity.StringNotEmpty, "String")
                .IsNullOrWhiteSpace(_entity.StringNotEmpty, "String", "Custom error message")

                .IsNullOrWhiteSpace(_entity.StringNull, "String")
                .IsNullOrWhiteSpace(_entity.StringNull, "String", "Custom error message")

                .IsNullOrWhiteSpace(_entity.StringWhiteSpace, "String")
                .IsNullOrWhiteSpace(_entity.StringWhiteSpace, "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("String Validation")]
        [TestMethod("Requires a string is not null or white space")]
        public void IsNotNullOrWhiteSpace()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .IsNotNullOrWhiteSpace(_entity.StringEmpty, "String")
                .IsNotNullOrWhiteSpace(_entity.StringEmpty, "String", "Custom error message")

                .IsNotNullOrWhiteSpace(_entity.StringNotEmpty, "String")
                .IsNotNullOrWhiteSpace(_entity.StringNotEmpty, "String", "Custom error message")

                .IsNotNullOrWhiteSpace(_entity.StringNull, "String")
                .IsNotNullOrWhiteSpace(_entity.StringNull, "String", "Custom error message")

                .IsNotNullOrWhiteSpace(_entity.StringWhiteSpace, "String")
                .IsNotNullOrWhiteSpace(_entity.StringWhiteSpace, "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 6);
        }

        [TestCategory("String Validation")]
        [TestMethod("Requires two strings are equals")]
        public void AreEquals()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .AreEquals(_entity.StringEmpty, string.Empty, "String")
                .AreEquals(_entity.StringEmpty, string.Empty, "String", "Custom error message")

                .AreEquals(_entity.StringNotEmpty, "RandomString", "String")
                .AreEquals(_entity.StringNotEmpty, "RandomString", "String", "Custom error message")

                .AreEquals(_entity.StringNull, null, "String")
                .AreEquals(_entity.StringNull, null, "String", "Custom error message")

                .AreEquals(_entity.StringWhiteSpace, " ", "String")
                .AreEquals(_entity.StringWhiteSpace, " ", "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("String Validation")]
        [TestMethod("Requires two strings are not equals")]
        public void AreNotEquals()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .AreNotEquals(_entity.StringEmpty, string.Empty, "String")
                .AreNotEquals(_entity.StringEmpty, string.Empty, "String", "Custom error message")

                .AreNotEquals(_entity.StringNotEmpty, "RandomString", "String")
                .AreNotEquals(_entity.StringNotEmpty, "RandomString", "String", "Custom error message")

                .AreNotEquals(_entity.StringNull, null, "String")
                .AreNotEquals(_entity.StringNull, null, "String", "Custom error message")

                .AreNotEquals(_entity.StringWhiteSpace, " ", "String")
                .AreNotEquals(_entity.StringWhiteSpace, " ", "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 6);
        }

        [TestCategory("String Validation")]
        [TestMethod("Requires a string contains a value")]
        public void Contains()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .Contains(_entity.StringEmpty, "value", "String")
                .Contains(_entity.StringEmpty, "value", "String", "Custom error message")

                .Contains(_entity.StringNotEmpty, "value", "String")
                .Contains(_entity.StringNotEmpty, "value", "String", "Custom error message")

                .Contains(_entity.StringNull, "value", "String")
                .Contains(_entity.StringNull, "value", "String", "Custom error message")

                .Contains(_entity.StringWhiteSpace, "value", "String")
                .Contains(_entity.StringWhiteSpace, "value", "String", "Custom error message")

                .Contains(_entity.StringNotEmpty, "some", "String")
                .Contains(_entity.StringNotEmpty, "some", "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("String Validation")]
        [TestMethod("Requires a string not contains a value")]
        public void NotContains()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .NotContains(_entity.StringEmpty, "value", "String")
                .NotContains(_entity.StringEmpty, "value", "String", "Custom error message")

                .NotContains(_entity.StringNotEmpty, "value", "String")
                .NotContains(_entity.StringNotEmpty, "value", "String", "Custom error message")

                .NotContains(_entity.StringNull, "value", "String")
                .NotContains(_entity.StringNull, "value", "String", "Custom error message")

                .NotContains(_entity.StringWhiteSpace, "value", "String")
                .NotContains(_entity.StringWhiteSpace, "value", "String", "Custom error message")

                .NotContains(_entity.StringNotEmpty, "some", "String")
                .NotContains(_entity.StringNotEmpty, "some", "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("String Validation")]
        [TestMethod("Requires a string len is greater than")]
        public void IsGreaterThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .IsGreaterThan(_entity.StringEmpty, 5, "String")
                .IsGreaterThan(_entity.StringEmpty, 5, "String", "Custom error message")

                .IsGreaterThan(_entity.StringFiveCharsLong, 5, "String")
                .IsGreaterThan(_entity.StringFiveCharsLong, 5, "String", "Custom error message")

                .IsGreaterThan(_entity.StringNull, 5, "String")
                .IsGreaterThan(_entity.StringNull, 5, "String", "Custom error message")

                .IsGreaterThan(_entity.StringWhiteSpace, 5, "String")
                .IsGreaterThan(_entity.StringWhiteSpace, 5, "String", "Custom error message")

                .IsGreaterThan(_entity.StringNotEmpty, 3, "String")
                .IsGreaterThan(_entity.StringNotEmpty, 3, "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 6);
        }

        [TestCategory("String Validation")]
        [TestMethod("Requires a string len is greater or equals than")]
        public void IsGreaterOrEqualsThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .IsGreaterOrEqualsThan(_entity.StringEmpty, 5, "String")
                .IsGreaterOrEqualsThan(_entity.StringEmpty, 5, "String", "Custom error message")

                .IsGreaterOrEqualsThan(_entity.StringFiveCharsLong, 5, "String")
                .IsGreaterOrEqualsThan(_entity.StringFiveCharsLong, 5, "String", "Custom error message")

                .IsGreaterOrEqualsThan(_entity.StringNull, 5, "String")
                .IsGreaterOrEqualsThan(_entity.StringNull, 5, "String", "Custom error message")

                .IsGreaterOrEqualsThan(_entity.StringWhiteSpace, 5, "String")
                .IsGreaterOrEqualsThan(_entity.StringWhiteSpace, 5, "String", "Custom error message")

                .IsGreaterOrEqualsThan(_entity.StringNotEmpty, 3, "String")
                .IsGreaterOrEqualsThan(_entity.StringNotEmpty, 3, "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 4);
        }

        [TestCategory("String Validation")]
        [TestMethod("Requires a string len is lower than")]
        public void IsLowerThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .IsLowerThan(_entity.StringEmpty, 5, "String")
                .IsLowerThan(_entity.StringEmpty, 5, "String", "Custom error message")

                .IsLowerThan(_entity.StringFiveCharsLong, 5, "String")
                .IsLowerThan(_entity.StringFiveCharsLong, 5, "String", "Custom error message")

                .IsLowerThan(_entity.StringNull, 5, "String")
                .IsLowerThan(_entity.StringNull, 5, "String", "Custom error message")

                .IsLowerThan(_entity.StringWhiteSpace, 5, "String")
                .IsLowerThan(_entity.StringWhiteSpace, 5, "String", "Custom error message")

                .IsLowerThan(_entity.StringNotEmpty, 3, "String")
                .IsLowerThan(_entity.StringNotEmpty, 3, "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 4);
        }

        [TestCategory("String Validation")]
        [TestMethod("Requires a string len is lower or equals than")]
        public void IsLowerOrEqualsThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .IsLowerOrEqualsThan(_entity.StringEmpty, 5, "String")
                .IsLowerOrEqualsThan(_entity.StringEmpty, 5, "String", "Custom error message")

                .IsLowerOrEqualsThan(_entity.StringFiveCharsLong, 5, "String")
                .IsLowerOrEqualsThan(_entity.StringFiveCharsLong, 5, "String", "Custom error message")

                .IsLowerOrEqualsThan(_entity.StringNull, 5, "String")
                .IsLowerOrEqualsThan(_entity.StringNull, 5, "String", "Custom error message")

                .IsLowerOrEqualsThan(_entity.StringWhiteSpace, 5, "String")
                .IsLowerOrEqualsThan(_entity.StringWhiteSpace, 5, "String", "Custom error message")

                .IsLowerOrEqualsThan(_entity.StringNotEmpty, 3, "String")
                .IsLowerOrEqualsThan(_entity.StringNotEmpty, 3, "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("String Validation")]
        [TestMethod("Requires a string have a specific len")]
        public void AreEqualsLen()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .AreEquals(_entity.StringEmpty, 5, "String")
                .AreEquals(_entity.StringEmpty, 5, "String", "Custom error message")

                .AreEquals(_entity.StringFiveCharsLong, 5, "String")
                .AreEquals(_entity.StringFiveCharsLong, 5, "String", "Custom error message")

                .AreEquals(_entity.StringNull, 5, "String")
                .AreEquals(_entity.StringNull, 5, "String", "Custom error message")

                .AreEquals(_entity.StringWhiteSpace, 5, "String")
                .AreEquals(_entity.StringWhiteSpace, 5, "String", "Custom error message")

                .AreEquals(_entity.StringNotEmpty, 3, "String")
                .AreEquals(_entity.StringNotEmpty, 3, "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 6);
        }

        [TestCategory("String Validation")]
        [TestMethod("Requires a string do not have a specific len")]
        public void AreNotEqualsLen()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .AreNotEquals(_entity.StringEmpty, 5, "String")
                .AreNotEquals(_entity.StringEmpty, 5, "String", "Custom error message")

                .AreNotEquals(_entity.StringFiveCharsLong, 5, "String")
                .AreNotEquals(_entity.StringFiveCharsLong, 5, "String", "Custom error message")

                .AreNotEquals(_entity.StringNull, 5, "String")
                .AreNotEquals(_entity.StringNull, 5, "String", "Custom error message")

                .AreNotEquals(_entity.StringWhiteSpace, 5, "String")
                .AreNotEquals(_entity.StringWhiteSpace, 5, "String", "Custom error message")

                .AreNotEquals(_entity.StringNotEmpty, 3, "String")
                .AreNotEquals(_entity.StringNotEmpty, 3, "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("String Validation")]
        [TestMethod("requires string len to be in a range")]
        public void IsBeetween()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .IsBeetween(_entity.StringEmpty, 5, 10, "String", "Custom error message")
                
                .IsBeetween(_entity.StringFiveCharsLong, 6, 10, "String", "Custom error message")
                
                .IsBeetween(_entity.StringNull, 5, 10, "String", "Custom error message")
                
                .IsBeetween(_entity.StringWhiteSpace, 5, 10, "String", "Custom error message")
                
                .IsBeetween(_entity.StringNotEmpty, 3, 10, "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }
    }
}
