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
                .Contains("some text here", "banana", "string", "String does not contains banana")
                .Contains("some text here", "HERE", "string", "String does not contains banana");

            Assert.AreEqual(false, x.Valid);
            Assert.AreEqual(2, x.Notifications.Count);

            var right = new Contract()
                .Requires()
                .Contains("some banana here", "banana", "string", "String does not contains banana")
                .Contains("some banana here", "BAnaNA", "string", "String does not contains banana", System.StringComparison.InvariantCultureIgnoreCase)
                .Contains("some banana here", "some banana here", "string", "String does not contains banana")
                .Contains("some banana here", "SOME BANANA HERE", "string", "String does not contains banana", System.StringComparison.InvariantCultureIgnoreCase);

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void AreEquals()
        {
            var x = new Contract()
                .Requires()
                .AreEquals("some banana here", "SOME BANANA HERE", "string", "String does not equals");
                

            Assert.AreEqual(false, x.Valid);
            Assert.AreEqual(1, x.Notifications.Count);

            var right = new Contract()
                .Requires()
                .AreEquals("some banana here", "sOmE bAnAnA heRe", "string", "String does not equals", System.StringComparison.InvariantCultureIgnoreCase);

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void AreNotEquals()
        {
            var x = new Contract()
                .Requires()
                .AreNotEquals("some banana here", "some banana here", "string", "String is equals");


            Assert.AreEqual(false, x.Valid);
            Assert.AreEqual(1, x.Notifications.Count);

            var right = new Contract()
                .Requires()
                .AreNotEquals("some banana", "sOmE bAnAnA heRe", "string", "String is equals", System.StringComparison.InvariantCultureIgnoreCase);

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


    }
}
