using Flunt.Tests.Entities;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class EmailValidationTests
    {
        [TestCategory("Email Validation")]
        [TestMethod("Requires a string is an email")]
        public void IsEmail()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                // Invalid
                .IsEmail("some string", "Email")
                .IsEmail("some@invalid", "Email", "Custom error message")
                .IsEmail("some string", "Email")
                .IsEmail("someinvalid.com", "Email", "Custom error message")

                // Valid
                .IsEmail("some@gmail.com", "Email")
                .IsEmail("some@hotmail.com", "Email", "Custom error message")
                .IsEmail("some@customdomain.com", "Email")
                .IsEmail("some@mydomain.com.br", "Email", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 4);
        }

        [TestCategory("Email Validation")]
        [TestMethod("Requires a string is an email or empty")]
        public void IsEmailOrEmpty()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                // Invalid
                .IsEmailOrEmpty("some string", "Email")
                .IsEmailOrEmpty("some@invalid", "Email", "Custom error message")
                .IsEmailOrEmpty("some string", "Email")
                .IsEmailOrEmpty("someinvalid.com", "Email", "Custom error message")
                .IsEmailOrEmpty(" ", "Email")
                .IsEmailOrEmpty(" ", "Email", "Custom error message")

                // Valid
                .IsEmailOrEmpty("", "Email")
                .IsEmailOrEmpty("", "Email", "Custom error message")
                .IsEmailOrEmpty(null, "Email")
                .IsEmailOrEmpty(null, "Email", "Custom error message")
                .IsEmailOrEmpty("some@gmail.com", "Email")
                .IsEmailOrEmpty("some@hotmail.com", "Email", "Custom error message")
                .IsEmailOrEmpty("some@customdomain.com", "Email")
                .IsEmailOrEmpty("some@mydomain.com.br", "Email", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 6);
        }

        [TestCategory("Email Validation")]
        [TestMethod("Requires a string is not an email")]
        public void IsNotEmail()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                // Valid
                .IsNotEmail("some string", "Email")
                .IsNotEmail("some@invalid", "Email", "Custom error message")
                .IsNotEmail("some string", "Email")
                .IsNotEmail("someinvalid.com", "Email", "Custom error message")

                // Invalid
                .IsNotEmail("some@gmail.com", "Email")
                .IsNotEmail("some@hotmail.com", "Email", "Custom error message")
                .IsNotEmail("some@customdomain.com", "Email")
                .IsNotEmail("some@mydomain.com.br", "Email", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 4);
        }
    }
}
