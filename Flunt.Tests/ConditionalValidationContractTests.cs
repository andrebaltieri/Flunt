using Fluent.Tests.Entities;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class ConditionalValidationContractTests
    {
        private Dummy _dummy;

        [TestMethod]
        [TestCategory("ConditionalValidation")]
        public void IfNotNullForString()
        {
            _dummy = new Dummy();
            _dummy.stringProp = "abc";

            var wrong = new Contract()
                .Requires()
                .IfNotNull(_dummy.stringProp, x => x.IsDigit(_dummy.stringProp, nameof(_dummy.stringProp), "Property should be digit if not null"));

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            _dummy.stringProp = "1234";

            var right = new Contract()
                .Requires()
                .IfNotNull(_dummy.stringProp, x => x.IsDigit(_dummy.stringProp, nameof(_dummy.stringProp), "Property should be digit if not null"))
                .IfNotNull(_dummy.stringProp, x => x.HasMinLen(_dummy.stringProp, 1, nameof(_dummy.stringProp), "Property should be digit if not null"));

            Assert.AreEqual(true, right.Valid);

            _dummy.nullableIntProp = null;

            var rightNull = new Contract()
                .Requires()
                .IfNotNull(_dummy.nullableIntProp, x => x.IsGreaterOrEqualsThan(_dummy.nullableIntProp.Value, 5, nameof(_dummy.nullableIntProp), "Property should be greater or equal than given value if not null"));

            Assert.AreEqual(true, rightNull.Valid);
        }

        [TestMethod]
        [TestCategory("ConditionalValidation")]
        public void IfNotNullForNullableInt()
        {
            _dummy = new Dummy();
            _dummy.nullableIntProp = 1;

            var wrong = new Contract()
                .Requires()
                .IfNotNull(_dummy.nullableIntProp, x => x.IsGreaterOrEqualsThan(_dummy.nullableIntProp.Value, 5, nameof(_dummy.nullableIntProp), "Property should be greater or equal than given value if not null"));

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            _dummy.nullableIntProp = null;

            var right = new Contract()
                .Requires()
                .IfNotNull(_dummy.nullableIntProp, x => x.IsGreaterOrEqualsThan(_dummy.nullableIntProp.Value, 5, nameof(_dummy.nullableIntProp), "Property should be greater or equal than given value if not null"));

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("ConditionalValidation")]
        public void IfNotNullForObject()
        {
            _dummy = new Dummy();
            _dummy.objectProp = "some other object";

            var wrong = new Contract()
                .Requires()
                .IfNotNull(_dummy.objectProp, x => x.AreEquals(_dummy.objectProp, "some object", nameof(_dummy.objectProp), "Property should be equal if not null"));

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            _dummy.objectProp = null;

            var right = new Contract()
                .Requires()
                .IfNotNull(_dummy.objectProp, x => x.AreEquals(_dummy.objectProp, "some object", nameof(_dummy.objectProp), "Property should be equal if not null"));

            Assert.AreEqual(true, right.Valid);
        }
    }
}