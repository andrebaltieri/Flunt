using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class DocumentValidationTests
    {
        [TestCategory("Document Validation")]
        [TestMethod("Requires a string is a passport number")]
        public void IsPassport()
        {
            var contract = new Contract<string>()
                .Requires()

                // INVALID
                .IsPassport(null, "TEST 01")
                .IsPassport(null, "TEST 02", "Custom error message")

                // INVALID
                .IsPassport(string.Empty, "TEST 03")
                .IsPassport(string.Empty, "TEST 04", "Custom error message")

                // INVALID
                .IsPassport(" ", "TEST 05")
                .IsPassport(" ", "TEST 06", "Custom error message")

                // VALID
                .IsPassport("ABCDE", "TEST 07")
                .IsPassport("ABCDE", "TEST 08", "Custom error message")

                // VALID
                .IsPassport("1340", "TEST 09")
                .IsPassport("1340", "TEST 10", "Custom error message")

                // INVALID
                .IsPassport("587.461.400-18", "TEST 11")
                .IsPassport("587.461.400-18", "TEST 12", "Custom error message")

                // INVALID
                .IsPassport("774 451 480 78", "TEST 13")
                .IsPassport("774 451 480 78", "TEST 14", "Custom error message")

                // VALID
                .IsPassport("48042595034", "TEST 15")
                .IsPassport("48042595034", "TEST 16", "Custom error message")

                // VALID
                .IsPassport("48042595035", "TEST 15")
                .IsPassport("48042595035", "TEST 16", "Custom error message")

                // VALID
                .IsPassport("35245678901", "TEST 15")
                .IsPassport("35245678901", "TEST 16", "Custom error message")

                // INVALID
                .IsPassport("3524567890135245678901", "TEST 15")
                .IsPassport("3524567890135245678901", "TEST 16", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 12);
        }
    }
}
