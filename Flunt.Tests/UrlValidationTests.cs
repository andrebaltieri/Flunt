using Flunt.Tests.Entities;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class UrlValidationTests
    {
        [TestCategory("URL Validation")]
        [TestMethod("Requires a string is an URL")]
        public void IsUrl()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .IsUrl("http://balta.io", "String")
                .IsUrl("http://balta.io", "String", "Custom error message")

                .IsUrl("https://balta.io", "String")
                .IsUrl("https://balta.io", "String", "Custom error message")

                .IsUrl("balta.io", "String")
                .IsUrl("balta.io", "String", "Custom error message")

                .IsUrl("none", "String")
                .IsUrl("none", "String", "Custom error message")

                .IsUrl(null, "String")
                .IsUrl(null, "String", "Custom error message")

                .IsUrl(string.Empty, "String")
                .IsUrl(string.Empty, "String", "Custom error message")

                .IsUrl(" ", "String")
                .IsUrl(" ", "String", "Custom error message")

                .IsUrl("http://localhost:1000", "String")
                .IsUrl("http://localhost:1000", "String", "Custom error message")

                .IsUrl("localhost:1000", "String")
                .IsUrl("localhost:1000", "String", "Custom error message")

                .IsUrl("https://127.0.0.1:10000", "String")
                .IsUrl("https://127.0.0.1:10000", "String", "Custom error message")

                .IsUrl("127.0.0.1:10000", "String")
                .IsUrl("127.0.0.1:10000", "String", "Custom error message")

                .IsUrl("https://127.0.256.1:10000", "String")
                .IsUrl("https://127.0.256.1:10000", "String", "Custom error message")

                .IsUrl("127.0.256.1:10000", "String")
                .IsUrl("127.0.256.1:10000", "String", "Custom error message")

                .IsUrl("http://127.0.0.1:10000/devstoreaccount1/publicacao-storage/7d9cd2c9-4b0d-4b29-b0a5-c6e6c5c2562b.png", "String")
                .IsUrl("http://127.0.0.1:10000/devstoreaccount1/publicacao-storage/7d9cd2c9-4b0d-4b29-b0a5-c6e6c5c2562b.png", "String", "Custom error message")

                .IsUrl("127.0.0.1:10000/devstoreaccount1/publicacao-storage/7d9cd2c9-4b0d-4b29-b0a5-c6e6c5c2562b.png", "String")
                .IsUrl("127.0.0.1:10000/devstoreaccount1/publicacao-storage/7d9cd2c9-4b0d-4b29-b0a5-c6e6c5c2562b.png", "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 20);
        }

        [TestCategory("URL Validation")]
        [TestMethod("Requires a string is an URL or is empty")]
        public void IsUrlOrEmpty()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .IsUrlOrEmpty("http://balta.io", "String")
                .IsUrlOrEmpty("http://balta.io", "String", "Custom error message")

                .IsUrlOrEmpty("https://balta.io", "String")
                .IsUrlOrEmpty("https://balta.io", "String", "Custom error message")

                .IsUrlOrEmpty("balta.io", "String")
                .IsUrlOrEmpty("balta.io", "String", "Custom error message")

                .IsUrlOrEmpty("none", "String")
                .IsUrlOrEmpty("none", "String", "Custom error message")

                .IsUrlOrEmpty(null, "String")
                .IsUrlOrEmpty(null, "String", "Custom error message")

                .IsUrlOrEmpty(string.Empty, "String")
                .IsUrlOrEmpty(string.Empty, "String", "Custom error message")

                .IsUrlOrEmpty(" ", "String")
                .IsUrlOrEmpty(" ", "String", "Custom error message")

                .IsUrlOrEmpty("http://localhost:1000", "String")
                .IsUrlOrEmpty("http://localhost:1000", "String", "Custom error message")

                .IsUrlOrEmpty("localhost:1000", "String")
                .IsUrlOrEmpty("localhost:1000", "String", "Custom error message")

                .IsUrlOrEmpty("https://127.0.0.1:10000", "String")
                .IsUrlOrEmpty("https://127.0.0.1:10000", "String", "Custom error message")

                .IsUrlOrEmpty("127.0.0.1:10000", "String")
                .IsUrlOrEmpty("127.0.0.1:10000", "String", "Custom error message")

                .IsUrlOrEmpty("https://127.0.256.1:10000", "String")
                .IsUrlOrEmpty("https://127.0.256.1:10000", "String", "Custom error message")

                .IsUrlOrEmpty("127.0.256.1:10000", "String")
                .IsUrlOrEmpty("127.0.256.1:10000", "String", "Custom error message")

                .IsUrlOrEmpty("http://127.0.0.1:10000/devstoreaccount1/publicacao-storage/7d9cd2c9-4b0d-4b29-b0a5-c6e6c5c2562b.png", "String")
                .IsUrlOrEmpty("http://127.0.0.1:10000/devstoreaccount1/publicacao-storage/7d9cd2c9-4b0d-4b29-b0a5-c6e6c5c2562b.png", "String", "Custom error message")

                .IsUrlOrEmpty("127.0.0.1:10000/devstoreaccount1/publicacao-storage/7d9cd2c9-4b0d-4b29-b0a5-c6e6c5c2562b.png", "String")
                .IsUrlOrEmpty("127.0.0.1:10000/devstoreaccount1/publicacao-storage/7d9cd2c9-4b0d-4b29-b0a5-c6e6c5c2562b.png", "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 16);
        }

        [TestCategory("URL Validation")]
        [TestMethod("Requires a string is not an URL")]
        public void IsNotUrl()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .IsNotUrl("http://balta.io", "String")
                .IsNotUrl("http://balta.io", "String", "Custom error message")

                .IsNotUrl("https://balta.io", "String")
                .IsNotUrl("https://balta.io", "String", "Custom error message")

                .IsNotUrl("balta.io", "String")
                .IsNotUrl("balta.io", "String", "Custom error message")

                .IsNotUrl("none", "String")
                .IsNotUrl("none", "String", "Custom error message")

                .IsNotUrl(null, "String")
                .IsNotUrl(null, "String", "Custom error message")

                .IsNotUrl(string.Empty, "String")
                .IsNotUrl(string.Empty, "String", "Custom error message")

                .IsNotUrl(" ", "String")
                .IsNotUrl(" ", "String", "Custom error message")

                .IsNotUrl("http://localhost:1000", "String")
                .IsNotUrl("http://localhost:1000", "String", "Custom error message")

                .IsNotUrl("localhost:1000", "String")
                .IsNotUrl("localhost:1000", "String", "Custom error message")

                .IsNotUrl("https://127.0.0.1:10000", "String")
                .IsNotUrl("https://127.0.0.1:10000", "String", "Custom error message")

                .IsNotUrl("127.0.0.1:10000", "String")
                .IsNotUrl("127.0.0.1:10000", "String", "Custom error message")

                .IsNotUrl("https://127.0.256.1:10000", "String")
                .IsNotUrl("https://127.0.256.1:10000", "String", "Custom error message")

                .IsNotUrl("127.0.256.1:10000", "String")
                .IsNotUrl("127.0.256.1:10000", "String", "Custom error message")

                .IsNotUrl("http://127.0.0.1:10000/devstoreaccount1/publicacao-storage/7d9cd2c9-4b0d-4b29-b0a5-c6e6c5c2562b.png", "String")
                .IsNotUrl("http://127.0.0.1:10000/devstoreaccount1/publicacao-storage/7d9cd2c9-4b0d-4b29-b0a5-c6e6c5c2562b.png", "String", "Custom error message")

                .IsNotUrl("127.0.0.1:10000/devstoreaccount1/publicacao-storage/7d9cd2c9-4b0d-4b29-b0a5-c6e6c5c2562b.png", "String")
                .IsNotUrl("127.0.0.1:10000/devstoreaccount1/publicacao-storage/7d9cd2c9-4b0d-4b29-b0a5-c6e6c5c2562b.png", "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 10);
        }

        [TestCategory("URL Validation")]
        [TestMethod("Requires a string is not an URL or is empty")]
        public void IsNotUrlOrEmpty()
        {
            var contract = new Contract<SampleEntity>()
                .Requires()

                .IsNotUrlOrEmpty("http://balta.io", "String")
                .IsNotUrlOrEmpty("http://balta.io", "String", "Custom error message")

                .IsNotUrlOrEmpty("https://balta.io", "String")
                .IsNotUrlOrEmpty("https://balta.io", "String", "Custom error message")

                .IsNotUrlOrEmpty("balta.io", "String")
                .IsNotUrlOrEmpty("balta.io", "String", "Custom error message")

                .IsNotUrlOrEmpty("none", "String")
                .IsNotUrlOrEmpty("none", "String", "Custom error message")

                .IsNotUrlOrEmpty(null, "String")
                .IsNotUrlOrEmpty(null, "String", "Custom error message")

                .IsNotUrlOrEmpty(string.Empty, "String")
                .IsNotUrlOrEmpty(string.Empty, "String", "Custom error message")

                .IsNotUrlOrEmpty(" ", "String")
                .IsNotUrlOrEmpty(" ", "String", "Custom error message")

                .IsNotUrlOrEmpty("http://localhost:1000", "String")
                .IsNotUrlOrEmpty("http://localhost:1000", "String", "Custom error message")

                .IsNotUrlOrEmpty("localhost:1000", "String")
                .IsNotUrlOrEmpty("localhost:1000", "String", "Custom error message")

                .IsNotUrlOrEmpty("https://127.0.0.1:10000", "String")
                .IsNotUrlOrEmpty("https://127.0.0.1:10000", "String", "Custom error message")

                .IsNotUrlOrEmpty("127.0.0.1:10000", "String")
                .IsNotUrlOrEmpty("127.0.0.1:10000", "String", "Custom error message")

                .IsNotUrlOrEmpty("https://127.0.256.1:10000", "String")
                .IsNotUrlOrEmpty("https://127.0.256.1:10000", "String", "Custom error message")

                .IsNotUrlOrEmpty("127.0.256.1:10000", "String")
                .IsNotUrlOrEmpty("127.0.256.1:10000", "String", "Custom error message")

                .IsNotUrlOrEmpty("http://127.0.0.1:10000/devstoreaccount1/publicacao-storage/7d9cd2c9-4b0d-4b29-b0a5-c6e6c5c2562b.png", "String")
                .IsNotUrlOrEmpty("http://127.0.0.1:10000/devstoreaccount1/publicacao-storage/7d9cd2c9-4b0d-4b29-b0a5-c6e6c5c2562b.png", "String", "Custom error message")

                .IsNotUrlOrEmpty("127.0.0.1:10000/devstoreaccount1/publicacao-storage/7d9cd2c9-4b0d-4b29-b0a5-c6e6c5c2562b.png", "String")
                .IsNotUrlOrEmpty("127.0.0.1:10000/devstoreaccount1/publicacao-storage/7d9cd2c9-4b0d-4b29-b0a5-c6e6c5c2562b.png", "String", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 10);
        }
    }
}