using Flunt.Notifications;
using Flunt.Samples.Handlers.Requests.Contracts;

namespace Flunt.Samples.Handlers.Requests
{
    public class CreateCustomerRequest : Notifiable<Notification>
    {
        public CreateCustomerRequest(string name, string email)
        {
            Name = name;
            Email = email;

            AddNotifications(new CreateCustomerRequestContract(this));
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}
