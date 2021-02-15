using Flunt.Notifications;
using Flunt.Samples.ValueObjects.Contracts;

namespace Flunt.Samples.ValueObjects
{
    public class Email : Notifiable<Notification>
    {
        public Email(string address)
        {
            Address = address;
            AddNotifications(new CreateEmailContract(this));
        }

        public string Address { get; private set; }
    }
}
