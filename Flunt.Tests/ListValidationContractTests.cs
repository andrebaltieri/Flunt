using System.Collections.Generic;
using System.Linq;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class ListValidationContractTests
    {
        [TestMethod]
        [TestCategory("ListValidation")]
        public void IsNull()
        {
            var list = new List<object>();
            list.Add(10);
            var contract = new Contract().IsNull<object>(list, "objects", "List is not empty");

            Assert.IsTrue(contract.Invalid);
            Assert.AreEqual(1, contract.Notifications.Count);
            Assert.AreEqual("List is not empty", contract.Notifications.First().Message);
        }

        [TestMethod]
        [TestCategory("ListValidation")]
        public void IsNotEmpty()
        {
            var list = new List<object>();
            var contract = new Contract().IsNotNull<object>(list, "objects", "List of objects is not empty");

            Assert.IsTrue(contract.Invalid);
            Assert.AreEqual(1, contract.Notifications.Count);
            Assert.AreEqual("List of is empty", contract.Notifications.First().Message);
        }
    }
}