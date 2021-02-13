using Flunt.Tests.Entities;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class DecimalValidationTests
    {
        private readonly SampleEntity _entity = new SampleEntity();

        [TestCategory("Decimal Validation")]
        [TestMethod("Requires a decimal is greater than")]
        public void RequiresDateIsGreaterThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsGreaterThan(0, (int)10, "Decimal")
                .IsGreaterThan(0, (int)10, "Decimal", "Custom message here")
                .IsGreaterThan(10, (int)10, "Decimal")
                .IsGreaterThan(10, (int)10, "Decimal", "Custom message here")
                .IsGreaterThan(20, (int)10, "Decimal")
                .IsGreaterThan(20, (int)10, "Decimal", "Custom message here")

                .IsGreaterThan(0, (float)10, "Decimal")
                .IsGreaterThan(0, (float)10, "Decimal", "Custom message here")
                .IsGreaterThan(10, (float)10, "Decimal")
                .IsGreaterThan(10, (float)10, "Decimal", "Custom message here")
                .IsGreaterThan(20, (float)10, "Decimal")
                .IsGreaterThan(20, (float)10, "Decimal", "Custom message here")

                .IsGreaterThan(0, (double)10, "Decimal")
                .IsGreaterThan(0, (double)10, "Decimal", "Custom message here")
                .IsGreaterThan(10, (double)10, "Decimal")
                .IsGreaterThan(10, (double)10, "Decimal", "Custom message here")
                .IsGreaterThan(20, (double)10, "Decimal")
                .IsGreaterThan(20, (double)10, "Decimal", "Custom message here")

                .IsGreaterThan(0, (decimal)10, "Decimal")
                .IsGreaterThan(0, (decimal)10, "Decimal", "Custom message here")
                .IsGreaterThan(10, (decimal)10, "Decimal")
                .IsGreaterThan(10, (decimal)10, "Decimal", "Custom message here")
                .IsGreaterThan(20, (decimal)10, "Decimal")
                .IsGreaterThan(20, (decimal)10, "Decimal", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 16);
        }

        [TestCategory("Decimal Validation")]
        [TestMethod("Requires a decimal is greater or equals than")]
        public void RequiresDateIsGreaterOrEqualsThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsGreaterOrEqualsThan(0, (int)10, "Decimal")
                .IsGreaterOrEqualsThan(0, (int)10, "Decimal", "Custom message here")
                .IsGreaterOrEqualsThan(10, (int)10, "Decimal")
                .IsGreaterOrEqualsThan(10, (int)10, "Decimal", "Custom message here")
                .IsGreaterOrEqualsThan(20, (int)10, "Decimal")
                .IsGreaterOrEqualsThan(20, (int)10, "Decimal", "Custom message here")

                .IsGreaterOrEqualsThan(0, (float)10, "Decimal")
                .IsGreaterOrEqualsThan(0, (float)10, "Decimal", "Custom message here")
                .IsGreaterOrEqualsThan(10, (float)10, "Decimal")
                .IsGreaterOrEqualsThan(10, (float)10, "Decimal", "Custom message here")
                .IsGreaterOrEqualsThan(20, (float)10, "Decimal")
                .IsGreaterOrEqualsThan(20, (float)10, "Decimal", "Custom message here")

                .IsGreaterOrEqualsThan(0, (double)10, "Decimal")
                .IsGreaterOrEqualsThan(0, (double)10, "Decimal", "Custom message here")
                .IsGreaterOrEqualsThan(10, (double)10, "Decimal")
                .IsGreaterOrEqualsThan(10, (double)10, "Decimal", "Custom message here")
                .IsGreaterOrEqualsThan(20, (double)10, "Decimal")
                .IsGreaterOrEqualsThan(20, (double)10, "Decimal", "Custom message here")

                .IsGreaterOrEqualsThan(0, (decimal)10, "Decimal")
                .IsGreaterOrEqualsThan(0, (decimal)10, "Decimal", "Custom message here")
                .IsGreaterOrEqualsThan(10, (decimal)10, "Decimal")
                .IsGreaterOrEqualsThan(10, (decimal)10, "Decimal", "Custom message here")
                .IsGreaterOrEqualsThan(20, (decimal)10, "Decimal")
                .IsGreaterOrEqualsThan(20, (decimal)10, "Decimal", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }

        [TestCategory("Decimal Validation")]
        [TestMethod("Requires a decimal is lower than")]
        public void RequiresDateIsLowerThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsLowerThan(0, (int)0, "Decimal")
                .IsLowerThan(0, (int)0, "Decimal", "Custom message here")
                .IsLowerThan(-5, (int)0, "Decimal")
                .IsLowerThan(-5, (int)0, "Decimal", "Custom message here")
                .IsLowerThan(5, (int)0, "Decimal")
                .IsLowerThan(5, (int)0, "Decimal", "Custom message here")

                .IsLowerThan(0, (float)0, "Decimal")
                .IsLowerThan(0, (float)0, "Decimal", "Custom message here")
                .IsLowerThan(-5, (float)0, "Decimal")
                .IsLowerThan(-5, (float)0, "Decimal", "Custom message here")
                .IsLowerThan(5, (float)0, "Decimal")
                .IsLowerThan(5, (float)0, "Decimal", "Custom message here")

                .IsLowerThan(0, (double)0, "Decimal")
                .IsLowerThan(0, (double)0, "Decimal", "Custom message here")
                .IsLowerThan(-5, (double)0, "Decimal")
                .IsLowerThan(-5, (double)0, "Decimal", "Custom message here")
                .IsLowerThan(5, (double)0, "Decimal")
                .IsLowerThan(5, (double)0, "Decimal", "Custom message here")

                .IsLowerThan(0, (decimal)0, "Decimal")
                .IsLowerThan(0, (decimal)0, "Decimal", "Custom message here")
                .IsLowerThan(-5, (decimal)0, "Decimal")
                .IsLowerThan(-5, (decimal)0, "Decimal", "Custom message here")
                .IsLowerThan(5, (decimal)0, "Decimal")
                .IsLowerThan(5, (decimal)0, "Decimal", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 16);
        }

        [TestCategory("Decimal Validation")]
        [TestMethod("Requires a decimal is lower or equals than")]
        public void RequiresDateIsLowerOrEqualsThan()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()
                .IsLowerOrEqualsThan(0, (int)10, "Decimal")
                .IsLowerOrEqualsThan(0, (int)10, "Decimal", "Custom message here")
                .IsLowerOrEqualsThan(10, (int)10, "Decimal")
                .IsLowerOrEqualsThan(10, (int)10, "Decimal", "Custom message here")
                .IsLowerOrEqualsThan(20, (int)10, "Decimal")
                .IsLowerOrEqualsThan(20, (int)10, "Decimal", "Custom message here")

                .IsLowerOrEqualsThan(0, (float)10, "Decimal")
                .IsLowerOrEqualsThan(0, (float)10, "Decimal", "Custom message here")
                .IsLowerOrEqualsThan(10, (float)10, "Decimal")
                .IsLowerOrEqualsThan(10, (float)10, "Decimal", "Custom message here")
                .IsLowerOrEqualsThan(20, (float)10, "Decimal")
                .IsLowerOrEqualsThan(20, (float)10, "Decimal", "Custom message here")

                .IsLowerOrEqualsThan(0, (double)10, "Decimal")
                .IsLowerOrEqualsThan(0, (double)10, "Decimal", "Custom message here")
                .IsLowerOrEqualsThan(10, (double)10, "Decimal")
                .IsLowerOrEqualsThan(10, (double)10, "Decimal", "Custom message here")
                .IsLowerOrEqualsThan(20, (double)10, "Decimal")
                .IsLowerOrEqualsThan(20, (double)10, "Decimal", "Custom message here")

                .IsLowerOrEqualsThan(0, (decimal)10, "Decimal")
                .IsLowerOrEqualsThan(0, (decimal)10, "Decimal", "Custom message here")
                .IsLowerOrEqualsThan(10, (decimal)10, "Decimal")
                .IsLowerOrEqualsThan(10, (decimal)10, "Decimal", "Custom message here")
                .IsLowerOrEqualsThan(20, (decimal)10, "Decimal")
                .IsLowerOrEqualsThan(20, (decimal)10, "Decimal", "Custom message here");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 8);
        }
    }
}
