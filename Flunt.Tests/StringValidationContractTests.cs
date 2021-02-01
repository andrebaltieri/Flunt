using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class StringContractTests
    {
        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsNotNullOrEmpty()
        {
            var wrong = new Contract()
                .Requires()
                .IsNotNullOrEmpty(null, "string", "String is Null")
                .IsNotNullOrEmpty("", "string", "String is Empty");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            var right = new Contract()
                .Requires()
                .IsNotNullOrEmpty("Some valid string", "string", "String is Null");
            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsNotXNullOrEmpty()
        {
            var wrong = new Contract()
                .Requires()
                .IsNotNullOrEmpty(null, "string", "String is Null")
                .IsNotNullOrEmpty("", "string", "String is Empty");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            var right = new Contract()
                .Requires()
                .IsNotNullOrEmpty("Some valid string", "string", "String is Null");
            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsNotNullOrWhiteSpace()
        {
            var wrong = new Contract()
                .Requires()
                .IsNotNullOrWhiteSpace(null, "string", "String is Null")
                .IsNotNullOrWhiteSpace("     ", "string", "String is Empty");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            var right = new Contract()
                .Requires()
                .IsNotNullOrWhiteSpace("Some valid string", "string", "String is Null");
            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsNullOrEmpty()
        {
            var right = new Contract()
                .Requires()
                .IsNullOrEmpty(null, "string", "String is Null")
                .IsNullOrEmpty("", "string", "String is Empty");

            Assert.AreEqual(true, right.Valid);
            Assert.AreEqual(0, right.Notifications.Count);

            var wrong = new Contract()
                .Requires()
                .IsNullOrEmpty("Some valid string", "string", "String is Null");
            Assert.AreEqual(false, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void MinLen()
        {
            var wrong = new Contract()
                .Requires()
                .HasMinLen("null", 5, "string", "String len is less than permited");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new Contract()
                .Requires()
                .HasMinLen("Some Valid String", 5, "string", "String len is less than permited");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void MaxLen()
        {
            var x = new Contract()
                .Requires()
                .HasMaxLen("null", 3, "string", "String len is more than permited");

            Assert.AreEqual(false, x.Valid);
            Assert.AreEqual(1, x.Notifications.Count);

            var right = new Contract()
                .Requires()
                .HasMaxLen("Some", 5, "string", "String len is less than permited");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void Len()
        {
            var x = new Contract()
                .Requires()
                .HasLen("null", 3, "string", "String len is more than permited");

            Assert.AreEqual(false, x.Valid);
            Assert.AreEqual(1, x.Notifications.Count);

            var right = new Contract()
                .Requires()
                .HasLen("Some1", 5, "string", "String len is less than permited");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void Contains()
        {
            var x = new Contract()
                .Requires()
                .Contains("some text here", "banana", "string", "String does not contains banana");

            Assert.AreEqual(false, x.Valid);
            Assert.AreEqual(1, x.Notifications.Count);

            var right = new Contract()
                .Requires()
                .Contains("some banana here", "banana", "string", "String does not contains banana");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void Email()
        {
            var wrong = new Contract()
                .Requires()
                .IsEmail("wrongemail", "string", "Invalid E-mail");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new Contract()
                .Requires()
                .IsEmail("andrebaltieri@gmail.com", "string", "Invalid E-mail");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void EmailOrEmpty()
        {
            var right = new Contract()
                .Requires()
                .IsEmailOrEmpty("", "string", "Invalid E-mail");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void Url()
        {
            var wrong = new Contract()
                .Requires()
                .IsUrl("wrongurl", "string", "Invalid URL");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new Contract()
                .Requires()
                .IsUrl("https://gmail.com", "string", "Invalid URL")
                .IsUrl("http://gmail.com", "string", "Invalid URL")
                .IsUrl("http://balta.io/", "string", "Invalid URL");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void UrlOrEmpty()
        {
            var right = new Contract()
                .Requires()
                .IsUrlOrEmpty("", "string", "Invalid URL");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void Match()
        {
            var wrong = new Contract()
                .Requires()
                .Matchs("wrongurl", @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$", "string", "Invalid URL");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new Contract()
                .Requires()
                .Matchs("http://gmail.com", @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$", "string", "Invalid URL");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsDigit()
        {
            var wrong = new Contract()
                .Requires()
                .IsDigit("asdfa989798", "string", "String must have digits only");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new Contract()
                .Requires()
                .IsDigit("1234567890", "string", "String must have digits only");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void HasMinLengthIfNotNullOrEmpty()
        {
            var errorMessage = "String not null or empty and length is less than permitted";
            var wrong = new Contract()
                .Requires()
                .HasMinLengthIfNotNullOrEmpty("123456789", 10, "string", errorMessage)
                .HasMinLengthIfNotNullOrEmpty("         ", 10, "string", errorMessage);

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            var right = new Contract()
                .Requires()
                .HasMinLengthIfNotNullOrEmpty(null, 10, "string", errorMessage)
                .HasMinLengthIfNotNullOrEmpty("", 10, "string", errorMessage)
                .HasMinLengthIfNotNullOrEmpty("1234567890", 10, "string", errorMessage)
                .HasMinLengthIfNotNullOrEmpty("123456789012345", 10, "string", errorMessage);

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void HasMaxLengthIfNotNullOrEmpty()
        {
            var errorMessage = "String not null or empty and length is more than permitted";
            var wrong = new Contract()
                .Requires()
                .HasMaxLengthIfNotNullOrEmpty("123456789012345", 10, "string", errorMessage)
                .HasMaxLengthIfNotNullOrEmpty("               ", 10, "string", errorMessage);

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            var right = new Contract()
                .Requires()
                .HasMaxLengthIfNotNullOrEmpty(null, 10, "string", errorMessage)
                .HasMaxLengthIfNotNullOrEmpty("", 10, "string", errorMessage)
                .HasMaxLengthIfNotNullOrEmpty("12345", 10, "string", errorMessage)
                .HasMaxLengthIfNotNullOrEmpty("1234567890", 10, "string", errorMessage);

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void HasExactLengthIfNotNullOrEmpty()
        {
            var errorMessage = "String not null or empty and length is different than permitted";
            var wrong = new Contract()
                .Requires()
                .HasExactLengthIfNotNullOrEmpty("123456789", 10, "string", errorMessage)
                .HasExactLengthIfNotNullOrEmpty("12345678901", 10, "string", errorMessage);

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            var right = new Contract()
                .Requires()
                .HasExactLengthIfNotNullOrEmpty(null, 10, "string", errorMessage)
                .HasExactLengthIfNotNullOrEmpty("", 10, "string", errorMessage)
                .HasExactLengthIfNotNullOrEmpty("1234567890", 10, "string", errorMessage);

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void AreEquals()
        {
            var wrong = new Contract()
                .Requires()
                .IsNotNullOrEmpty(null, "string", "String is Null")
                .IsNotNullOrEmpty("", "string", "String is Empty");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            var right = new Contract()
                .Requires()
                .IsNotNullOrEmpty("Some valid string", "string", "String is Null");
            Assert.AreEqual(true, right.Valid);
        }


        [TestMethod]
        [TestCategory("StringValidation")]
        public void AreNotEquals()
        {
            var wrong = new Contract()
                .Requires()
                .AreEquals("String", "String not equals", "string", "String are not equals")
                .AreNotEquals("String", "String", "string", "String are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            var right = new Contract()
                .Requires()
                .AreEquals("String", "String", "string", "String are equals");
            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsCreditCard()
        {
            var wrong = new Contract()
                .Requires()
                .IsCreditCard("0123-4567-8910-1112", "string", "Invalid credit card");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new Contract()
            .Requires()
            .IsCreditCard("5542-4867-7143-5554", "string", "Invalid credit card")
            .IsCreditCard("4485218645194493", "string", "Invalid credit card")
            .IsCreditCard("3416 608582 70977", "string", "Invalid credit card");

            Assert.AreEqual(true, right.Valid);
        }

    }
}
