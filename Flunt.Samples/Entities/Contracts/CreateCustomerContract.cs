using Flunt.Validations;

namespace Flunt.Samples.Entities.Contracts
{
    public class CreateCustomerContract : Contract<Customer>
    {
        public CreateCustomerContract(Customer customer)
        {
            Requires()
                .IsNotNullOrEmpty(customer.Name, "Name", "Custom error message");
        }
    }
}
