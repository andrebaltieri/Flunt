using Flunt.Tests.Entities;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class RegexValidationTests
    {
        [TestCategory("Regex Validation")]
        [TestMethod("Requires a string matches a pattern")]
        public void Matches()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                // Invalid
                .Matches("ABC012345", @"[^0-9]+", "Regex")
                .Matches("ABC012345", @"[^0-9]+", "Regex", "Custom error message")

                // VALID
                .Matches("012345", @"[^0-9]+", "Regex")
                .Matches("012345", @"[^0-9]+", "Regex", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }

        [TestCategory("Regex Validation")]
        [TestMethod("Requires a string not matches a pattern")]
        public void NotMatches()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                // VALID
                .NotMatches("ABC012345", @"[^0-9]+", "Regex")
                .NotMatches("ABC012345", @"[^0-9]+", "Regex", "Custom error message")

                // INVALID
                .NotMatches("012345", @"[^0-9]+", "Regex")
                .NotMatches("012345", @"[^0-9]+", "Regex", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 2);
        }
    }
}
