using Flunt.Samples.ValueObjects;

namespace Flunt.Samples.Entities;

public class Customer : Entity
{
    public Customer(Name name, Email email)
    {
        Name = name;
        Email = email;

        AppendNotifications(name, email);
    }

    public Name Name { get; }
    public Email Email { get; }
}