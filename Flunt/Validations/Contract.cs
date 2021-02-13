using Flunt.Notifications;
using System;

namespace Flunt.Validations
{
    public partial class Contract<T> : Notifiable<Notification>
    {
        public Contract<T> Requires()
        {
            return this;
        }

        public Contract<T> Join(params Notifiable<Notification>[] items)
        {
            if (items == null) return this;
            foreach (var notifiable in items)
            {
                if (notifiable.IsValid == false)
                    AddNotifications(notifiable.Notifications);
            }

            return this;
        }
    }
}
