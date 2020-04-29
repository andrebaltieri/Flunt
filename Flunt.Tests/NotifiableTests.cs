using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Flunt.Notifications;

namespace Flunt.Tests
{
    [TestClass]
    public class NotifiableTests : Notifiable
    {
        [TestMethod]
        [TestCategory("Notifiable")]
        public void AddNotificationForOneNotifiable()
        {
            var name = new Name();
            var cus = new Customer();

            AddNotifications(name);
            AddNotifications(cus);

            Assert.AreEqual(false, Valid);
            Assert.AreEqual(2, Notifications.Count);
        }

        [TestMethod]
        [TestCategory("Notifiable")]
        public void AddNotificationForMultipleNotifiable()
        {
            var name = new Name();
            var customer = new Customer();

            AddNotifications(name, customer);

            Assert.AreEqual(false, Valid);
            Assert.AreEqual(2, Notifications.Count);
        }

        [TestMethod]
        [TestCategory("Notifiable")]
        public void ClearNotifications()
        {
            var cus = new Customer();
            AddNotifications(cus);

            cus.Clear();

            Assert.AreEqual(0, cus.Notifications.Count);
        }
    }

    public class Customer : Notifiable
    {
        public Customer()
        {
            AddNotification("Test", "Testing");
        }

        public Name Name { get; set; }
    }

    public class Name : Notifiable
    {
        public Name()
        {
            AddNotification("Test", "Testing");
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
