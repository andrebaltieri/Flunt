using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class IntValidationContractTests
    {  
        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsBetweenInt()
        {
            int value = 11;
            int from = 1;
            int to = 10;

            var wrong = new ValidationContract()
                .Requires()
                .IsBetween(value, from, to, "int", "The value 11 must be between 1 and 10");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            value = 5;
            from = 1;
            to = 10;

            var right = new ValidationContract()
                .Requires()
                .IsBetween(5, 1, 10, "int", "The value 5 is between 1 and 10");

            Assert.AreEqual(true, right.Valid);
        }
    }
}
