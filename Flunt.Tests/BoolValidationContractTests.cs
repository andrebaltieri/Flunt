using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class BoolContractTests
    {
        [TestMethod]
        [TestCategory("BoolValidation")]
        public void IsTrue()
        {
            var wrong = new Contract()
                .Requires()
                .IsTrue(false, "bool", "Bool is false");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new Contract()
                .Requires()
                .IsTrue(true, "bool", "Bool is false");
            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("BoolValidation")]
        public void IsFalse()
        {
            var wrong = new Contract()
                .Requires()
                .IsFalse(true, "bool", "Bool is true");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new Contract()
                .Requires()
                .IsFalse(false, "bool", "Bool is true");
            Assert.AreEqual(true, right.Valid);
        }
    }
}