using Flunt.Validations;

namespace Flunt.Samples.ValueObjects.Assertions;

public static class NameAssertions
{
    public static Contract IsValidName(this Name name)
        => new Contract()
            .IsNotNull(name.FirstName, "SomeKey", "Custom message")
            .IsGreaterOrEqualsThan(name.FirstName.Length, 3, "Name", "Name should have more than 3 chars")
            .IsLowerOrEqualsThan(name.FirstName.Length, 20)
            .IsNotNull(name.LastName, "LastName")
            .IsGreaterOrEqualsThan(name.LastName.Length, 3)
            .IsLowerOrEqualsThan(name.LastName.Length, 20);
}