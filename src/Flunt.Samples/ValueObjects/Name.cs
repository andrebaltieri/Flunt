using Flunt.Samples.ValueObjects.Assertions;

namespace Flunt.Samples.ValueObjects;

public class Name : ValueObject
{
    public Name(
        string firstName,
        string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        Assert(this.IsValidName());
    }

    public string FirstName { get; }
    public string LastName { get; }
}