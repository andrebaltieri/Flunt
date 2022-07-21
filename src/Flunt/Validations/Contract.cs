using Flunt.Notifications;

namespace Flunt.Validations;

public partial class Contract : Notifiable
{
    public Contract Requires()
        => this;

    public Contract Join(params Notifiable[] items)
    {
        foreach (var notifiable in items)
            if (notifiable.IsValid == false)
                AddNotifications(notifiable.Notifications);

        return this;
    }
}