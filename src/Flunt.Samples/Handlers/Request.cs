using Flunt.Notifications;
using Flunt.Validations;

namespace Flunt.Samples.Handlers;

public class Request : Notifiable
{
    public Request()
    {
    }

    public Request(string firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;

        Assert(new Contract()
            .IsNotNull(FirstName, "SomeKey", "Custom message")
            .IsGreaterOrEqualsThan(FirstName.Length, 3, "Name", "Name should have more than 3 chars")
            .IsLowerOrEqualsThan(FirstName.Length, 20)
            .IsNotNull(LastName, "LastName")
            .IsGreaterOrEqualsThan(LastName.Length, 3)
            .IsLowerOrEqualsThan(LastName.Length, 20)
            .IsEmail(Email));
    }

    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}