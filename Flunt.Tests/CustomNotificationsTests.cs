using System;
using System.Collections.Generic;
using Flunt.Notifications;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class CustomNotificationsTests
    {
        private readonly Customer _customer;

        public CustomNotificationsTests()
        {
            _customer = new Customer();
        }

        [TestCategory("Custom Notification")]
        [TestMethod("Should not register a customer without a name")]
        public void ShouldNotRegisterACustomerWithoutAName()
        {
            _customer.Name = string.Empty;
            _customer.Save();

            Assert.AreEqual(_customer.IsValid, false);
            Assert.AreEqual(_customer.Notifications.Count, 1);
        }

        [TestCategory("Custom Notification")]
        [TestMethod("Should not update a customer without an email")]
        public void ShouldNotUpdateACustomerWithoutAnEmail()
        {
            _customer.Name = "André Baltieri";
            _customer.Email = string.Empty;
            _customer.Update();

            Assert.AreEqual(_customer.IsValid, false);
            Assert.AreEqual(_customer.Notifications.Count, 1);
        }

        [TestCategory("Custom Notification")]
        [TestMethod("Should not update a customer with test email")]
        public void ShouldNotUpdateCustomersWithTestEmails()
        {
            _customer.Name = "André Baltieri";
            _customer.Email = "teste@teste.com";
            _customer.Update();

            Assert.AreEqual(_customer.IsValid, false);
            Assert.AreEqual(_customer.Notifications.Count, 1);
        }
    }

    #region #1. Create a custom notifiable class
    public class CustomNotifiable : Notifiable<CustomNotification>, INotifiable
    {
        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            foreach (var item in notifications)
            {
                var notification = new CustomNotification(item.Key, item.Message, DateTime.Now);
                AddNotification(notification);
            }
        }
    }
    #endregion

    #region #2. Create your custom notification
    public class CustomNotification : Notification
    {
        public CustomNotification(string key, string message)
        {
            Key = key;
            Message = message;
            Date = DateTime.Now;
        }

        public CustomNotification(string key, string message, DateTime date)
        {
            Key = key;
            Message = message;
            Date = date;
        }

        // Your notifications now have a date time
        public DateTime Date { get; set; }
    }
    #endregion

    #region #3. Prepare your class/contract
    public class Customer : CustomNotifiable
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public void Save()
        {
            var contract = new CreateCustomerSpecification(this);
            AddNotifications(contract.Notifications);
        }

        public void Update()
        {
            var contract = new UpdateCustomerSpecification(this);
            if (Email == "teste@teste.com")
                AddNotification(new CustomNotification("Email", "Invalid email address"));

            AddNotifications(contract.Notifications);
        }
    }

    public class CreateCustomerSpecification : Contract<Customer>
    {
        public CreateCustomerSpecification(Customer customer)
        {
            Requires()
                .IsNotNullOrEmpty(customer.Name, "FirstName", "First Name should have at least 3 chars");
        }
    }

    public class UpdateCustomerSpecification : Contract<Customer>
    {
        public UpdateCustomerSpecification(Customer customer)
        {
            Requires()
                .IsNotNullOrEmpty(customer.Name, "FirstName")
                .IsNotNullOrEmpty(customer.Email, "Email");
        }
    }
    #endregion

}
