using Flunt.Validations;

namespace Flunt.Samples.ValueObjects.Contracts
{
    public class CreateEmailContract : Contract<Email>
    {
        public CreateEmailContract(Email email)
        {
            Requires()
                .IsEmail(email.Address, "Email");
        }
    }
}
