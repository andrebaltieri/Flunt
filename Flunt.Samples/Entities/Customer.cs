using System;
using Flunt.Samples.Entities.Contracts;
using Flunt.Samples.ValueObjects;

namespace Flunt.Samples.Entities
{
    public class Customer : Entity
    {
        public Customer(string name, Email email)
        {
            Name = name;
            Email = email;

            AddNotifications(new CreateCustomerContract(this));
        }

        public string Name { get; private set; }
        public Email Email { get; private set; }
        public DateTime BirthDate { get; private set; }

        public void UpdateBirthDate(DateTime birthDate)
        {
            BirthDate = birthDate;
            AddNotifications(new UpdateCustomerBirthDateContract(this));
        }
    }
}
