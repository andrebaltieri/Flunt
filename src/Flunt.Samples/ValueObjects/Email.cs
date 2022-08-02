using Flunt.Validations;

namespace Flunt.Samples.ValueObjects;

public class Email : ValueObject
{
    public Email(string address)
        => Address = address;

    private string _address = string.Empty;

    private string Address
    {
        get => _address;
        set
        {
            _address = value.Trim().ToLower();
            Assert(new Contract().IsEmail(Address));
        }
    }

    public void Update(string address)
    {
        Address = address.Trim().ToLower();
        Assert(new Contract().IsEmail(Address));
    }
}