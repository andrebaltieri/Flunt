using Flunt.Notifications;
using Flunt.Notifications.Contracts;

namespace Flunt.Validations;

public partial class Contract<TNotification> : Notifiable<TNotification> where TNotification : INotification
{
    public Contract<TNotification> Requires()
    {
        return this;
    }
}

public partial class Contract : Contract<Notification>
{
}
